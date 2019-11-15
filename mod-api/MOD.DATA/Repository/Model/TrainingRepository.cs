using MOD.DATA.Model;
using MOD.DATA.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOD.DATA.Repository.Model
{
    public class TrainingRepository : Repository<Training>, ITrainingRepository
    {
        public TrainingRepository(MODContext Context)
            : base(Context)
        {
        }

        public IEnumerable<Training> GetAllTraining()
        {
            return GetAll();
        }

        public void CreateTraining(Training training)
        {
            Add(training);
        }
    }
}
