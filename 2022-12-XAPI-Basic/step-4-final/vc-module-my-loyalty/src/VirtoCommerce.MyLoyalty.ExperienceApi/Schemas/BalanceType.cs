using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Types;
using VirtoCommerce.ExperienceApiModule.Core.Schemas;
using VirtoCommerce.ExperienceApiModule.Core.Services;
using VirtoCommerce.MyLoyalty.ExperienceApi.Aggregates;

namespace VirtoCommerce.MyLoyalty.ExperienceApi.Schemas
{
    public class BalanceType : ExtendableGraphType<BalanceAggregate>
    {
        public BalanceType(IDynamicPropertyResolverService dynamicPropertyResolverService)
        {
            Field(x => x.Balance, nullable: false);
        }
    }
}
