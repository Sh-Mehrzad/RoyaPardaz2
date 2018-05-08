using System;
using System.ComponentModel.DataAnnotations;

namespace RoyaPardaz.Data
{
    public abstract class BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
