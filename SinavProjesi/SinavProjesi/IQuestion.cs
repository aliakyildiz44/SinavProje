using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavProjesi
{
    internal interface IQuestion
    {
         int QuestionId { get; set; }
         int LessonId { get; set; }
         int UnitId { get; set; }
    }
}
