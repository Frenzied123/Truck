using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckData.Data.Entities
{
    internal class Shipment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TypeOfStock { get; set; }
        [Required]
        public string Stock { get; set; }
        [Required]
        public double Weight { get; set; }
        [Required]
        public string FromAdress { get; set; }
        [Required]
        public string ToAdress { get; set; }
        [Required]
        public string PickupDate { get; set; }
        [Required]
        public string DeliveryDate { get; set; }

    }
}
