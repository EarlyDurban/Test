using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ExamContext: DbContext
    {
        public ExamContext(string connectionString)
            : base(connectionString)
        {

        }
    }
}
