using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotChocolateSimpleSchema.Entity
{
    public interface IBase<TKey>
    {
        public TKey ID { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedByID { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedByID { get; set; }
    }
}
