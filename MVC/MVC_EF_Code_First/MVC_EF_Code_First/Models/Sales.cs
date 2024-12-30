using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_EF_Code_First.Models
{
    public class Sales
    {
        [Key]
        public int SaleID { get; set; }
        public DateTime DtofSale { get; set; }
        public int QtySold { get; set; }
        public double TotAmount { get; set; }
        public ICollection<Products>Product { get; set; }
    }
}