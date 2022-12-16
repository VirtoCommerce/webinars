using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtoCommerce.ExperienceApiModule.Core.Infrastructure;
using VirtoCommerce.MyLoyalty.ExperienceApi.Aggregates;

namespace VirtoCommerce.MyLoyalty.ExperienceApi.Commands
{
    public class GrantCreditCommand: ICommand<BalanceAggregate>
    {
        public string? StoreId { get; set; }
        public string? UserId { get; set; }

        public int Amount { get; set; }
    }
}
