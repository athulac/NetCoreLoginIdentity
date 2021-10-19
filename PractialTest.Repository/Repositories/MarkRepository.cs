using PractialTest.Repository.Repositories.Interfaces;
using PracticalTest.Domain;
using PracticalTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractialTest.Repository.Repositories
{
    public class MarkRepository : GenericRepository<Mark>, IMarkRepository
    {
        public MarkRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<IQueryable<Mark>> GetAll()
        {
            var res = GetAllAsync(
                x => x.TeacherSubject.Teacher, 
                x => x.TeacherSubject.Subject,
                x => x.Student.School,
                x => x.Student.Grade);            
            return res.OrderByDescending(x => x.Id).AsQueryable();
        }

        public async Task<int> Create(Mark mark)
        {
            var res = await AddAsync(mark);
            return res;
        }
    }
}
