using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using VirtoCommerce.ExperienceApiModule.Core;
using VirtoCommerce.ExperienceApiModule.Core.BaseQueries;
using VirtoCommerce.ExperienceApiModule.Core.Extensions;
using VirtoCommerce.ExperienceApiModule.Core.Infrastructure;
using VirtoCommerce.MyLoyalty.ExperienceApi.Aggregates;
using VirtoCommerce.MyLoyalty.ExperienceApi.Schemas;

namespace VirtoCommerce.MyLoyalty.ExperienceApi.Queries
{
    public class BalanceQueryBuilder : QueryBuilder<BalanceQuery, BalanceAggregate, BalanceType>
    {
        protected override string Name => "mybalance";

        public BalanceQueryBuilder(IMediator mediator, IAuthorizationService authorizationService)
        : base(mediator, authorizationService)
        {
        }

        protected override BalanceQuery GetRequest(IResolveFieldContext<object> context)
        {
            var request = base.GetRequest(context);

            if (string.IsNullOrEmpty(request.UserId))
                request.UserId = context.GetCurrentUserId();

            return request;
        }
    }
}
