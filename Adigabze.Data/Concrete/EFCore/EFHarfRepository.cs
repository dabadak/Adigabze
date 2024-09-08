using Adigabze.DAL.Entities;
using Adigabze.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Adigabze.Data.Concrete.EFCore
{
    public class EFHarfRepository : EFGenericRepository<Harf>, IHarfRepository
    {
        public EFHarfRepository(AdigabzeContext context):base(context)
        {

        }

        public AdigabzeContext AdigabzeContext
        {
            get { return _ctx as AdigabzeContext; }
        }
    }
}
