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
using VirtoCommerce.MyLoyalty.Core;
using VirtoCommerce.MyLoyalty.Core.Models;
using VirtoCommerce.MyLoyalty.Core.Services;
using VirtoCommerce.MyLoyalty.ExperienceApi.Aggregates;

namespace VirtoCommerce.MyLoyalty.ExperienceApi.Queries
{
    public class TransactionsQueryHandler : IQueryHandler<TransactionsQuery, TransactionSearchResult>
    {
        private readonly ILoyaltyService _loyaltyService;

        public TransactionsQueryHandler(ILoyaltyService loyaltyService)
        {
            _loyaltyService = loyaltyService;
        }

        public Task<TransactionSearchResult> Handle(TransactionsQuery request, CancellationToken cancellationToken)
        {
            return _loyaltyService.GetTransactions(new TransactionSearchCriteria { UserId = request.UserId,
                StoreId = request.StoreId,
                Take = request.Take,
                Skip = request.Skip });
        }
    }
}
