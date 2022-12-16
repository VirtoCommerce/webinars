using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Types;
using VirtoCommerce.ExperienceApiModule.Core.Schemas;
using VirtoCommerce.ExperienceApiModule.Core.Services;
using VirtoCommerce.MyLoyalty.Core.Models;
using VirtoCommerce.MyLoyalty.ExperienceApi.Aggregates;

namespace VirtoCommerce.MyLoyalty.ExperienceApi.Schemas
{
    public class LoyaltyTransactionType : ExtendableGraphType<LoyaltyTransaction>
    {
        public LoyaltyTransactionType(IDynamicPropertyResolverService dynamicPropertyResolverService)
        {
            Field(x => x.Id, nullable: false);
            Field(x => x.CreatedBy, nullable: true);
            Field(x => x.CreatedDate, nullable: false);
            Field(x => x.ModifiedBy, nullable: true);
            Field(x => x.ModifiedDate, nullable: true);

            Field(x => x.Type, nullable: false);
            Field(x => x.Amount, nullable: false);
            Field(x => x.Description, nullable: false);
        }
    }
}
