using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace L4again
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public double FtoC(double F)
        {
            return (F - 32) * 5 / 9.00;
        }
        [WebMethod]
        public double CtoF(double C)
        {
            return (C * 9) / 5.00 + 32 ;
        }
        [WebMethod]
        public string Data()
        {
            return DateTime.Now.ToString();
        }
        [WebMethod]
        public string[] Afis()
        {
            string[] nume = new string[5];
            nume[0] = "Capra";
            nume[1] = "Varza";
            nume[2] = "Lup";
            nume[3] = "Vanator";
            nume[4] = "Scufita Rosie";
            return nume;
        }
        [WebMethod]
        public double ConvertMoney(double tr)
        {
            return tr * 33.01;
        }
    }
}
