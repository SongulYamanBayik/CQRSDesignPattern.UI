using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDesignPattern.UI.CQRS.Results
{
    public class GetProductProducerQueryResult
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Storage { get; set; }
        public bool Status { get; set; }
    }
}
