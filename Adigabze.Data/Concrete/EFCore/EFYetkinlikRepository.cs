using Adigabze.DAL.Entities;
using Adigabze.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adigabze.Data.Concrete.EFCore
{
    public class EFYetkinlikRepository : EFGenericRepository<Yetkinlik>, IYetkinlikRepository
    {
        public EFYetkinlikRepository(AdigabzeContext context):base(context)
        {

        }

        public AdigabzeContext context
        {
            get { return _ctx as AdigabzeContext; }
        }
    }
}
