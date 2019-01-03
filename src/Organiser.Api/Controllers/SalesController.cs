using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Organiser.Accounting.Crunch;
using Organiser.Accounting.Crunch.Model.SalesInvoices;

namespace Organiser.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly CrunchApiClient _crunchApiClient;

        public SalesController(CrunchApiClient crunchApiClient)
        {
            _crunchApiClient = crunchApiClient;
        }

        // GET api/values
        [HttpGet]
        public async Task<SalesCollection> Get()
        {
            return await _crunchApiClient.Get<SalesCollection>("sales_invoices");
        }
    }
}
