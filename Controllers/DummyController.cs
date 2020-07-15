using Cityinfo.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfocityControllers
{
    public class DummyControllers : Controller
    {
        private CityInfoContext _ctx;
        public DummyControllers(CityInfoContext ctx)
        {
            _ctx = ctx;
        }
        [HttpGet]
        [Route("api/testdatabase")]
        public IActionResult TestDatabase()
        {
            return Ok();
        }
    }
}
