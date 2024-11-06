using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckData.Data.Entities
{
    internal class TruckCompany_Vehicle
    {
        [ForeignKey("TruckCompany")]
        public int TruckCompany_Id { get; set; }
        public TruckCompany? TruckCompany { get; set; }
        [ForeignKey("Vehicle")]
        public int Vehicle_Id { get; set; }
        public Vehicle? Vehicle { get; set; }
    }
}
