using MOD.DATA.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOD.DATA.Repository.Interface
{
    public interface ITrainingRepository
    {
        IEnumerable<Training> GetAllTraining();
        void CreateTraining(Training training);
    }
}
