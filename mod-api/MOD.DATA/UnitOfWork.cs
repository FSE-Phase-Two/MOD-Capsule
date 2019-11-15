using MOD.DATA.Repository.Interface;
using MOD.DATA.Repository.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOD.DATA
{
    public class UnitOfWork : IUnitOfWork
    {
        bool _Flag = true;
        private readonly MODContext _Context;
        //private Lazy<IStudentRepository> _Student;

        private Lazy<ITrainingRepository> _Training;

        public UnitOfWork(MODContext Context)
        {
            _Context = Context;
            _Training = new Lazy<ITrainingRepository>(() =>
            {
                return new TrainingRepository(_Context);
            });

        }
        public bool Flag
        {
            get
            {
                return _Flag;
            }
            set
            {
                _Flag = value;
            }
        }

        public int Complete()
        {
            return _Context.SaveChanges();

        }

        public void Dispose()
        {
            if (_Flag)
            {
                _Context.Dispose();
            }
        }

        public ITrainingRepository Training
        {
            get
            {
                return _Training.Value;
            }
        }

    }
}
