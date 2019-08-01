
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Parking.Models.ViewModels
{
    public class VehicleFormViewModel
    {
        public Vehicle Vehicle { get; set; }
        public double TotalTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double TotalPrice { get; set; }
        public DateTime Now { get; set; }
    }
}
