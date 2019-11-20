using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.DATA;
using MOD.DATA.Model;
using MOD.LOG;

namespace MOD.TRAINING.BC
{
    public class TrainingBC : ITrainingBC
    {

        IUnitOfWork UnitOfWork;
        ILog logger;
        public TrainingBC(IUnitOfWork _UnitOfWork, ILog _logger)
        {
            UnitOfWork = _UnitOfWork;
            logger = _logger;
        }
        public void CreateTraining(Training training)
        {
            logger.Information("Execute create training BC....");
            UnitOfWork.Training.CreateTraining(training);
            UnitOfWork.Complete();
            UnitOfWork.Dispose();
        }

        public IEnumerable<Training> GetAllTraining()
        {
            logger.Information("training BC....");
            IEnumerable<Training> trainings = UnitOfWork.Training.GetAllTraining();
            UnitOfWork.Dispose();
            return trainings;
        }
    }
}
