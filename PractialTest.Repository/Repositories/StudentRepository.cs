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
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<IQueryable<Student>> GetByGrade(Grade grade)
        {
            var res = Find(x => x.Grade.Id == grade.Id);
            return res.AsQueryable();
        }
    }
}
