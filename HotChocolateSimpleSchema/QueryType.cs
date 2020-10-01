using GreenDonut;
using HotChocolate.Resolvers;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using HotChocolateSimpleSchema.Entity;
using HotChocolateSimpleSchema.Repository;
using HotChocolateSimpleSchema.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HotChocolateSimpleSchema
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Field(t => t.GetRates()).Type<RateEntityType>()
             .UsePaging<RateEntityType>()
             .UseFiltering()
             .UseSorting()
             .UseSelection();
        }
    }
}
