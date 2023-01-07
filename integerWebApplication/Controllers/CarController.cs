using integerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace integerWebApplication.Controllers
{
    public class CarController : Controller
    {
        //cara 1
        List<Models.Car> cars = new List<Models.Car>();

        //cara 2
        IEnumerable<Models.Car> cars2 = new List<Models.Car>();

        public IActionResult Index()
        {
            cars.Add(new Models.Car()
            {
                IdRegistration = 1,Type = "Sedan",Brand = "Toyota",Variant = "Black"
            });

            cars.Add(new Models.Car()
            {
                IdRegistration = 2,Type = "SUV",Brand = "Toyota",Variant = "RAV4"
            });

            cars.Add(new Models.Car()
            {
                IdRegistration = 3,Type = "Sedan",Brand = "Honda",Variant = "Accord"
            });

            cars.Add(new Models.Car()
            {
                IdRegistration = 4,Type = "SUV",Brand = "Honda",Variant = "CRV"
            });

            cars.Add(new Models.Car()
            {
                IdRegistration = 5,Type = "Sedan",Brand = "Honda",Variant = "City"
            });

            /*var carsArray = new Car[]
            {
                new Car{IdRegistration = 1, Type="Sedan1", Brand="Toyota", Variant="FT86"},
                new Car{IdRegistration = 2, Type="Sedan2", Brand="Toyota", Variant="FT86"},
                new Car{IdRegistration = 3, Type="Sedan3", Brand="Toyota", Variant="FT86"},
                new Car{IdRegistration = 4, Type="Sedan4", Brand="Toyota", Variant="FT86"},
            };*/

            /*ViewBag.Cars = carsArray;*/
            //ViewBag.Cars = cars3;

            /*var cari = cars.Single(x => x.IdRegistration == 1);
            cars.Remove(cari);*/

            /*          var select = cars.Where(x => x.Type == "Sedan");
                        ViewBag.Cars = select;*/

            //SOAL 1
            /*var soal1 = cars.Where(x => x.Brand == "Honda").FirstOrDefault();
            ViewBag.Cars = new List<Models.Car>() { soal1 };*/

            //SOAL 2
            /*var soal2 = cars.Where(x => (x.Brand == "Honda" && x.Type == "Sedan"));
            ViewBag.Cars = soal2;*/

            //SOAL 3
            /*var soal3 = cars.Where(x => (x.Brand == "Honda" && x.Variant == "City")).FirstOrDefault();
            ViewBag.Cars = new List<Models.Car>() {soal3};*/

            //SOAL 4
            /*var soal4 = cars.Where(x => x.Brand == "Toyota");
            ViewBag.Cars = soal4;*/

            //SOAL 5
            /*var soal5 = cars.Where(x => x.Variant == "City");
            ViewBag.Cars = soal5;*/

            //SOAL 6
            /*var soal6 = cars.Where(x => x.Type == "Sedan");
            ViewBag.Cars = soal6;*/

            return View(cars);
        }
    }
}