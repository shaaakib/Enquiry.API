using Enquiry.API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Enquiry.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowCors")]
    public class MasterController : ControllerBase
    {
        private readonly UserDbContext _db;
        public MasterController(UserDbContext db)
        {
            _db = db;
        }

        [HttpGet("GetAllState")]
        public IActionResult GetAllState()
        {
            var list = _db.State.ToList();
            return Ok(list);
        }

        [HttpGet("GetDistrictByStateId")]
        public IActionResult GetAllDistrict(int stateId)
        {
            var list = _db.District.Where(m => m.stateId == stateId).ToList();
            return Ok(list);
        }


        [HttpGet("GetCityByDistrictId")]
        public IActionResult GetCityByDistrictId(int districtId)
        {
            var list = _db.City.Where(m => m.districtId == districtId).ToList();
            return Ok(list);
        }
    }
}
