namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("person")]
    public partial class person
    {
        [Key]
        [StringLength(50)]
        public string PID { get; set; }

        [StringLength(50)]
        public string PName { get; set; }

        [StringLength(50)]
        public string PSex { get; set; }

        [StringLength(50)]
        public string PPhone { get; set; }

        [StringLength(50)]
        public string PN { get; set; }

        [StringLength(50)]
        public string PCode { get; set; }

        public string PMoney { get; set; }

        [StringLength(50)]
        public string identityname { get; set; }

        [StringLength(50)]
        public string PRemark { get; set; }

        public bool sys { get; set; }

        public int PsRow { get; set; }
        public object PsData { get; set; }
        public object PsCurrent { get; set; }
        public string PsXx { get; set; }
        public int count { get; set; }
        public int s { get; set; }
    }
}
