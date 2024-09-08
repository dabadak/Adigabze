using Adigabze.DAL.Entities;
using Adigabze.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adigabze.Data.Concrete.EFCore
{
    public class EFSozcukEkRepository :EFGenericRepository<SozcukEk>, ISozcukEkRepository
    {
        public EFSozcukEkRepository(AdigabzeContext context) : base(context)
        {

        }

        public AdigabzeContext AdigabzeContext
        {
            get { return _ctx as AdigabzeContext; }
        }
    }
}
