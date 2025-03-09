using System.Collections.Generic;
using System.Web.Mvc;

namespace S1L03.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People

        public ActionResult ListPeople()
        {
            List<Models.PersonModel> people = new List<Models.PersonModel>();

            people.Add(new Models.PersonModel { studentNumber = "u24622436", FirstName = "Kezia", LastName = "Segurado", email = "kezia.segurado@tuks.co.za", myLink = "~/HTML/Kezia.html"});
            people.Add(new Models.PersonModel { studentNumber = "u12345678", FirstName = "John", LastName = "Doe", email = "john.doe@tuks.co.za " , myLink = "~/HTML/John.html" });
            people.Add(new Models.PersonModel { studentNumber = "u24697531", FirstName = "Sara", LastName = "Smith", email = "sara.smith.@tuks.co.za", myLink = "~/HTML/Sara.html" });
            people.Add(new Models.PersonModel { studentNumber = "u45976213", FirstName = "Bianca", LastName = "Du Tiot", email = "bianca.dutoit@tuks.co.za", myLink = "~/HTML/Bianca.html" });
            people.Add(new Models.PersonModel { studentNumber = "u79435884", FirstName = "Rachel", LastName = "Van Der Merve", email = "rachel.vandermerve@tuks.co.za", myLink = "~/HTML/Rachel.html" });

            return View(people);

        }
 
    }
}