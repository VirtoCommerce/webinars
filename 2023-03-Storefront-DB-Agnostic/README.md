# Self Service Portal & Multi-App Experience

We are pleased to invite you to our next webinar, where we reveal Storefront Features and DB Agnostic Architecture in Virto Commerce.

Key topics include: 
1. Virto Storefront Features.
1. DB Agnostic Architecture.

[Download Presentation](VC-Webinar-2023-03.pdf)

## Virto Storefront Features

One of the features that sets Virto Storefront apart from other solutions is its ability to handle complex order flows with multiple suppliers. Here are some examples of how Virto Storefront can handle different order scenarios:

### Multi Vendor Shopping Cart Page
You can display products from different vendors in one shopping cart page, with clear information about the supplier, price, quantity, and availability. You can also apply discounts and coupons to your order, and update or remove items as needed.

![image](https://user-images.githubusercontent.com/7639413/227502434-69dfde61-c35e-40f8-888f-be7ffd712c82.png)

### Multi Vendor Checkout - Shipping Page
You can choose one shipping method or various shipping methods and rates for each vendor in your order.

![image](https://user-images.githubusercontent.com/7639413/227503336-1fbd04df-4691-41e0-bd9f-8ddbd75d541d.png)

### Multi Vendor Checkout - Billing Page
You can enter your billing information once and use it for all the vendors in your order. You can also choose to pay with different payment methods for each vendor, such as credit card, PayPal, or gift card. You can see the total amount and breakdown for each payment method before you confirm your order.

![image](https://user-images.githubusercontent.com/7639413/227502496-a1af6856-eb4b-41df-b3c9-0a3fb7527211.png)

### Multi Vendor Checkout - Order Review Page
You can review your order details before you place it. You can see the summary of your order items, shipping methods, payment methods, discounts, taxes, and total cost. You can also edit or cancel your order if you change your mind.

![image](https://user-images.githubusercontent.com/7639413/227502522-19cafea7-55b7-4bf1-b085-149fde90a17b.png)

![image](https://user-images.githubusercontent.com/7639413/227502553-21e31a95-6300-41a0-b368-507f3283a202.png)

### Multi Vendor Checkout - Payment Page
 You can complete your payment securely using the chosen payment methods for each vendor. You can see the confirmation message and receipt for each payment after it is processed. 
 
![image](https://user-images.githubusercontent.com/7639413/227502618-e60761e1-f15a-44bb-bebc-4568b6c9bb48.png)

### Multi Vendor Order Details Page
You can view the details of your order after it is placed. You can see the information about each vendor, product, shipment, payment, and invoice in one page.

![image](https://user-images.githubusercontent.com/7639413/227502649-a96a9126-829d-4c88-a306-c524fcf14c52.png)

## DB Agnostic Architecture

### Overview
Today, I want to talk to you about Virto Commerce Platform's DB Agnostic.

We offer unlimited scalability – you are flexible to choose Best in bread Database.

Virto Commerce is designed to streamline your operations, delivering the results you need to succeed.

Finally, we understand that cost is always a concern, which is why we offer a range of out-of-the-box database providers, including Microsoft SQL Server, MySql, and PostgreSql. By choosing the ideal database engine for your unique scenario, you can cut operational costs and experience significant savings.

![image](https://user-images.githubusercontent.com/7639413/227505505-ed443d9b-1fd1-491f-923e-5acc9e746d9e.png)

### Architecture Principles

We designed DB Agnostic Architecture; we focus on few architecture principles.

1. No Braking Changes
1. Built with Entity Framework 6
1. Database Provider Isolation on Project Level
1. Support Customization and Specific 

First, No Braking Changes. You can update without breaking changes in your solution.

Secondly, building a DB Agnostic system with well-known Entity Framework can provide many benefits. 

Thirdly, the principle of Provider Isolation. We isolate database specific code as a specific project. This approach allows for each project to utilize the database provider that best suits its specific needs, without affecting core project.

Finally, We added Support for customization by specific Database providers need. By allowing for customization at the provider level, you can take advantage of the unique features and capabilities of each database technology, while still benefiting from the DB agnostic approach.

### Virto Commerce with PostgreSql

#### Prerequsites 
1. PostgreSQL 12+
1. Virto Commerce CLI (VC-BUILD) 3.12+
1. Virto Commerce Platform 3.293+

#### Step 1. Install Virto Commerce

![image](https://user-images.githubusercontent.com/7639413/227506233-71268292-dafe-478b-8615-51d78ad8d8bc.png)

1. Open your preferred file explorer and navigate to the directory where you want to create a new folder.
1. Right-click and select "New Folder" to create a new folder.
1. Open PowerShell as an administrator.
1. Navigate to the folder you created in step 1 using the "cd" command.
1. Run the command "vc-build install" to install Virto Commerce with the Commerce bundle. Note that this command assumes you have already installed vc-build.

#### Step 2. Setup DB Provider

![image](https://user-images.githubusercontent.com/7639413/227506331-a1dc9c24-75e6-4b0d-a76e-6099773a2be9.png)

1. Open PostgreSQL and connect to the server where you want to create the new database.
1. Run the SQL command "CREATE DATABASE [database_name];" to create a new database.
1. Open the project solution in Visual Studio or your preferred text editor.
1. Locate the appsettings.json file in the project directory.
1. Open the appsettings.json file and find the "DatabaseProvider" property.
1. Change the value of the "DatabaseProvider" property to "PostgreSql".
1. Locate the "ConnectionString/VirtoCommerce" property in the appsettings.json file.
1. Change the value of the "ConnectionString" property to match the connection details for the newly created PostgreSQL database. 

#### Step 3. Run Virto Commerce on PostgreSql
![image](https://user-images.githubusercontent.com/7639413/227506487-934c18d2-ded2-494d-b32f-18d17033d9ca.png)

### Create a Custom Module with DB Agnostic Approach

This is a useful technique if you want to develop a module that can work with different database systems without having to rewrite your code for each one.

Virto Commerce Module Templates for Dotnet is a tool that helps you generate the basic structure and files for a new module based on some parameters. You can find it on GitHub: https://github.com/VirtoCommerce/vc-cli-module-template

To create a new module with a database agnostic approach, you need to run the following command:

```cmd
dotnet new vc-module-dba-template --ModuleName CustomerReviews --Author "Jon Doe" --CompanyName VirtoCommerce
```

This will create a folder named CustomerReviews containing all the required projects and files for your module. You can then open solution in Visual Studio.

The key points to understand about this template are:
* It contains four projects related to data access: Data and Data.[Provider] projects.
* The Data.[Provider] projects have a specific structure and configuration for each database system: MySql, PostgreSql, and SqlServer.
* The Data project contains the common data models and interfaces that are shared by all database systems.
* The Module.Initialize method registers the DbContext service using the AddDbContext extension method from Virto Commerce Platform Core library.
* The OnModelCreating extension method allows you to customize the entity type configuration for different database systems using conditional compilation symbols.

Let's take a closer look at each of these points.

#### Data and Data.[Provider] projects
The template generates four projects related to data access:

* CustomerReviews.Data
* CustomerReviews.Data.MySql
* CustomerReviews.Data.PostgreSql
* CustomerReviews.Data.SqlServer

![image](https://user-images.githubusercontent.com/7639413/227507073-c43b4ab4-8ec4-4909-b945-31468ed473d3.png)


These projects allow your module to be database agnostic, meaning it can be easily adapted to work with different database systems without significant code changes.

Each project provides a specific implementation for working with a particular database system, while the CustomerReviews.Data project serves as the common base for all database-related functionality.

This architecture was designed to promote code reusability, maintainability, and scalability.

#### Data.[Provider] projects structure

![image](https://user-images.githubusercontent.com/7639413/227507161-60173104-239e-48e6-83e7-cd156ffdf2d6.png)

Each Data.[Provider] project has the following structure:

* Migrations folder - contains the migration files for the database system.
* DbContextOptionsBuilderExtensions class - contains the helper method for configuring the DbContextOptionsBuilder for specific database provider.
* [Provider]DbContextFactory class - contains implementation of IDesignTimeDbContextFactory for  for specific database provider.  
* Readme.md file - contains the instructions for configuring and migration creation the specific database provider.

#### Switch Between Providers

![image](https://user-images.githubusercontent.com/7639413/227507383-ef590b51-95b9-4084-9948-2d49688c70f5.png)

#### [Provider] Model Customization
One of the features of Virto Commerce is that it allows you to configure various aspects of the entity type required
for a specific database provider needs. For example, you can specify the properties, keys, indexes, relationships,
etc. of your entities using a fluent API.

![image](https://user-images.githubusercontent.com/7639413/227507434-ec010d7f-9d14-46b0-99cb-c897581f17b1.png)

To use this feature, you need to implement the IEntityTypeConfiguration<TEntity> interface in your entity configuration classes.
This interface defines a method called Configure that takes an EntityTypeBuilder<TEntity> parameter and
configures various aspects of the entity type.

The following code snippet shows an example of how to implement this interface for a CurrencyEntity entity:

```cs
    public class CurrencyEntityConfiguration : IEntityTypeConfiguration<CurrencyEntity>
    {
        public void Configure(EntityTypeBuilder<CurrencyEntity> builder)
        {
            builder.Property(x => x.ExchangeRate).HasColumnType("decimal").HasPrecision(18, 4);
        }
    }
```

### How to Transform a Custom Module to Support DB Agnostic Approach.
    
1. Add new Data.[Provider] projects.
1. Add Project references.
 1. Add Packages for Specific Database Provider:
 1. MySql - Pomelo.EntityFrameworkCore.MySql 6.0.0
 1. PostgreSql - Npgsql.EntityFrameworkCore.PostgreSQL 6.0.0
 1. Sql Server - Microsoft.EntityFrameworkCore.SqlServer
1. Copy and Update DbContextOptionsBuilderExtensions.cs, PostgreSqlDbContextFactory.cs and Readme.md.
1. Add DB Agnostic AddDbContext in Module.Initialize.
1. Add customization extension OnModelCreating to allow configuration for an entity type for different database types.
1. Refactor and Isolate Raw Sql Server Code. 
1. Copy Migrations from Data to SqlServer.
1. Create a new Migrations.
1. Compile, Compress and Test.

### Summary
By choosing the ideal database engine for your unique scenario, you can cut operational costs and experience significant savings.


