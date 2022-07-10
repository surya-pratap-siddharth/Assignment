using gitApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace gitApp.Controllers
{
    public class EmpDbContextcs : Controller
    {
        public IActionResult Index()
        {
            List<Emp> l = new List<Emp>
            {
                new Emp{EId=1,EName="Rahul",EDesign="Manager",DoJ=Convert.ToDateTime(01/06/2022)},
                new Emp{EId=1,EName="Raghav",EDesign="Assistant Manager",DoJ=Convert.ToDateTime(06/07/2022)},
                new Emp{EId=1,EName="Ravindra",EDesign="Programmer",DoJ=Convert.ToDateTime(11/08/2022)},
                new Emp{EId=1,EName="Ramesh",EDesign="CEO",DoJ=Convert.ToDateTime(12/06/2022)},
            }; 
            return View(l);
        }
    }
}
