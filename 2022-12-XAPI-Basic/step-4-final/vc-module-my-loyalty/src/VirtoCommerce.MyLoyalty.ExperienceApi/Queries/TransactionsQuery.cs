using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Types;
using GraphQL;
using VirtoCommerce.ExperienceApiModule.Core.BaseQueries;
using VirtoCommerce.MyLoyalty.ExperienceApi.Aggregates;
using VirtoCommerce.MyLoyalty.Core;
using VirtoCommerce.MyLoyalty.Core.Models;

namespace VirtoCommerce.MyLoyalty.ExperienceApi.Queries
{
    public class TransactionsQuery : SearchQuery<TransactionSearchResult>
    {
        public string? StoreId { get; set; }
        public string? UserId { get; set; }


        public override IEnumerable<QueryArgument> GetArguments()
        {
            foreach (var argument in base.GetArguments())
            {
                yield return argument;
            }

            yield return Argument<StringGraphType>(nameof(StoreId));
            yield return Argument<StringGraphType>(nameof(UserId));
        }

        public override void Map(IResolveFieldContext context)
        {
            base.Map(context);

            StoreId = context.GetArgument<string>(nameof(StoreId));
            UserId = context.GetArgument<string>(nameof(UserId));
        }
    }
}
