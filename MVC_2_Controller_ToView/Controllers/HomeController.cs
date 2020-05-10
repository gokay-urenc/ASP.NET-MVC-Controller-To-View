using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_2_Controller_ToView.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult MyMethod()
        {
            return View("Sayfa");
        }
    }
}
// Kullanıcı HomeController'a istek yaptığında MyMethod çalışsın ve kullanıcıya bir sayfa gösterilsin.
// ViewResult: Kullanıcıya view göstermek için kullanılan bir Result(sonuç) türüdür.
// View methodu parametre olarak gönderilen sayfayı render eder ve kullanıcıya sunar.