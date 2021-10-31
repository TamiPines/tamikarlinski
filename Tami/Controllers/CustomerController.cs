using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tami.Models;

namespace Tami.Controllers
{
    [RoutePrefix("api/customer")]
    public class CustomerController : ApiController
    {
        [Route("getByStatus/{status}")]
        [HttpGet]
        public List<DAL.Customer> Get(int status)
        {
            return BL.CustomerBL.GetByStatus(status);
        }

        [Route("add")]
        [HttpPost]

        public bool Add(CustomerName name)
        {
            return BL.CustomerBL.Add(name.Name);
        }


        [Route("update/{id}")]
        [HttpGet]

        public bool Update(int id)
        {
            return BL.CustomerBL.Update(id);
        }
    }
}
