using System.Collections.Generic;
using System.Web.Mvc;

namespace S1L03.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        private static List<Models.PersonModel> people = new List<Models.PersonModel>();
        public ActionResult ListPeople()
        {

            if (people.Count == 0) // only add if list is empty
            {
                people.Add(new Models.PersonModel { studentNumber = "u24622436", FirstName = "Kezia", LastName = "Segurado", email = "kezia.segurado@tuks.co.za" });
                people.Add(new Models.PersonModel { studentNumber = "u12345678", FirstName = "John", LastName = "Doe", email = "john.doe@tuks.co.za " });
                people.Add(new Models.PersonModel { studentNumber = "u24697531", FirstName = "Sara", LastName = "Smith", email = "sara.smith.@tuks.co.za" });
                people.Add(new Models.PersonModel { studentNumber = "u45976213", FirstName = "Bianca", LastName = "Du Tiot", email = "bianca.dutoit@tuks.co.za" });
                people.Add(new Models.PersonModel { studentNumber = "u79435884", FirstName = "Rachel", LastName = "Van Der Merve", email = "rachel.vandermerve@tuks.co.za" });
            }
                return View(people);
            
        }


        [HttpGet]
        public ActionResult PeopleList()
        {
            return View("PeopleList");
        }


        public ActionResult PeopleList(Models.PersonModel pm)
        {
            people.Add(new Models.PersonModel { studentNumber = pm.studentNumber, FirstName = pm.FirstName, LastName = pm.LastName, email = pm.email});

            return RedirectToAction("ListPeople");
        }
    }
}