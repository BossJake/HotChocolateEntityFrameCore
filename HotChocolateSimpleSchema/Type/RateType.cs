using HotChocolate.Types;
using HotChocolateSimpleSchema.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotChocolateSimpleSchema.Type
{
    public class RateEntityType : ObjectType<Rate>
    {
        protected override void Configure(IObjectTypeDescriptor<Rate> descriptor)
        {
            descriptor.Field(t => t.DateToExpire).Type<DateTimeType>();
        }
    }
}
