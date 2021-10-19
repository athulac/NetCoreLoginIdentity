using PracticalTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractialTest.Repository.Repositories.Interfaces
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        Task<IQueryable<Student>> GetByGrade(Grade grade);
    }
}
