using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

using Microsoft.AspNetCore.Cors;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyCorsImplementationPolicy")]
    public class Cu : ControllerBase
    {
        EmployeeContext e1 = new EmployeeContext();
        [HttpGet]
        public ActionResult action()
        {
            List<Customer> obj = e1.Customer.ToList();
            return Ok(obj);

        }
    }
}
