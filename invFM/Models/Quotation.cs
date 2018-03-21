namespace invFM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Quotation")]
    public partial class Quotation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuotationID { get; set; }

        public int PorderID { get; set; }

        public int AdminID { get; set; }

        public int SupplierID { get; set; }

        public decimal? TotalPrice { get; set; }

        public decimal? TaxCost { get; set; }

        public virtual Admin Admin { get; set; }

        public virtual Purchase_Order Purchase_Order { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
