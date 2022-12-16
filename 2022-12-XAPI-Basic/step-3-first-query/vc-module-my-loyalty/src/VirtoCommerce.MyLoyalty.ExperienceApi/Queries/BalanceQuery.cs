using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using VirtoCommerce.ExperienceApiModule.Core.BaseQueries;
using VirtoCommerce.MyLoyalty.ExperienceApi.Aggregates;

namespace VirtoCommerce.MyLoyalty.ExperienceApi.Queries
{
    public class BalanceQuery: Query<BalanceAggregate>
    {
        public string? StoreId { get; set; }
        public string? UserId { get; set; }

        public override IEnumerable<QueryArgument> GetArguments()
        {
            yield return Argument<StringGraphType>(nameof(StoreId));
            yield return Argument<StringGraphType>(nameof(UserId));
        }

        public override void Map(IResolveFieldContext context)
        {
            StoreId = context.GetArgument<string>(nameof(StoreId));
            UserId = context.GetArgument<string>(nameof(UserId));
        }
    }
}
