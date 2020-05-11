using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfpaTinderCoreMvc
{
    public class DataPersonne
    {
        private readonly ApplicationDbContext applicationDbContext;

        public DataPersonne(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
    }
}
