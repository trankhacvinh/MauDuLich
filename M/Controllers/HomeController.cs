using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using M.Models;

namespace M.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("/sanpham/chitiet")]
        public IActionResult ChiTiet(){
            return View();
        }

        [Route("/faqs")]
        public IActionResult Faqsdfdsf(){
            return View("faqs");
        }
        [Route("/danhsachtour")]
        public IActionResult Danhsachtours(){
            return View("danhsachtour");
        }
        [Route("/tour/chitiettour")]
        public IActionResult Chitiettour(){
            return View("chitiettour");
        }

        [Route("/listnews")]
        public IActionResult Listnews(){
            return View("listnews");
        }
        [Route("/news/newsdetail")]
        public IActionResult Newsdetail(){
            return View("newsdetail");
        }
        [Route("/thuvienhinh")]
        public IActionResult Thuvienhinh(){
            return View("thuvienhinh");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
