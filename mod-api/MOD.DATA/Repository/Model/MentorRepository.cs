using MOD.DATA.Model;
using MOD.DATA.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOD.DATA.Repository.Model
{
    public class MentorRepository : Repository<Mentor>, IMentorRepository
    {
        public MentorRepository(MODContext Context)
            : base(Context)
        {
        }
    }
}
