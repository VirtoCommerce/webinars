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
using VirtoCommerce.MyLoyalty.ExperienceApi.Commands;

namespace VirtoCommerce.MyLoyalty.ExperienceApi.Schemas
{
    public class GrantCreditType : InputObjectGraphType<GrantCreditCommand>
    {
        public GrantCreditType()
        {
            Field(x => x.UserId, nullable: false);
            Field(x => x.StoreId, nullable: false);
            Field(x => x.Amount, nullable: false);
        }
    }
}
