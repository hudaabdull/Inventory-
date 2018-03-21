namespace invFM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            AdminItem = new HashSet<AdminItem>();
            CustomerItem = new HashSet<CustomerItem>();
            PurchaseOrder_Item = new HashSet<PurchaseOrder_Item>();
            ShipmentDetails = new HashSet<ShipmentDetails>();
        }

        [StringLength(20)]
        public string ItemID { get; set; }

        public int DesignerID { get; set; }

        [StringLength(40)]
        public string ItemName { get; set; }

        public int? ItemLocation { get; set; }

        [StringLength(2)]
        public string CabinetNumber { get; set; }

        public int? ShelveNumber { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public int? QuantityAvailable { get; set; }

        public decimal? UnitPrice { get; set; }

        public DateTime? checkDate { get; set; }

        public int? Status { get; set; }

        [StringLength(100)]
        public string DesignerComment { get; set; }

        public virtual Designer Designer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdminItem> AdminItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerItem> CustomerItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrder_Item> PurchaseOrder_Item { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipmentDetails> ShipmentDetails { get; set; }
    }
}
