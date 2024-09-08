using Adigabze.DAL.Entities;
using Adigabze.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adigabze.Data.Concrete.EFCore
{
    public class EFKonuRepository : EFGenericRepository<Konu>, IKonuRepository
    {
        public EFKonuRepository(AdigabzeContext context) : base(context)
        { 

        }

        public AdigabzeContext context
        {
            get { return _ctx as AdigabzeContext; }
        }
    }
}
