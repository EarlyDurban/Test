using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ExamRepository: IExamRepository
    {
        public IQueryable<ModelEntities.Entities.Exam> GetAllExams()
        {
            throw new NotImplementedException();
        }
    }
}
