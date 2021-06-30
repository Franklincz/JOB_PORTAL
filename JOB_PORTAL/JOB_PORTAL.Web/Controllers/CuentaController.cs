using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JOB_PORTAL.Web.Models
{
    public class CuentaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoginCandidato()
        {

            return View();

        }
        public IActionResult LoginAdEmpresa()
        {



            return View();
        }


    }
}
