using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PSGC.Api.Entities;
using PSGC.Api.Repository;

namespace PSGC.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeoLocationController(IRepository repo) : ControllerBase
    {
        [HttpGet("regions")]
        public async Task<ActionResult<IEnumerable<GeoData>>> GetRegions()
        {
            var data = await repo.GetRegions();
            return Ok(data);
        }

        [HttpGet("provinces/{regionCode}")]
        public async Task<ActionResult<IEnumerable<GeoData>>> GetProvinces(string regionCode)
        {
            var data = await repo.GetProvinces(regionCode);
            return Ok(data);
        }

        [HttpGet("cities-municipalities/{regionCode}/{provinceCode}")]
        public async Task<ActionResult<IEnumerable<GeoData>>> GetCitiesMunicipalities(string regionCode, string provinceCode)
        {
            var data = await repo.GetCitiesMunicipalities(regionCode, provinceCode);
            return Ok(data);
        }

        [HttpGet("barangays/{regionCode}/{provinceCode}/{municipalCode}")]
        public async Task<ActionResult<IEnumerable<GeoData>>> GetBarangays(string regionCode, string provinceCode, string municipalCode)
        {
            var data = await repo.GetBarangays(regionCode, provinceCode, municipalCode);
            return Ok(data);
        }
    }
}
