using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VirtoCommerce.Platform.Core.Modularity;
using VirtoCommerce.Platform.Core.Security;
using VirtoCommerce.Platform.Core.Settings;
using VirtoCommerce.MyLoyalty.Core;
using VirtoCommerce.MyLoyalty.Core.Models;
using VirtoCommerce.MyLoyalty.Data.Repositories;
using VirtoCommerce.MyLoyalty.Data.Services;
using VirtoCommerce.MyLoyalty.Core.Services;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using VirtoCommerce.ExperienceApiModule.Core.Extensions;
using VirtoCommerce.ExperienceApiModule.Core.Infrastructure;
using VirtoCommerce.MyLoyalty.ExperienceApi;
using GraphQL.Server;

namespace VirtoCommerce.MyLoyalty.Web;

public class Module : IModule, IHasConfiguration
{
    public ManifestModuleInfo ModuleInfo { get; set; }
    public IConfiguration Configuration { get; set; }

    public void Initialize(IServiceCollection serviceCollection)
    {
        // Initialize database
        var connectionString = Configuration.GetConnectionString(ModuleInfo.Id) ??
                               Configuration.GetConnectionString("VirtoCommerce");

        serviceCollection.AddDbContext<MyLoyaltyDbContext>(options => options.UseSqlServer(connectionString));

        // Override models
        //AbstractTypeFactory<OriginalModel>.OverrideType<OriginalModel, ExtendedModel>().MapToType<ExtendedEntity>();
        //AbstractTypeFactory<OriginalEntity>.OverrideType<OriginalEntity, ExtendedEntity>();

        // Register services
        //serviceCollection.AddTransient<IMyService, MyService>();
        serviceCollection.AddTransient<ILoyaltyService, LoyaltyService>();

        // GraphQL
        var assemblyMarker = typeof(AssemblyMarker);
        var graphQlBuilder = new CustomGraphQLBuilder(serviceCollection);
        graphQlBuilder.AddGraphTypes(assemblyMarker);
        serviceCollection.AddMediatR(assemblyMarker);
        serviceCollection.AddAutoMapper(assemblyMarker);
        serviceCollection.AddSchemaBuilders(assemblyMarker);
    }

    public void PostInitialize(IApplicationBuilder appBuilder)
    {
        var serviceProvider = appBuilder.ApplicationServices;

        // Register settings
        var settingsRegistrar = serviceProvider.GetRequiredService<ISettingsRegistrar>();
        settingsRegistrar.RegisterSettings(ModuleConstants.Settings.AllSettings, ModuleInfo.Id);

        // Register permissions
        var permissionsRegistrar = serviceProvider.GetRequiredService<IPermissionsRegistrar>();
        permissionsRegistrar.RegisterPermissions(ModuleConstants.Security.Permissions.AllPermissions
            .Select(x => new Permission { ModuleId = ModuleInfo.Id, GroupName = "MyLoyalty", Name = x })
            .ToArray());

        // Apply migrations
        using var serviceScope = serviceProvider.CreateScope();
        using var dbContext = serviceScope.ServiceProvider.GetRequiredService<MyLoyaltyDbContext>();
        dbContext.Database.Migrate();
    }

    public void Uninstall()
    {
        // Nothing to do here
    }
}
