namespace invFM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CEO")]
    public partial class CEO: ApplicationUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CEO()
        {
            Purchase_Order = new HashSet<Purchase_Order>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        //public int CEOID { get; set; }

        [Required]
        [StringLength(40)]
        public string CEOName { get; set; }

        //[StringLength(15)]
       // public string Phone { get; set; }

        //[StringLength(50)]
        //public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase_Order> Purchase_Order { get; set; }
    }
}
