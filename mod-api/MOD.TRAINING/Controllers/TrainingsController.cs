using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.DATA;
using MOD.DATA.Model;
using MOD.LOG;
using MOD.TRAINING.BC;

namespace MOD.TRAINING.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingsController : ControllerBase
    {
        ITrainingBC TrainingBc;
        ILog logger;
        public TrainingsController(ITrainingBC _TrainingBc, ILog _logger)
        {
            TrainingBc = _TrainingBc;
            logger = _logger;
        }

        // GET: api/Trainings
        [HttpGet]
        public IEnumerable<string> Get()
        {
            logger.Information("call all training..");
            IEnumerable<Training> trainings = TrainingBc.GetAllTraining();
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
        public void Post([FromBody] Training training)
        {
            TrainingBc.CreateTraining(training);
        }

        // PUT: api/Trainings/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Training training)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
