using Adigabze.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adigabze.Data.Abstract
{
    public interface IBoyRepository
    {
        Boy GetById(int boyId);
        IQueryable<Boy> GetAll();
        void AddBoy(Boy entity);
        void UpdateBoy(Boy entity);
        void DeleteBoy(int boyId);
    }
}
