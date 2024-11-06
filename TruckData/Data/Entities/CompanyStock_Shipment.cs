using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckData.Data.Entities
{
    internal class CompanyStock_Shipment
    {
        [ForeignKey("CompanyStock")]
        public int CompanyStock_Id { get; set; }
        public CompanyStock? CompanyStok { get; set; }
        [ForeignKey("Shipment")]
        public int Shipment_Id { get; set; }
        public Shipment? Shipment { get; set; }
    }
}
