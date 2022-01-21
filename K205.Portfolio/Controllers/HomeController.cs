using K205.Portfolio.Models;
using Microsoft.AspNetCore.Mvc;

namespace K205.Portfolio.Controllers
{
    public class HomeController : Controller
    {


        List<Product> products = new()
        {
            new Product
            {
                Id = 1,
                Price = 13000M,
                Name = "Hyundai Accent",
                Year = 2008,
                Description = "Masin tam IDEAL vezyetdedir.Xerc teleb etmir Alici harda isdese yoxlada biler Mator karobka peredok qranatlar eladir.",
                PhotoURL = "https://turbo.azstatic.com/uploads/f460x343/2022%2F01%2F08%2F22%2F44%2F48%2Fb229be25-cc4a-4a02-9b8d-ecabbc220675%2F20605_YBzkiI6CiTrrBJfVp2YCyg.jpg"

            },

            new Product
            {
                Id = 2,
                Price = 9600M,
                Name = "LADA (VAZ) 2107",
                Year = 2011,
                Description = "Masinda zerre qeder cepe yoxdur masin cox ideal vezyetdedir.istediyiniz yerde yoxlada bilersiniz. ",
                PhotoURL = "https://turbo.azstatic.com/uploads/f460x343/2021%2F12%2F18%2F23%2F58%2F25%2F69fd26f1-2bdc-44ea-9422-78136f52e66f%2F70633_VrG0WOo7e1Siv_q3G5sI0Q.jpg"
            },

            new Product
            {
                Id = 3,
                Price = 12000M,
                Name = "LADA (VAZ) Niva",
                Year = 2013,
                Description = "Masin tam IDEAL vezyetdedir.Xerc teleb etmir Alici harda isdese yoxlada biler Mator karobka peredok qranatlar eladir.",
                PhotoURL = "https://turbo.azstatic.com/uploads/f330x248/2022%2F01%2F06%2F15%2F06%2F17%2Fc1b479dc-895b-42ee-82f7-d57592190553%2F49106_4M3NvfOc3YlBIUzN0qJQMw.jpg"
            },

            new Product
            {
                Id = 4,
                Price = 26800M,
                Name = "Baic Senova D50",
                Year = 2020,
                Description = "5 il və ya 120 000 km zəmanət! Kuzovun növü : Sedan",
                PhotoURL = "https://turbo.azstatic.com/uploads/f460x343/2021%2F12%2F08%2F11%2F42%2F58%2F3251ed16-dccd-40ec-931f-b58acda1d59a%2F34263_GPfKwAHgUatbPVQLrKtscA.jpg"
            },

            new Product
            {
                Id = 5,
                Price = 116000M,
                Name = "BMW X5",
                Year = 2020,
                Description = "M Paket, maksimal komplektasiya , improtexda 116,000 usd qiymeti var ve en azi 6-7 ay qozlemelisiz !!!",
                PhotoURL = "https://turbo.azstatic.com/uploads/f330x248/2022%2F01%2F15%2F06%2F41%2F33%2F0e8e2bdd-1f5e-43dd-b8d0-d3542fba4410%2F77978_OpRZKnNUO-wQpjM6aBazPA.jpg"
            },

            new Product
            {
                Id = 6,
                Price = 70000M,
                Name = "Jeep Wrangler",
                Year = 2018,
                Description = "Jeep......Wrangler...... Unlimited......Sahara Avtomobil çox idial vəziyətdədir heç bir xərc tələb etmir.",
                PhotoURL = "https://turbo.azstatic.com/uploads/f460x343/2021%2F12%2F22%2F21%2F44%2F11%2F2e6a88e8-44fd-4aed-897d-d51d0b10cf3c%2F15869_lLMQvCjMl5AQ7TlRSPS3zQ.jpg"
            },

            new Product
            {
                Id = 7,
                Price = 23800M,
                Name = "Chevrolet Malibu",
                Year = 2016,
                Description = "Sürüş rejimlərinin tənzimlənməsi, seçilməsi və uyğunlaşması (Drive mode settings)",
                PhotoURL = "https://turbo.azstatic.com/uploads/f330x248/2021%2F12%2F18%2F23%2F58%2F37%2F34cbbe27-336d-4f76-a4e2-d0d091b40be3%2F32918_AEeFWoypypwZWREtaCn8ng.jpg"
            },

            new Product
            {
                Id = 8,
                Price = 63000M,
                Name = "Mercedes E 220",
                Year = 2017,
                Description = "Mercedes E 220 ~ 2018 model,motor 2.0 Ən maksimal komplektasiyadir.Avtomobilin 3 açarı var.",
                PhotoURL = "https://turbo.azstatic.com/uploads/f330x248/2021%2F11%2F22%2F22%2F48%2F06%2F3ccd8cd4-eeb1-4725-a70f-51d14e3101aa%2F57483_-YVv2Z7sNmLqCNspjmZV9Q.jpg"
            }
        };
    

        public IActionResult Index()
        {


            ViewData["products"] = products;

            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
