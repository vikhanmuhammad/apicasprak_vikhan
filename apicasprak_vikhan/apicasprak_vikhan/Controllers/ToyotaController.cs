using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace apicasprak_vikhan.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class ToyotaController : Controller
    {
        private static List<Toyota> dataToyota = new List<Toyota>
        {
            new Toyota("Yaris", "Rp200.000.000"),
            new Toyota("Fortuner", "Rp700.000.000"),
            new Toyota("GR Yaris", "Rp1.000.000.000"),
            new Toyota("Agya", "Rp100.000.000"),
            new Toyota("Calya", "Rp150.000.000")
        };

        [HttpGet]
        public IEnumerable<Toyota> Get()
        {
            return dataToyota;
        }

        [HttpGet("{id}")]
        public Toyota Get(int id)
        {
            return dataToyota[id];
        }

        [HttpPost]
        public void Post([FromBody]Toyota value)
        {
            dataToyota.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Toyota value) 
        {
            dataToyota[id] = value;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataToyota.RemoveAt(id);
        }
    }
}
