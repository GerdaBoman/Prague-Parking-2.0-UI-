using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ParkingLot
    {
        public int ParkingSpot { get; set; }
        public string VechileType { get; set; } = null!;
        public string RegistrationPlate { get; set; } = null!;
    }
}
