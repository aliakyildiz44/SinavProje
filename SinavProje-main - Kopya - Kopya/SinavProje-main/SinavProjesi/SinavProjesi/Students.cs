using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavProjesi
{
   public  class Students
    {
        public int StudentId { get; set; }
        public bool Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Province { get; set; }
        public string  District { get; set; }
        public int Grade { get; set; }
        public int SchoolNumber { get; set; }
        public Students(bool Gender,DateTime Birthday,string Province,string District,int Grade,int SchoolNumber)
        {
            this.Gender = Gender;
            this.Birthday = Birthday;
            this.Province = Province;
            this.District = District;
            this.Grade = Grade;
            this.SchoolNumber = SchoolNumber;
        }
    }
}
