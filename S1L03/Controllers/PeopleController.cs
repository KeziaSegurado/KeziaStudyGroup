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

            people.Add(new Models.PersonModel { studentNumber = "u01234567", FirstName = "Jane", LastName = "Doe", email = "jane.doe@tuks.co.za" });
            people.Add(new Models.PersonModel { studentNumber = "u12345678", FirstName = "John", LastName = "Doe", email = "john.doe@tuks.co.za " });
            people.Add(new Models.PersonModel { studentNumber = "u24697531", FirstName = "Sara", LastName = "Smith", email = "Sara.Smith.@tuks.co.za" });
            people.Add(new Models.PersonModel { studentNumber = "u45976213", FirstName = "Bianca", LastName = "Du Tiot", email = "Bianca.Dutoit@tuks.co.za" });
            people.Add(new Models.PersonModel { studentNumber = "u79435884", FirstName = "Rachel", LastName = "Van Der Merve", email = "Rachel.Vandermerve@tuks.co.za" });

            return View(people);

        }
 
    }
}