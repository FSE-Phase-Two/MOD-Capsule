using MOD.DATA.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOD.DATA.Repository.Model
{
    public class TechnologyRepository : Repository<TechnologyRepository>, ITechnologyRepository
    {
        public TechnologyRepository(MODContext Context)
            : base(Context)
        {
        }

    }
}
