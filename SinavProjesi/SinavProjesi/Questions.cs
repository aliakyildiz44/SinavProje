using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SinavProjesi
{
    public class Questions :IQuestion
    {
        public int QuestionId { get; set; }
        public int LessonId { get; set; }
        public int UnitId { get; set; }
        public string QuestionText { get; set; }
        public string OptA { get; set; }
        public string OptB { get; set; }

        public string OptC { get; set; }
        public string OptD { get; set; }
        public int TrueOpt { get; set; }
        public DateTime AddedTime { get; set; }
        public DateTime AnsweredTime { get; set; }
        public Image Picture { get; set; }
        public Questions(int QuestionId, int LessonId, int UnitId, string QuestionText, string OptA, string OptB, string OptC, string OptD, int TrueOpt)
        {
            this.QuestionId = QuestionId;
            this.LessonId = LessonId;
            this.UnitId = UnitId;
            this.QuestionText = QuestionText;
            this.OptA = OptA;
            this.OptB = OptB;
            this.OptC = OptC;
            this.OptD = OptD;
            this.TrueOpt = TrueOpt;

        }
    }
}
