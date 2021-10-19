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
    public class TeacherSubjectRepository : GenericRepository<TeacherSubject>, ITeacherSubjectRepository
    {
        public TeacherSubjectRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<IQueryable<TeacherSubject>> GetTachersBySubject(int subjectId)
        {
            var res = Find(x => x.SubjectId == subjectId, x => x.Teacher);
            return res.AsQueryable();
        }

        public async Task<IQueryable<TeacherSubject>> GetTachersBySubject(int subjectId, int teacherId)
        {
            var res = Find(x => x.SubjectId == subjectId && x.TeacherId == teacherId, x => x.Teacher);
            return res.AsQueryable();
        }
    }
}
