using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars.DomainClasses;

namespace Cars3
{
    public class CarOperations
    {

        public static void InsertCar(string prod, string mod, int hspeed, string btype, Engine eng)
        {
            var car = new Car
            {
                Producer = prod,
                Model = mod,
                HighSpeed = hspeed,
                BodyType = btype,
                Engine = eng
            };
            Manager.Insert<Car>(car);
        }
        public static void InsertCar(List<Car> lst)
        {
            Manager.Insert<Car>(lst);
        }


        public static void InsertEngine(int cyl, int pow, float lit)
        {
            var engine = new Engine
            {
                Cylinders = cyl,
                Power = pow,
                Liters = lit
            };
            Manager.Insert<Engine>(engine);
        }

        public static void InsertEngine(List<Engine> lst)
        {
            Manager.Insert<Engine>(lst);
        }

        public static void UpdateCar(int Id, string prod, string mod, int hspeed, string btype, int eng)
        {
            Cars.DomainClasses.Car car = new Cars.DomainClasses.Car();
            car.CarId = Id;
            car.Producer = prod;
            car.Model = mod;
            car.HighSpeed = hspeed;
            car.BodyType = btype;
            
            car.Engine = Cars3.Manager.Find<Engine>(eng);

            Cars3.Manager.Update<Car>(car); 
        }

        

    }
}
