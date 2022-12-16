using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtoCommerce.MyLoyalty.Core;
using VirtoCommerce.MyLoyalty.Core.Models;
using VirtoCommerce.MyLoyalty.Core.Services;

namespace VirtoCommerce.MyLoyalty.Data.Services
{
    public class LoyaltyService : ILoyaltyService
    {
        public Task<int> GetBalance(string userId)
        {
            if(userId == "1eb2fa8ac6574541afdb525833dadb46")
                return Task.FromResult(777);
            return Task.FromResult(0);
        }

        public Task<TransactionSearchResult> GetTransactions(TransactionSearchCriteria criteria)
        {
            var result = new TransactionSearchResult();

            if (criteria.UserId == "1eb2fa8ac6574541afdb525833dadb46")
            {
                result.TotalCount = 3;
                result.Results = new LoyaltyTransaction[] {
                    new LoyaltyTransaction { Id = "L1", Type = "Credit", Amount = 1000, Description = "Welcome Bonus", CreatedBy = "admin", ModifiedBy = "admin", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                    new LoyaltyTransaction { Id = "L1", Type = "Purchase", Amount = 200, Description = "Order: PO-1234356", CreatedBy = "admin", ModifiedBy = "admin", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
                    new LoyaltyTransaction { Id = "L1", Type = "Purchase", Amount = -33, Description = "Order: PO-1234356", CreatedBy = "admin", ModifiedBy = "admin", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow }
                };
            }


            return Task.FromResult(result);
        }
    }
}
