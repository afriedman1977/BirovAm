namespace BirovAm.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
            Sizes = new HashSet<Size>();
        }

        public int CategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }

        [Required]
        [StringLength(250)]
        public string CategoryDescription { get; set; }

        [NotMapped]
        public bool Included { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<Size> Sizes { get; set; }
    }
}
