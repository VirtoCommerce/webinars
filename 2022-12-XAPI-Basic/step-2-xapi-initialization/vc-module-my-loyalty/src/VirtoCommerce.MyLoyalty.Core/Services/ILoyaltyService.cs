using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtoCommerce.MyLoyalty.Core.Models;

namespace VirtoCommerce.MyLoyalty.Core.Services
{
    public interface ILoyaltyService
    {
        Task<int> GetBalance(string userId);

        Task<TransactionSearchResult> GetTransactions(TransactionSearchCriteria criteria);
    }
}
