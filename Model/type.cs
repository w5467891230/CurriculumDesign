namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("type")]
    public partial class Type
    {
        [Key]
        public string TID { get; set; }

        [Column("type")]
        [StringLength(50)]
        public string Type1 { get; set; }

        [StringLength(50)]
        public string TRemark { get; set; }

        
    }
}
