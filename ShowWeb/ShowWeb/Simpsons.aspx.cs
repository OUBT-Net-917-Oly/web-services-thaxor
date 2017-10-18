using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SimpsonsWeb.SimpsonServiceReference;

namespace SimpsonsWeb
{
    public partial class Simpsons : System.Web.UI.Page
    {
        private SimpsonsServiceSoapClient _service;

        public Simpsons()
        {
            _service = new SimpsonsServiceSoapClient();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var message = _service.Hello();
                lblMessage.Text = message;
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Sorry the Simpsons service is currently unavailable.";
                btnGetAll.Enabled = false;
                btnFindByLast.Enabled = false;
                //throw;
            }
        }

        protected void btnGetAll_Click(object sender, EventArgs e)
        {
            List<Character> characters = _service.GetAllCharacters().ToList();

            string names = "";

            foreach (var character in characters)
            {
                names = names + $"{character.FirstName} {character.LastName} <br>";
            }

            lblCharacters.Text = names;
        }

        protected void btnFindByLast_Click(object sender, EventArgs e)
        {
            List<Character> characters = _service.SearchByLastName(txtLastName.Text).ToList();

            string names = "";

            foreach (var character in characters)
            {
                names = names + $"{character.FirstName} {character.LastName} <br>";
            }

            lblLastMatch.Text = names;
        }

        protected void btnFindByFirst_Click(object sender, EventArgs e)
        {
            List<Character> characters = _service.SearchByFirstName(txtFirstName.Text).ToList();

            string names = "";

            foreach (var character in characters)
            {
                names = names + $"{character.FirstName} {character.LastName} <br>";
            }

            lblFirstMatch.Text = names;
        }

        protected void btnCountCharacters_Click(object sender, EventArgs e)
        {
            lblCharacterCount.Text = _service.CountNumberOfCharacters().ToString();
        }
    }
}