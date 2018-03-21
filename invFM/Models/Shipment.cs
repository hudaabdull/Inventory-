namespace invFM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipment")]
    public partial class Shipment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shipment()
        {
            ShipmentDetails = new HashSet<ShipmentDetails>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShipmentID { get; set; }

        public int SupplierID { get; set; }

        public int CustomerID { get; set; }

        public DateTime? ShippingDate { get; set; }

        public DateTime? ExpectedArrivalDateDate { get; set; }

        [StringLength(40)]
        public string DriverName { get; set; }

        [StringLength(15)]
        public string DriverContact { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Supplier Supplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipmentDetails> ShipmentDetails { get; set; }
    }
}
