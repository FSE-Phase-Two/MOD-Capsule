using MOD.DATA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TRAINING.BC
{
    public interface ITrainingBC
    {
        IEnumerable<Training> GetAllTraining();
        void CreateTraining(Training training);
    }
}
