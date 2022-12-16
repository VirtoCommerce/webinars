using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using VirtoCommerce.MyLoyalty.ExperienceApi.Aggregates;

namespace VirtoCommerce.MyLoyalty.ExperienceApi.Commands
{
    public class GrantCreditCommandHandler : IRequestHandler<GrantCreditCommand, BalanceAggregate>
    {
        public Task<BalanceAggregate> Handle(GrantCreditCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new BalanceAggregate { Balance = request.Amount });
        }
    }
}
