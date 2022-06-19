using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class ArvatoController : Controller
    {
        public IActionResult Index()
        {
            //Viewag ve ViewData aynı controller içerisindee veri taşıyor

            ViewBag.kisi = new { isim = "serkan", soyisim = "ince" };
            ViewData["Kullanici"] = new User() { Age = 1, Name = "ss" };

            //Tempdata farklı controller arası veri taşıyabiliyor
            //Tempdata'ya direkt obje basamadığımız için önce json'a serialize ediyoruz
            TempData.Add("isim", JsonSerializer.Serialize<User>(new User() { Age = 1, Name = "ss" }));
            return RedirectToAction("Index", "Home");

            //return View();
        }
    }
}
