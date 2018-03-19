using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Cars3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter engine:\nCylinders: ");
            //int cyl = int.Parse(Console.ReadLine());
            //Console.WriteLine("Power: ");
            //int pow = int.Parse(Console.ReadLine());
            //Console.WriteLine("Liters: ");
            //float lit = float.Parse(Console.ReadLine());

            //CarOperations.InsertEngine(cyl, pow, lit);

            //var example = MakeList();
            //Cars3.CarOperations.InsertCar(example);

            int Id = 1;
            string prod = "BMW       ";
            string mod = "X5              ";
            int hspeed = 250;
            string btype = "SUV  ";
            int eng = 9;
            Cars3.CarOperations.UpdateCar(Id, prod, mod, hspeed, btype, eng);

        }
        
        public static List<Cars.DomainClasses.Car> MakeList()
        {
            List<Cars.DomainClasses.Car> cars = new List<Cars.DomainClasses.Car>();
            Cars.DomainClasses.Car[] cartmp = new Cars.DomainClasses.Car[6] { new Cars.DomainClasses.Car { Producer = "BMW       ", Model = "X6              ", HighSpeed = 280, BodyType = "SUV  ", Engine = new Cars.DomainClasses.Engine { Cylinders = 8, Power = 547, Liters = 4.4f } },
                                                                              new Cars.DomainClasses.Car { Producer = "Porsche   ", Model = "Macan           ", HighSpeed = 254, BodyType = "SUV  ", Engine = new Cars.DomainClasses.Engine { Cylinders = 6, Power = 340, Liters = 3.0f } },
                                                                              new Cars.DomainClasses.Car { Producer = "Ferrary   ", Model = "458 Italia      ", HighSpeed = 325, BodyType = "Coupe", Engine = new Cars.DomainClasses.Engine { Cylinders = 8, Power = 570, Liters = 4.8f } },
                                                                              new Cars.DomainClasses.Car { Producer = "Nissan    ", Model = "370Z            ", HighSpeed = 300, BodyType = "Coupe", Engine = new Cars.DomainClasses.Engine { Cylinders = 6, Power = 336, Liters = 3.6f } },
                                                                              new Cars.DomainClasses.Car { Producer = "Mitsubishi", Model = "Lancer Evolution", HighSpeed = 240, BodyType = "Sedan", Engine = new Cars.DomainClasses.Engine { Cylinders = 4, Power = 276, Liters = 2.0f } },
                                                                              new Cars.DomainClasses.Car { Producer = "Subaru    ", Model = "WRX STI         ", HighSpeed = 250, BodyType = "Sedan", Engine = new Cars.DomainClasses.Engine { Cylinders = 4, Power = 268, Liters = 2.0f } }};
            cars.AddRange(cartmp);
            return cars;
        }
            
        
    }
}
