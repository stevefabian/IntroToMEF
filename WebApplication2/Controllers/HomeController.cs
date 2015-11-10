using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;
using System.Web.Mvc;
using WebApplication1.Contracts;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private Person person { get; set; }

        [ImportMany(typeof(IPersonActivity))]
        private List<IPersonActivity> Plugins { get; set; } 

        public HomeController()
        {
            var catalog = new DirectoryCatalog(@"Plugins");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }

        public ActionResult Index()
        {
            person = new Person();
            person.Name = "Steve";
            person.Email = "sfabian@gooddogs.com";

            foreach (var plugin in Plugins)
            {
                person.Activities.Add(plugin);
            }

            return View(person);
        }
    }

}