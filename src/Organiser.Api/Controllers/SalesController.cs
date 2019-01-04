using Microsoft.AspNetCore.Mvc;
using Organiser.Accounting.Crunch.ApiClient;
using Organiser.Accounting.Crunch.Model.SalesInvoices;
using System.Threading.Tasks;

namespace Organiser.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly OAuth1ApiClient _crunchApiClient;

        public SalesController(OAuth1ApiClient crunchApiClient)
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
