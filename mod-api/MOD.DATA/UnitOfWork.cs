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

        private Lazy<IUserRepository> _User;
        private Lazy<IMentorRepository> _Mentor;
        private Lazy<ITechnologyRepository> _Technology;
        private Lazy<IPaymentRepository> _Payment;

        public UnitOfWork(MODContext Context)
        {
            _Context = Context;
            _Training = new Lazy<ITrainingRepository>(() =>
            {
                return new TrainingRepository(_Context);
            });

            _User = new Lazy<IUserRepository>(() =>
            {
                return new UserRepository(_Context);
            });

            _Mentor = new Lazy<IMentorRepository>(() =>
            {
                return new MentorRepository(_Context);
            });

            _Technology = new Lazy<ITechnologyRepository>(() =>
            {
                return new TechnologyRepository(_Context);
            });

            _Payment = new Lazy<IPaymentRepository>(() =>
            {
                return new PaymentRepository(_Context);
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

        public IUserRepository User
        {
            get
            {
                return _User.Value;
            }
        }

        public IMentorRepository Mentor
        {
            get
            {
                return _Mentor.Value;
            }
        }

        public ITechnologyRepository Technology
        {
            get
            {
                return _Technology.Value;
            }
        }

        public IPaymentRepository Payment
        {
            get
            {
                return _Payment.Value;
            }
        }

    }
}
