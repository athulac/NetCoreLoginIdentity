using PracticalTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractialTest.Repository.Repositories.Interfaces
{
    public interface ITeacherSubjectRepository : IGenericRepository<TeacherSubject>
    {
        Task<IQueryable<TeacherSubject>> GetTachersBySubject(int subject);
        Task<IQueryable<TeacherSubject>> GetTachersBySubject(int subjectId, int teacherId);
    }
}
