# Virto Commerce on .NET 8

![Slide1](https://github.com/VirtoCommerce/webinars/assets/7639413/137cd307-2fa9-4e58-84f8-b40a72e78723)

We are pleased to invite you to our next webinar, where we reveal Virto Commerce on .NET 8.

Key topics include: 
1. What's New in .NET 8
1. Performance Benchmark
1. Update Strategy
1. Feedback & Known Limitations

[Download Presentation](VC-Webinar-2024-02.pdf)

## What's New in .NET 8
Good afternoon everyone, and welcome to our presentation on the latest updates in Virto Commerce on .NET 8. Today, we're excited to share the
new features and enhancements of the Commerce.NET 8 release. You'll discover visual changes, updated version information, and most importantly, 
how this update ensures a smooth transition without any major breaking changes or refactoring. 

New background and system information can help you to understand that you on .NET8.

![Slide3](https://github.com/VirtoCommerce/webinars/assets/7639413/5987f27e-0c15-434e-bdcb-755b26d9249b)

We'll dive into the technical aspects, focusing on the shift in target frameworks and the notable improvements in performance, particularly 
in Entity Framework operations.

First, I recommend reviewing the following posts to learn more .NET 8. Microsoft Team made big effort and added a lot of interesting features: 
* [What's new in NET8](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8)
* [What's new in EF8 Core](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-8.0/whatsnew)
* [What's new in ASP.NET Core 8](https://learn.microsoft.com/en-us/aspnet/core/release-notes/aspnetcore-8.0?view=aspnetcore-8.0)

.NET 8 brings these benefits:
* Enhanced Performance
* Improved Stability
* Optimized EF Operations

Second, you can find all related information about Virto Commerce on .NET 8 in our documentation:
* [Virto Commerce on .Net8](https://docs.virtocommerce.org/platform/developer-guide/Tutorials-and-How-tos/How-tos/upgrading-to-net8/?h=net8)

### Enhanced Performance
The upgrade to .NET 8 brings substantial performance improvements, resulting in faster response times and optimized resource utilization. This ensures a smoother and more efficient e-commerce experience for both customers and administrators.

### Improved Stability
Stability is a cornerstone of this update. By leveraging the advancements in .NET 8, Virto Commerce offers enhanced system reliability and robustness. This translates to fewer disruptions, improved error handling, and increased overall system stability.

### Optimized EF Operations
With the transition to .NET 8, bulk operations such as select, update, and delete are optimized for efficiency. This improvement is particularly beneficial for large dataset scenarios, providing a noticeable boost in processing speed and resource efficiency.

### Keeping Up with the Latest Technology
For me very important, that Virto Team updated target frameworks for all Virto Commerce projects to .NET 8, updated Node to 20 LTS and all 3rd party libraries to the latest version, except GraphQL.


## Performance Benchmark
Now, let's turn our attention to performance benchmarking. We've conducted tests in our typical commerce solution environment hosted in the Virto cloud. 
Our findings reveal significant performance improvements ranging from 10% to 35% in various operations, demonstrating the tangible benefits 
of upgrading to .NET 8. We'll also discuss memory usage and resource allocation comparisons, providing insights into 
the platform's efficiency and scalability.

### Environment Setup

To compare the performance of Virto Commerce on .NET 8, we conducted tests in a typical commerce solution environment hosted in the Virto cloud.

Following are the details of the environment setup:
1. Virto Cloud / 2 instances – 1 Core & 2Gb RAM
1. Linux
1. 500-750 customers on site / Google Analytics 
1. B2B customer experience with 40 items in cart
1. Platform: VC .NET 6 and VC .NET8
1. Database Providers: SqlServer and PostgreSQL


### VC .NET6 vs VC .NET8 / SqlServer - Performance Comparison
![Slide9](https://github.com/VirtoCommerce/webinars/assets/7639413/e75bcac1-a189-48fc-9242-204480596d4a)

### VC .NET6 vs VC .NET8 / SqlServer - Memory Usage Comparison
![Slide10](https://github.com/VirtoCommerce/webinars/assets/7639413/a9bfc621-b2de-48e1-aead-935c95afad95)

### VC .NET6 vs VC .NET8 / SqlServer - CPU Usage Comparison
![Slide11](https://github.com/VirtoCommerce/webinars/assets/7639413/202bc18a-a2bd-4076-82b6-03d298cdf5b1)

### VC .NET6 vs VC .NET8 and SqlServer vs PostgreSQL - Performance Comparison
![Slide12](https://github.com/VirtoCommerce/webinars/assets/7639413/b913e69b-7997-48c9-b62e-776f5c6ec50a)
![Slide13](https://github.com/VirtoCommerce/webinars/assets/7639413/f5ce6449-ec76-4d82-80a7-98a9f553db7a)
![Slide14](https://github.com/VirtoCommerce/webinars/assets/7639413/290a6443-47c5-4fca-bc44-643dc2fec261)

## Update Strategy
Moving on to our update strategy, we'll outline the roadmap for transitioning your existing solutions to .NET 8. 
We've aligned our timeline with Microsoft's release schedule, ensuring long-term support for .NET 8. 
We'll walk you through the steps involved in updating Virtocommerce platforms and modules, offering practical 
guidance on executing the update process smoothly. Our goal is to empower you to plan your updates strategically, 
leveraging stable release versions and automated tools provided by Virtocommerce.

### .NET Release Schedule
Microsoft's release schedule for .NET 8 aligns with our update strategy, ensuring long-term support and compatibility with the latest features and enhancements.

![Slide18](https://github.com/VirtoCommerce/webinars/assets/7639413/34245461-cafe-493c-9b06-f7c23641ecd3)

### Select your pill
We have released two stable versions of Virto Commerce on .NET6 (Stable 7) and .NET8 (Stable 8), providing you with the flexibility to choose the most suitable release for your update. We are planning to support both stable releases at the same time.

![Slide19](https://github.com/VirtoCommerce/webinars/assets/7639413/103d5bb5-50dd-4384-b75f-e5379a296409)

### Update Path
The Virto Team has developed a clear and comprehensive update path, guiding you through the process of transitioning your existing solutions to .NET 8.

1. Install .NET8 and Update Visual Studio 2022
1. Update Virto Commerce Platform and Modules to .NET 8	
1. Update 3rd Party Libraries via Power Shell Automation.
1. Compile, Test and Deploy
1. Enjoy Virto Commerce on .NET 8

You can find step by step guide in [Virto Commerce Documentation](https://docs.virtocommerce.org/platform/developer-guide/Tutorials-and-How-tos/How-tos/upgrading-to-net8/?h=net8).

![Slide21](https://github.com/VirtoCommerce/webinars/assets/7639413/d6735418-0798-4c6c-9382-85139c5d443d)

## Feedback & Known Limitations
In our final section, we'll share feedback gathered from client projects and internal testing. You'll hear about the seamless migration 
experience and the positive outcomes observed thus far. We'll also address any known limitations and potential challenges, 
including updates required for Entity Framework operations and configuration adjustments for HTTPS bindings. 
Rest assured, our team remains committed to providing ongoing support and assistance, ensuring a smooth transition to .NET 8.

![Slide24](https://github.com/VirtoCommerce/webinars/assets/7639413/0571f05a-09b1-4829-bb23-e416ba9688c0)

### Known Limitations
At this moment, we have identified the following known limitations and potential challenges:
1. Entity Framework Packages Update: To prevent "System.MissingMethodException: Method not found errors" when calling MigrationBuilder.CreateIndex, it is essential to update Entity Framework packages from version 6 to version 8.
1. Kestrel HTTPS Binding: Note that the default HTTPS binding has been removed. Refer to Microsoft Learn for more details.		
1. Pomelo.EntityFrameworkCore.MySql is still 8.0.0-beta.2. We are waiting for the stable release.

If you find any new breaking changes, submit a question on [Virto Commerce Community](https://www.virtocommerce.org/).

### Feedback
We've received positive feedback from clients who have successfully migrated to .NET 8. They've reported a seamless transition and 
observed significant improvements in performance and stability. We're committed to providing ongoing support and assistance to ensure 
a smooth transition for all clients.

## Summary
By covering these key areas, the presentation aims to equip attendees with the knowledge and resources needed to leverage the 
latest advancements in Virto Commerce and .NET technology and optimize their commerce solutions for enhanced performance and scalability.
