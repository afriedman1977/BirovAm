using BirovAm.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirovAm.Models
{
    public class EnterSizesViewModel
    {
        public Product Product { get; set; }
        public List<Size> Sizes { get; set; }
    }
}