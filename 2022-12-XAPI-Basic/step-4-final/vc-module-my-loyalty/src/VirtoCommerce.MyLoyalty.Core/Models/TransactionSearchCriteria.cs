using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtoCommerce.MyLoyalty.Core.Models;
using VirtoCommerce.Platform.Core.Common;

namespace VirtoCommerce.MyLoyalty.Core.Models
{
    public class TransactionSearchCriteria : SearchCriteriaBase
    {
        public string StoreId { get; set; }
        public string UserId { get; set; }
    }
}
