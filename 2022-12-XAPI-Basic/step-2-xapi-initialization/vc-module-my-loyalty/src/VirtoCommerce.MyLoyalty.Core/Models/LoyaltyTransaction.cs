using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtoCommerce.Platform.Core.Common;

namespace VirtoCommerce.MyLoyalty.Core.Models
{
    public class LoyaltyTransaction: AuditableEntity
    {
        public string Type { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
    }
}
