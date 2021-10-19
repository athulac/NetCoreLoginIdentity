using PractialTest.Repository.Repositories.Interfaces;
using PracticalTest.Domain;
using PracticalTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractialTest.Repository.Repositories
{
    public class GradeRepository : GenericRepository<Grade>, IGradeRepository
    {
        public GradeRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<IQueryable<Grade>> GetAll()
        {
            var res = GetAllAsync();
            return res.AsQueryable();
        }
    }
}
