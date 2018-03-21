namespace invFM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Purchase_Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Purchase_Order()
        {
            PurchaseOrder_Item = new HashSet<PurchaseOrder_Item>();
            Quotation = new HashSet<Quotation>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PorderID { get; set; }

        public int AdminID { get; set; }

        public int CEOID { get; set; }

        public int SupplierID { get; set; }

        public DateTime? DateReviewed { get; set; }

        public int? RequestStaues { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [StringLength(100)]
        public string CEOComment { get; set; }

        public virtual Admin Admin { get; set; }

        public virtual CEO CEO { get; set; }

        public virtual Supplier Supplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrder_Item> PurchaseOrder_Item { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Quotation> Quotation { get; set; }
    }
}
