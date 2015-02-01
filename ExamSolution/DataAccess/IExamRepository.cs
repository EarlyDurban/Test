using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEntities.Entities;

namespace DataAccess
{
    public interface IExamRepository
    {
        IQueryable<Exam> GetAllExams();
    }
}
