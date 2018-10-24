using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpTraining.PageObjects
{
    public class ContactUsPage
    {
        public ContactUsPage()
        {

        }

        public ContactUsPage fillFormWithData()
        {
            return new ContactUsPage();
        }

        public ContactResultPage submitForm()
        {
            return new ContactResultPage();
        }
    }
}
