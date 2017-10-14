using ShowService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ShowService
{
    /// <summary>
    /// Summary description for SimpsonsService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SimpsonsService : System.Web.Services.WebService
    {
        public List<Character> People { get; set; }

        public SimpsonsService()
        {
            People = new List<Character>();
            GetCharacters();
        }

        [WebMethod]
        public string Hello()
        {
            return "Hello Springfield";
        }

        [WebMethod]
        public List<Character> GetAllCharacters()
        {
            return People;
        }

        [WebMethod]
        public List<Character> SearchByLastName(string lastName)
        {
            List<Character> matches;
            matches = new List<Character>();

            foreach (var person in People)
            {
                if (person.LastName.ToLower().StartsWith(lastName.ToLower()))
                {
                    matches.Add(person);
                }
            }

            return matches;
        }

        [WebMethod]
        public List<Character> SearchByFirstName(string lastName)
        {
            //implement this
            //case insensitive
            throw new NotImplementedException();
        }

        [WebMethod]
        public List<Character> SearchByJob(string lastName)
        {
            //implement this
            //case insensitive
            throw new NotImplementedException();
        }

        [WebMethod]
        public int CountNumberOfCharacters()
        {
            //implement this
            throw new NotImplementedException();
        }

        private void GetCharacters()
        {
            //add more characters
            var homer = new Character
            {
                FirstName = "Homer",
                LastName = "Simpson",
                Job = "Nuclear safety inspector"
            };

            var marge = new Character
            {
                FirstName = "Marge",
                LastName = "Simpson",
                Job = "Mom"
            };

            var mo = new Character
            {
                FirstName = "Moe",
                LastName = "Szyslak",
                Job = "Bartender"
            };

            var barney = new Character
            {
                FirstName = "Barney",
                LastName = "Gumble",
                Job = "Belcher"
            };

            People.Add(homer);
            People.Add(marge);
            People.Add(mo);
            People.Add(barney);
        }

    }
}
