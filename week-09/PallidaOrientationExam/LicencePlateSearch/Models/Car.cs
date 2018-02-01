using Newtonsoft.Json;
using System;

namespace PallidaExam.Models
{
    public class Car
    {
        [JsonIgnore]
        public long Id { get; set; }
        public string LicencePlate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }
    }
}
