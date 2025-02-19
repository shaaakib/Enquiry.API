using Enquiry.API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Enquiry.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowCors")]
    public class EnquiryMasterController : ControllerBase
    {
        private readonly EnquiryDbContext _db;
        public EnquiryMasterController(EnquiryDbContext db)
        {
            _db = db;
        }

        [HttpGet("GetAllStatus")]
        public List<EnquiryStatus> GetEnquiryStatus()
        {
            var list = _db.EnquiryStatus.ToList();
            return list;
        }

        [HttpGet("GetAllTypes")]
        public List<EnquiryType> GetEnquiryType()
        {
            var list = _db.EnquiryType.ToList();
            return list;
        }

        [HttpGet("GetAllEnquiry")]
        public List<EnquiryModel> GetEnquiryModel()
        {
            var list = _db.EnquiryModels.ToList();
            return list;
        }

        [HttpPost("CreateNewEnquiry")]
        public EnquiryModel CreateNewEnquiry([FromBody] EnquiryModel obj)
        {
            obj.createdDate = DateTime.Now;
            _db.EnquiryModels.Add(obj);
            _db.SaveChanges();

            return obj;
        }

        [HttpPost("UpdateEnquiry")]
        public EnquiryModel UpdateEnquiry([FromBody] EnquiryModel obj)
        {
            var record = _db.EnquiryModels.SingleOrDefault(m => m.enquiryId == obj.enquiryId);
            if(record != null)
            {
                record.resolution = obj.resolution;
                record.enquiryStatusId = obj.enquiryStatusId;
                _db.SaveChanges();

            }

            return obj;
        }

        [HttpDelete("DeleteEnquiryById")]
        public bool DeleteEnquiryById(int id)
        {
            var record = _db.EnquiryModels.SingleOrDefault(m => m.enquiryId == id);
            if (record != null)
            {
                _db.EnquiryModels.Remove(record);
                _db.SaveChanges();
                return true;

            }
            else { 
                return false;
            }

            
        }
    }
}
