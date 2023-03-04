namespace OOO_Sportivnye_Tovary.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            Receive = new HashSet<Receive>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDateStart { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDateEnd { get; set; }

        public int OrderPointOfDelivery { get; set; }

        public int? OrderUser { get; set; }

        public int OrderCode { get; set; }

        public int OrderStatus { get; set; }

        public int OrderReceive { get; set; }

        public virtual PointOfDelivery PointOfDelivery { get; set; }

        public virtual Status Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receive> Receive { get; set; }
    }
}
