namespace invFM.Models
{ 
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PurchaseOrder_Item
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PorderID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string ItemID { get; set; }

        public int? QuantityOrder { get; set; }

        public decimal? POItemUnitPrice { get; set; }

        public virtual Item Item { get; set; }

        public virtual Purchase_Order Purchase_Order { get; set; }
    }
}
