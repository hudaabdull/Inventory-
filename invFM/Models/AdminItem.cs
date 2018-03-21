namespace invFM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdminItem")]
    public partial class AdminItem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdminID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string ItemID { get; set; }

        public DateTime? OrderDate { get; set; }

        public int? Quantity { get; set; }

        public virtual Admin Admin { get; set; }

        public virtual Item Item { get; set; }
    }
}
