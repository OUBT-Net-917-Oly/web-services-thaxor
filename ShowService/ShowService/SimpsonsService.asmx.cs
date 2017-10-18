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
        public List<Character> SearchByFirstName(string firstName)
        {
            List<Character> matches;
            matches = new List<Character>();

            foreach (var person in People)
            {
                if (person.FirstName.ToLower().StartsWith(firstName.ToLower()))
                {
                    matches.Add(person);
                }
            }

            return matches;
        }

        [WebMethod]
        public List<Character> SearchByJob(string job)
        {
            List<Character> matches;
            matches = new List<Character>();

            foreach (var person in People)
            {
                if (person.Job.ToLower().StartsWith(job.ToLower()))
                {
                    matches.Add(person);
                }
            }

            return matches;
        }

        [WebMethod]
        public int CountNumberOfCharacters()
        {
            if (People == null)
            {
                return 0;
            }
            return People.Count();
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

            var bart = new Character
            {
                FirstName = "Bart",
                LastName = "Simpson",
                Job = "Student"
            };

            var lisa = new Character
            {
                FirstName = "Lisa",
                LastName = "Simpson",
                Job = "Student"
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

            var nelson = new Character
            {
                FirstName = "Nelson",
                LastName = "Muntz",
                Job = "Bully"
            };

            var ralph = new Character
            {
                FirstName = "Ralph",
                LastName = "Wiggum",
                Job = "Student"
            };

            People.Add(homer);
            People.Add(marge);
            People.Add(bart);
            People.Add(lisa);
            People.Add(mo);
            People.Add(barney);
            People.Add(nelson);
        }

    }
}
