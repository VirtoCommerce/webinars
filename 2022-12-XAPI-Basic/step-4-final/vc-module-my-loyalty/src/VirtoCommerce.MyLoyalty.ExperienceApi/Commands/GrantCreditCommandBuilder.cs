using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtoCommerce.ExperienceApiModule.Core.Infrastructure;
using VirtoCommerce.ExperienceApiModule.Core.BaseQueries;
using VirtoCommerce.MyLoyalty.ExperienceApi.Aggregates;
using GraphQL;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using VirtoCommerce.MyLoyalty.ExperienceApi.Schemas;

namespace VirtoCommerce.MyLoyalty.ExperienceApi.Commands
{
    public class GrantCreditCommandBuilder : CommandBuilder<GrantCreditCommand, BalanceAggregate, GrantCreditType, BalanceType>
    {
        protected override string Name => "grantCredit";

        public GrantCreditCommandBuilder(IMediator mediator, IAuthorizationService authorizationService)
            : base(mediator, authorizationService)
        {
        }
    }
}
