using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.DATA;
using MOD.DATA.Model;

namespace MOD.TRAINING.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingsController : ControllerBase
    {
        IUnitOfWork UnitOfWork;
        public TrainingsController(IUnitOfWork _UnitOfWork)
        {
            UnitOfWork = _UnitOfWork;
        }

        // GET: api/Trainings
        [HttpGet]
        public IEnumerable<string> Get()
        {
            IEnumerable<Training> trainings = UnitOfWork.Training.GetAllTraining();
            Training newTraing = new Training
            {
                Rating = 9,
                AmountReceived = 1200,
                Progress = 25,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                MentorId = 1,
                TechnologyId = 1,
                UserId = 1,
                StartTime = DateTime.Now.TimeOfDay,
                EndTime = DateTime.Now.TimeOfDay,
                Status="Complete"
            };


            UnitOfWork.Training.CreateTraining(newTraing);
            UnitOfWork.Complete();
            UnitOfWork.Dispose();
            return new string[] { "Training1", "Training2" };
        }

        // GET: api/Trainings/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Trainings
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Trainings/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
