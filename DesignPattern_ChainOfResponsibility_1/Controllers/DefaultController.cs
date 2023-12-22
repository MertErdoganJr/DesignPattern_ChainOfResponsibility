using DesignPattern_ChainOfResponsibility_1.ChainOfResponsibility;
using DesignPattern_ChainOfResponsibility_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern_ChainOfResponsibility_1.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerPorccessViewModel model)
        {
            Employee treasurer = new Treasurer();
            Employee managerAsistant = new ManagerAsistant();
            Employee manager = new Manager();
            Employee areaDirector = new AreaDirector();

            treasurer.SetNextApprover(managerAsistant);
            managerAsistant.SetNextApprover(manager);
            manager.SetNextApprover(areaDirector);

            treasurer.ProcessRequest(model);
            return View();
        }
    }
}
