using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDesignPattern.UI.DAL.Entity
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int KDV { get; set; }
        public string Category { get; set; }
        public string Barcode { get; set; }
        public string code { get; set; }
        public int Stock { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public string SizeType { get; set; }
        public string SizeAmount { get; set; }
        public string Storage { get; set; }
        public bool Status { get; set; }
    }
}
