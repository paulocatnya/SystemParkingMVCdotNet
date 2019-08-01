using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parking.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Plate { get; set; }
        public DateTime Input { get; set; }
        public DateTime Output { get; set; }

        public Vehicle(int id, string model, string plate, DateTime input, DateTime output)
        {
            Id = id;
            Model = model;
            Plate = plate;
            Input = input;
            Output = output;
        }
        public Vehicle(int id, string model, string plate, DateTime input)
        {
            Id = id;
            Model = model;
            Plate = plate;
            Input = input;
        }
        public Vehicle()
        {
        }

        public double TotalValue(double tax, DateTime input, DateTime output)
        {
            TimeSpan time = output - input;
            var total = tax * time.TotalMinutes;
            return total;

        }
    }
}
