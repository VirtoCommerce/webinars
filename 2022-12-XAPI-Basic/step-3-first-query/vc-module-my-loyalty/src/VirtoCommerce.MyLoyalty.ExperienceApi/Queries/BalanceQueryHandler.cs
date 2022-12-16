using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using Microsoft.AspNetCore.Http;
using Polly;
using VirtoCommerce.ExperienceApiModule.Core;
using VirtoCommerce.ExperienceApiModule.Core.Infrastructure;
using VirtoCommerce.MyLoyalty.Core.Services;
using VirtoCommerce.MyLoyalty.ExperienceApi.Aggregates;

namespace VirtoCommerce.MyLoyalty.ExperienceApi.Queries
{
    public class BalanceQueryHandler : IQueryHandler<BalanceQuery, BalanceAggregate>
    {
        private readonly ILoyaltyService _loyaltyService;

        public BalanceQueryHandler(ILoyaltyService loyaltyService)
        {
            _loyaltyService = loyaltyService;
        }

        public async Task<BalanceAggregate> Handle(BalanceQuery request, CancellationToken cancellationToken)
        {
            var result = new BalanceAggregate();

            result.Balance = await _loyaltyService.GetBalance(request.UserId);

            return result;
        }
    }
}
