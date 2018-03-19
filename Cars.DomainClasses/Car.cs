using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.DomainClasses
{
    public class Car
    {
        public int CarId { get; set; }
        public string Producer { get; set; }
        public string Model { get; set; }
        public int HighSpeed { get; set; }
        public string BodyType { get; set; }
        
        public Engine Engine { get; set; }

    }
}
