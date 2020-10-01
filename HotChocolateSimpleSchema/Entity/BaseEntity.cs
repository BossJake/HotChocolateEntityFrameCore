using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotChocolateSimpleSchema.Entity
{
    public abstract class BaseEntity<TKey> : IBase<TKey>
    {
        [Key]
        public virtual TKey ID { get; set; }
        public virtual DateTime? CreatedOn { get; set; }
        public virtual int? CreatedByID { get; set; }
        public virtual DateTime? ModifiedOn { get; set; }
        public virtual int? ModifiedByID { get; set; }
    }
}
