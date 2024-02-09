# Virto Commerce on .NET 8

We are pleased to invite you to our next webinar, where we reveal Virto Commerce on .NET 8.

Key topics include: 
1. What's New in .NET 8
1. Performance Benchmark
1. Update Strategy
1. Feedback & Known Limitations

[Download Presentation](VC-Webinar-2024-02.pdf)

## What's New in .NET 8
Good afternoon everyone, and welcome to our presentation on the latest updates in Virto Commerce on .NET 8. Today, we're excited to share with you the 
new features and enhancements that come with the Commerce.NET 8 release. You'll discover visual changes, updated version information, and most importantly, 
how this update ensures a smooth transition without any major breaking changes or refactoring. 

We'll dive into the technical aspects, focusing on the shift in target frameworks and the notable improvements in performance, particularly 
in Entity Framework operations.

First, I recommend to review following posts to learn more .NET 8. Microsoft Team did big effort and add a lot of interesting feaures: 
* [What's new in NET8](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8)
* [What's new in EF8 Core](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-8.0/whatsnew)
* [What's new in ASP.NET Core 8](https://learn.microsoft.com/en-us/aspnet/core/release-notes/aspnetcore-8.0?view=aspnetcore-8.0)

* .NET 8 brings these benefits:
* Enhanced Performance
* Improved Stability
* Optimized EF Operations

Second, we you can find all related information about Virto Commerce on .NET 8 in our documentation:
* [Virto Commerce on .Net8](https://docs.virtocommerce.org/platform/developer-guide/Tutorials-and-How-tos/How-tos/upgrading-to-net8/?h=net8)


### Enhanced Performance
The upgrade to .NET 8 brings substantial improvements in performance, resulting in faster response times and optimized resource utilization. This ensures a smoother and more efficient e-commerce experience for both customers and administrators.

### Improved Stability
Stability is a cornerstone of this update. By leveraging the advancements in .NET 8, Virto Commerce offers enhanced system reliability and robustness. This translates to fewer disruptions, improved error handling, and increased overall system stability.

### Optimized EF Operations
With the transition to .NET 8, bulk operations such as select, update, and delete are optimized for efficiency. This improvement is particularly beneficial for scenarios involving large datasets, providing a noticeable boost in processing speed and resource efficiency.

### Keeping Up with the Latest Technology
For me very important, that Virto Team updated target frameworks for all Virto Commerce projects to .NET 8, updated Node to 20 LTS and all 3rd party libraries to latest version, except GraphQL.


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

### VC .NET6 vs VC .NET8 / SqlServer - Memory Usage Comparison

### VC .NET6 vs VC .NET8 / SqlServer - CPU Usage Comparison

### VC .NET6 vs VC .NET8 and SqlServer vs PostgreSQL - Performance Comparison


## Update Strategy
Moving on to our update strategy, we'll outline the roadmap for transitioning your existing solutions to .NET 8. 
We've aligned our timeline with Microsoft's release schedule, ensuring long-term support for .NET 8. 
We'll walk you through the steps involved in updating Virtocommerce platforms and modules, offering practical 
guidance on executing the update process smoothly. Our goal is to empower you to plan your updates strategically, 
leveraging stable release versions and automated tools provided by Virtocommerce.

### .NET Release Schedule
Microsoft's release schedule for .NET 8 aligns with our update strategy, ensuring long-term support and compatibility with the latest features and enhancements.

### Select your pill

We have released two stable versions of Virto Commerce on .NET6 (Stable 7) and .NET 8 (Stable 8), providing you with the flexibility to choose the most suitable release for your update.

### Update Path
Virto Team has developed a clear and comprehensive update path, guiding you through the process of transitioning your existing solutions to .NET 8.

1. Install .NET8 and Update Visual Studio 2022
1. Update Virto Commerce Platform and Modules to .NET 8	
1. Update 3rd Party Libraries via Power Shell Automation.
1. Compile, Test and Deploy
1. Enjoy Virto Commerce on .NET 8

You can find step by step guide in [Virto Commerce Documentation](https://docs.virtocommerce.org/platform/developer-guide/Tutorials-and-How-tos/How-tos/upgrading-to-net8/?h=net8).


## Feedback & Known Limitations
In our final section, we'll share feedback gathered from client projects and internal testing. You'll hear about the seamless migration 
experience and the positive outcomes observed thus far. We'll also address any known limitations and potential challenges, 
including updates required for Entity Framework operations and configuration adjustments for HTTPS bindings. 
Rest assured, our team remains committed to providing ongoing support and assistance, ensuring a smooth transition to .NET 8.

### Known Limitations
At this moment, we have identified the following known limitations and potential challenges:
1. Entity Framework Packages Update: To prevent "System.MissingMethodException: Method not found errors" when call MigrationBuilder.CreateIndex, it is essential to update Entity Framework packages from version 6 to version 8.
1. Kestrel HTTPS Binding: Note that the default HTTPS binding has been removed. Refer to Microsoft Learn for more details.		
1. Pomelo.EntityFrameworkCore.MySql is still 8.0.0-beta.2. We are waiting for stable release.

If you find any new breaking changes, submit a question on [Virto Commerce Community](https://www.virtocommerce.org/).

### Feedback
We've received positive feedback from clients who have successfully migrated to .NET 8. They've reported a seamless transition and 
observed significant improvements in performance and stability. We're committed to providing ongoing support and assistance to ensure 
a smooth transition for all clients.

## Summary
By covering these key areas, the presentation aims to equip attendees with the knowledge and resources needed to leverage the 
latest advancements in .NET technology and optimize their commerce solutions for enhanced performance and scalability.