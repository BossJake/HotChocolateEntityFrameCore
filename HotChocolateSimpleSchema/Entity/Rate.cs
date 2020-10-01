using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotChocolateSimpleSchema.Entity
{
    public class Rate : BaseEntity<int>
    {
        public DateTime DateToExpire { get; set; }
    }
}
