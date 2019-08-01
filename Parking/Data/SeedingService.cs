using Parking.Models;
using System;
using System.Linq;


namespace Parking.Data
{
    public class SeedingService
    {
        private ParkingContext _context;

        public SeedingService(ParkingContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Vehicle.Any())
            {
                return;
            }

            Vehicle v = new Vehicle(1, "GOL", "HJA8745", new DateTime(2019, 07, 31, 10, 45, 00));
            Vehicle v1 = new Vehicle(2, "ASTRA", "FKA8745", new DateTime(2019, 07, 31, 10, 45, 00));
            Vehicle v2 = new Vehicle(3, "VECTRA", "BFA8745", new DateTime(2019, 07, 31, 10, 45, 00));
            Vehicle v3 = new Vehicle(4, "XRE", "PRA8745", new DateTime(2019, 07, 31, 10, 45, 00));
            Vehicle v4 = new Vehicle(5, "CB300", "BRA8745", new DateTime(2019, 07, 30, 10, 45, 00));
            Vehicle v5 = new Vehicle(6, "HORNET", "HFA8745", new DateTime(2019, 07, 31, 08, 45, 00));
            Vehicle v6 = new Vehicle(7, "GOL", "HJA8745", new DateTime(2019, 07, 31, 10, 45, 00));
            Vehicle v7 = new Vehicle(8, "ASTRA", "FKA8745", new DateTime(2019, 07, 31, 10, 45, 00));
            Vehicle v8 = new Vehicle(9, "VECTRA", "BFA8745", new DateTime(2019, 07, 31, 10, 45, 00));
            Vehicle v9 = new Vehicle(10, "XRE", "PRA8745", new DateTime(2019, 07, 31, 10, 45, 00));
            Vehicle v10 = new Vehicle(11, "CB300", "BRA8745", new DateTime(2019, 07, 30, 10, 45, 00));
            Vehicle v11 = new Vehicle(12, "HORNET", "HFA8745", new DateTime(2019, 07, 31, 08, 45, 00));
            Vehicle v12 = new Vehicle(13, "GOL", "HJA8745", new DateTime(2019, 07, 31, 10, 45, 00));
            Vehicle v13 = new Vehicle(14, "ASTRA", "FKA8745", new DateTime(2019, 07, 31, 10, 45, 00));
            Vehicle v14 = new Vehicle(15, "VECTRA", "BFA8745", new DateTime(2019, 07, 31, 10, 45, 00));
            Vehicle v15 = new Vehicle(16, "XRE", "PRA8745", new DateTime(2019, 07, 31, 10, 45, 00));
            Vehicle v16 = new Vehicle(17, "CB300", "BRA8745", new DateTime(2019, 07, 30, 10, 45, 00));
            Vehicle v17 = new Vehicle(18, "HORNET", "HFA8745", new DateTime(2019, 07, 31, 08, 45, 00));
            Vehicle v18 = new Vehicle(19, "GOL", "HJA8745", new DateTime(2019, 07, 31, 10, 45, 00));
            Vehicle v19 = new Vehicle(20, "ASTRA", "FKA8745", new DateTime(2019, 07, 31, 10, 45, 00));
            Vehicle v20 = new Vehicle(21, "VECTRA", "BFA8745", new DateTime(2019, 07, 31, 10, 45, 00));
            Vehicle v21 = new Vehicle(22, "XRE", "PRA8745", new DateTime(2019, 07, 31, 10, 45, 00));
            Vehicle v22 = new Vehicle(23, "CB300", "BRA8745", new DateTime(2019, 07, 30, 10, 45, 00));
            Vehicle v23 = new Vehicle(24, "HORNET", "HFA8745", new DateTime(2019, 07, 31, 08, 45, 00));


            _context.Vehicle.AddRange(v, v1, v2, v3, v4, v5, v7, v8, v9, v10, v11, v12, v13,v14,v15,v16,v17,v17,v18,v19,v20,v21,v22,v23);
            _context.SaveChanges();


        }
    }
}
