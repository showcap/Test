using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestAPI.Models;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
namespace TestAPI.Controllers
{
    public class CitysController : ApiController
    {
        List<Models.City> citylist = new List<Models.City>() { 
            new City{CityID=1, CityName="北京"},
            new City{CityID=2, CityName="上海"},
            new City{CityID=3, CityName="广州"}
        };
        [HttpGet]
        public List<City> AllList()
        {
            return citylist;
        }
        [HttpGet]
        public City GetCity(int id)
        {
            return citylist.Where(p => p.CityID == id).FirstOrDefault();
        }
        [HttpGet]
        public City GetCityN(string name)
        {

            return citylist.Where(p => p.CityID == 2).FirstOrDefault();
        }
        [HttpGet]
        public City GetCityNs(string name)
        {

            return citylist.Where(p => p.CityID == 1).FirstOrDefault();
        }


        //[HttpGet]
        //public string getone()
        //{
        //    string result = "";
        //    var js = new System.Web.Script.Serialization.JavaScriptSerializer();
        //    result = String.Format("jq1133({0})",  js.Serialize(citylist));

        //    return result;
        //}
        //public IHttpActionResult GetAllContacts()
        //{

        //    return Json<IEnumerable<City>>(citylist);
        //}
    }
    

}
