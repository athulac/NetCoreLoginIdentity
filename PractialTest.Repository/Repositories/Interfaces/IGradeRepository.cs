using PracticalTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractialTest.Repository.Repositories.Interfaces
{
    public interface IGradeRepository : IGenericRepository<Grade>
    {
        Task<IQueryable<Grade>> GetAll();
    }
}
