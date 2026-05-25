using Adigabze.DAL.Entities;
using Adigabze.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adigabze.Data.Concrete.EFCore
{
    public class EFParentRepository : EFGenericRepository<Parent>, IParentRepository
    {
        public EFParentRepository(AdigabzeContext context) : base(context)
        {
        }

        public AdigabzeContext AdigabzeContext 
        {
            get { return _ctx as AdigabzeContext; }
        }
    }
}
