namespace BirovAm.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Size
    {
        public Size()
        {
            OrderDetails = new HashSet<OrderDetail>();
            ProductsSizes = new HashSet<ProductsSize>();
            Categories = new HashSet<Category>();
        }

        public int SizeID { get; set; }

        [Required]
        [StringLength(50)]
        public string SizeCode { get; set; }

        [Column("Size")]
        [Required]
        [StringLength(50)]
        public string Size1 { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual ICollection<ProductsSize> ProductsSizes { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
