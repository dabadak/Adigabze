using Adigabze.DAL.Entities;
using Adigabze.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adigabze.Data.Concrete.EFCore
{
    public class EFKazanimRepository : EFGenericRepository<Kazanim>, IKazanimRepository
    {
        public EFKazanimRepository(AdigabzeContext context):base(context)
        {

        }

        public AdigabzeContext context
        {
            get { return _ctx as AdigabzeContext; }
        }
    }
}
