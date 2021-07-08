using System;

namespace EShop.Model
{
    public abstract class Audit
    {
        public string CreatedBy { get; set; }
        public Nullable<DateTimeOffset> CreatedTime { get; set; }
        public string ModifyBy { get; set; }
        public Nullable<DateTimeOffset> ModifyTime { get; set; }
    }
}
