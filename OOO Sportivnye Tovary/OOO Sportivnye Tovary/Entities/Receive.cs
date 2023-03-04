namespace OOO_Sportivnye_Tovary.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Receive")]
    public partial class Receive
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceiveID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string ReceiveArticle { get; set; }

        public int ReceiveCount { get; set; }

        public virtual Order Order { get; set; }
    }
}
