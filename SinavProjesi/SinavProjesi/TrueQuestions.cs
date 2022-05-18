using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavProjesi
{
    internal class TrueQuestions : IQuestion
    {
        public int QuestionId { get; set; }
        public int LessonId { get; set; }
        public int UnitId { get; set; }
        public DateTime LastAnswer { get; set; }
    }
}
