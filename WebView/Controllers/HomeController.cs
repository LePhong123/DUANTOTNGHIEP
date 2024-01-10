using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http;
using WebView.Models;

namespace WebView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult HomePageAdmin()
        {
            return View();
        }
        public IActionResult LoginAdminAndNhanVien()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Login(string login, string password)
        //{
        //    //https://localhost:7095/api/QuanLyNguoiDung/DangNhap?email=tam%40gmail.com&password=chungtam200396
        //    if (login.Contains('@'))
        //    {
        //        login = login.Replace("@", "%40");
        //    }
        //    HttpResponseMessage response = _httpClient.GetAsync(_httpClient.BaseAddress + $"QuanLyNguoiDung/DangNhap?lg={login}&password={password}").Result;
        //    if (response.IsSuccessStatusCode)
        //    {
        //        HttpContext.Session.SetString("LoginInfor", response.Content.ReadAsStringAsync().Result);
        //        return RedirectToAction("Index");
        //    }
        //    else return BadRequest();
        //}
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        //public IActionResult Register(KhachHangViewModel khachHang)
        //{
        //    khachHang.Id = Guid.NewGuid();
        //    HttpResponseMessage response = _httpClient.PostAsJsonAsync(_httpClient.BaseAddress + "KhachHang", khachHang).Result;
        //    if (response.IsSuccessStatusCode) return RedirectToAction("Login");
        //    return BadRequest();
        //}
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}