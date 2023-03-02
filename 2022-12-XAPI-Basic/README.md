# Virto Commerce XAPI Technical Walkthrough
Learn how XAPI works and how to add XAPI to Virto Commerce Module. Explore XAPI setup, configuring schema, handling requests and how to use Graph QL playground to test queries and mutations.

This learning path helps you add the first XAPI into your Virto Commerce module.

[Download Presentation](2022-12-XAPI-Basic.pdf)

## Overview
The Experience API (XAPI) project is primarily an intermediated layer between clients and enterprise services powered by GraphQL protocol. It is tightly coupled to a specific user/touchpoint experience with fast and reliable access. It represents an implementation of the back end for the front end (BFF) design pattern.

![image](https://user-images.githubusercontent.com/7639413/208039301-3ce86133-ec5c-4ed8-9843-23d74acee1da.png)

We designed Experience layer (XAPI) with several principles:
1. One Business API.
1. High-performance/Scalable API.
1. GraphQL protocol optimized for Storefront Applications.
1. For real-time orchestration and business logic.
1. Supports Virto Commerce Extensibility Framework.
1. 100% business logic moved from Virto Commerce Storefront to XAPI.
1. Ready For Production.

In this post, we will focus on adding XAPI setup, configuring schema, handling requests and how using Graph QL playground to test queries and mutations.

## Prerequisites
1. [Learn GraphQL](https://graphql.org/learn/)
1. [Learn GraphQL.NET library](https://github.com/graphql-dotnet/graphql-dotnet)
1. [Find more information about XAPI on Virto Commerce Developer Center](https://docs.virtocommerce.org/new/dev_docs/)

## Lab. Add XAPI to VC Module
In the next steps, I will add XAPI for the Loyalty service, so that Storefront Developer can use XAPI to get data and render customer's balance and transactions on either Storefront Front or Mobile Application or Chatbot. 

### Step 1. Create a new Virto Commerce module
First, I use dotnet new command to create a Virto Commerce module project based on a template. 

1. Open Windows PowerShell CMD .
1. Run command to install Virto Commerce template.

  ```cmd
  dotnet new --install VirtoCommerce.Module.Template
  ```

To create a new Virto Commerce module project from template:
  ```cmd
  dotnet new vc-module --ModuleName MyLoyalty --Author "Oleg Zhuk" --CompanyName VirtoCommerce 
  ```

### Step 2. Add XAPI Project to VC Module
I added a new [ILoyaltyService](step-2-xapi-initialization/vc-module-my-loyalty/src/VirtoCommerce.MyLoyalty.Core/Services/ILoyaltyService.cs) interface.

This service will be responsible for retrieving Loyalty Balance and Transactions for customers.

For demo purpose, the solution doesn't have any real implementation for service. Only, mock [LoyaltyService](step-2-xapi-initialization/vc-module-my-loyalty/src/VirtoCommerce.MyLoyalty.Data/Services/LoyaltyService.cs). 

You add XAPI into your Virto Commerce module, you need following few steps:

1. Add VirtoCommerce.MyLoyalty.ExperienceApi .NET class library project.
1. Add Nuget Package Reference on VirtoCommerce.ExperienceApiModule.Core into VirtoCommerce.MyLoyalty.ExperienceApi project.
  ```xml
  <PackageReference Include="VirtoCommerce.ExperienceApiModule.Core" Version="3.233.0" />.
  ```
1. Register dependency on VirtoCommerce.ExperienceApi into module.manifest:
  ```xml
  <dependency id="VirtoCommerce.ExperienceApi" version="3.233.0" />
  ```
1. Add AssemblyMarker class into VirtoCommerce.MyLoyalty.ExperienceApi project. We use it as reference for XAPI initialization.

1. Add XAPI initialization into Module.Initialization section.
```cs
        // GraphQL
        var assemblyMarker = typeof(AssemblyMarker);
        var graphQlBuilder = new CustomGraphQLBuilder(serviceCollection);
        graphQlBuilder.AddGraphTypes(assemblyMarker);
        serviceCollection.AddMediatR(assemblyMarker);
        serviceCollection.AddAutoMapper(assemblyMarker);
        serviceCollection.AddSchemaBuilders(assemblyMarker);
```

### Step 3. Create a First Query
At its simplest, GraphQL is about asking for specific fields on objects. Let's start by registering Request, Response Schemas and Handlers.  

1. Add request and response models: BalanceAggregate and BalanceType. 
1. Add GraphQL schemas: BalanceQuery and BalanceQueryBuilder. GraphQL engine loads all meta information from these definitions.   
1. Add BalanceQueryHandler and add implementation for request processing. 

Build, Compress, Deploy and Run the MyLoyalty module.

Let's start by looking at a very simple query to load customer balance.

To explore the GraphQL API, you can use an interactive graphql-playground environment. To open playground console open ui/playground in the platform manager application.
```cmd
https://localhost:5001/ui/playground
```
and the result we get when we run it:
![image](https://user-images.githubusercontent.com/7639413/208044593-7dcbc20c-ebf7-4233-9e54-3cf6eabec432.png)

```json
{
  mybalance(storeId: "B2B-store") {
    balance
  }
}
```

For Authorization, you need to get token from connect/token API.
```cmd
https://localhost:5001/connect/token
```
and pass it into HTTP HEADERS:
```json
{"Authorization":"Bearer <Token>"}
```

### Step 4. Add additional Queries and Commands.
![image](https://user-images.githubusercontent.com/7639413/208046071-662c33f5-4872-4fa4-a68a-ad88dace522f.png)

In [step-4-final/vc-module-my-loyalty](step-4-final/vc-module-my-loyalty) you can find the final sample with:

Get Balance Query
```json
{
  mybalance(storeId: "B2B-store") {
    balance
  }
}
```

Load My Transactions Query
```json
{
  loyaltyTransactions(storeId: "B2B-store") {
    items {
      id
      type
      amount
      description
    }
  }
}
```

Grant Credit Mutation
```json
mutation grantCredit($command: GrantCreditType!) {
  grantCredit(command: $command) {
    balance
  }
}

{ "command": {"userId": "Test", "storeId": "B2B-store", "amount": 250} }
```

## References
1. [Introduction to GraphQL ](https://graphql.org/learn/)
2. [GraphQL.NET library](https://github.com/graphql-dotnet/graphql-dotnet)
3. [Common classes and extension methods for XAPI](https://github.com/VirtoCommerce/vc-module-experience-api/pull/343/commits/09cf68f926a9d242c807d41b7d344e30c5dab5e5)
4. [xAPI Virto Commerce Documentation](https://docs.virtocommerce.org/new/dev_docs/GraphQL-Storefront-API-Reference-xAPI/#key-features)
