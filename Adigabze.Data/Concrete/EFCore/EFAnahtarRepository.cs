using Adigabze.DAL.Entities;
using Adigabze.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adigabze.Data.Concrete.EFCore
{
    public class EFAnahtarRepository : EFGenericRepository<Anahtar>, IAnahtarRepository
    {
        public EFAnahtarRepository(AdigabzeContext context) : base(context)
        {

        }

        public AdigabzeContext AdigabzeContext
        {
            get { return _ctx as AdigabzeContext; }
        }
    }
}
