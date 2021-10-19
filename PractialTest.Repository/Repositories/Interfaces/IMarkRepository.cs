using PracticalTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractialTest.Repository.Repositories.Interfaces
{
    public interface IMarkRepository : IGenericRepository<Mark>
    {
        Task<IQueryable<Mark>> GetAll();
        Task<int> Create(Mark mark);
    }
}
