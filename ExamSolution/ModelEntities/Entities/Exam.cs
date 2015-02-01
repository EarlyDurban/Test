using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEntities.Entities
{
    public class Exam
    {
        [Key]
        public int ExamID { get; set; }

        [MaxLength(250)]
        public string Name { get; set; }
    }
}
