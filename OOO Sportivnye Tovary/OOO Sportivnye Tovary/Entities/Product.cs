namespace OOO_Sportivnye_Tovary.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [StringLength(10)]
        public string ProductArticle { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        public int ProductMeasurement { get; set; }

        public int ProductCost { get; set; }

        public int ProductMaxDiscount { get; set; }

        public int ProductManufacturer { get; set; }

        public int ProductProvider { get; set; }

        public int ProductCategory { get; set; }

        public int ProductDiscount { get; set; }

        public int ProductCountInStock { get; set; }

        [Required]
        [StringLength(500)]
        public string ProductDescription { get; set; }

        [Column(TypeName = "image")]
        public byte[] ProductImage { get; set; }

        public virtual Category Category { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public virtual Measurement Measurement { get; set; }

        public virtual Provider Provider { get; set; }
    }
}
