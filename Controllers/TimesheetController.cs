using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TimesheetService.Database;
using TimesheetService.Database.Entities;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TimesheetService.Controllers
{
   

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TimesheetController : ControllerBase
    {
        DatabaseContext db;

        // GET: api/<UserController>


        public TimesheetController()
        {
            db = new DatabaseContext();

        }
        // GET: api/<TimesheetController>

        [ActionName("getTimesheetMaster")]
        [HttpGet("{UserID}")]
        public IEnumerable<TimesheetMaster> GetTimesheetMaster(int UserID)
        {
            return db.timesheetMaster.FromSql("SELECT * FROM timesheetdb.timesheetmaster where userID={0}",UserID);
        }

        [ActionName("getTimesheetDetails")]
        [HttpGet("{TimesheetID}")]
        public IEnumerable<TimesheetDetails> GetTimesheetDetails(int TimesheetID)
        {
            return db.timesheetDetails.FromSql("SELECT * FROM timesheetdb.timesheetdetails where TimesheetID={0}", TimesheetID);
        }

        // GET api/<TimesheetController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        [ActionName("insertTimesheetMaster")]
        // POST api/<TimesheetController>
        [HttpPost]
        public IActionResult Post([FromBody] TimesheetMaster m1)
        {
            db.timesheetMaster.Add(m1);
            
            db.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        [ActionName("insertTimesheetDetail")]
        [HttpPost]
        public IActionResult Post([FromBody] TimesheetDetails m2)
        {
            db.timesheetDetails.Add(m2);

            db.SaveChanges();

            return StatusCode(StatusCodes.Status201Created);
        }

        

        [ActionName("deleteTimesheetMaster")]
        // DELETE api/<TimesheetController>/5
        [HttpDelete("{TimesheetMasterID}")]
        public IActionResult Delete(int TimesheetMasterID)
        {
            var recordToDelete = db.timesheetMaster.SingleOrDefault(x => x.TimesheetMasterId == TimesheetMasterID);

            if (recordToDelete == null)
            {
                return NotFound("No record found");
            }

            db.timesheetMaster.Remove(recordToDelete);
            db.SaveChanges();

            return Ok();
        }
    }
}
