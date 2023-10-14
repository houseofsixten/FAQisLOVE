using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class CharactersController : Controller
    {
        private readonly string[] characters = { "Miko", "Sora", "Suisei", "Haato", "Pekora", "Amelia" };

        public IActionResult Miko()
        {
            ViewBag.Characters = characters;
            ViewBag.CharName = "Miko";
            return View();
        }

        public IActionResult Sora()
        {
            ViewBag.Characters = characters;
            ViewBag.CharName = "Sora";
            ViewBag.ModelImages = new string[] { "sora_model_01.png", "sora_model_02.png", "sora_model_03.png" };
            return View();
        }

        public IActionResult Suisei()
        {
            ViewBag.Characters = characters;
            ViewBag.CharName = "Suisei";
            return View();
        }

        public IActionResult Haato()
        {
            ViewBag.Characters = characters;
            ViewBag.CharName = "Haato";
            return View();
        }

        public IActionResult Pekora()
        {
            ViewBag.Characters = characters;
            ViewBag.CharName = "Pekora";
            return View();
        }

        public IActionResult Amelia()
        {
            ViewBag.Characters = characters;
            ViewBag.CharName = "Amelia";
            return View();
        }
    }
}
