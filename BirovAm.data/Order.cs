namespace BirovAm.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderID { get; set; }

        public int CustomerID { get; set; }

        public DateTime OrderDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmountPaid { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalQuantity { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
