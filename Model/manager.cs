namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("manager")]
    public partial class manager
    {
        

        [Key]
        [StringLength(50)]
        public string MName { get; set; }

        [StringLength(50)]
        public string MCode { get; set; }

        public string MCodeRe { get; set; }

        public bool manage { get; set; }

        public bool work { get; set; }

        public bool query { get; set; }

        public bool RadioManage { get; set; }

        public bool RadioWork { get; set; }
        public object cc { get; set; }
        public int count { get; set; }
    }
}
