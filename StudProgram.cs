using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat__Windows_Forms_App_
{
    class StudProgram : Student
    {
        public StudProgram(StudiskiProgram studProgram)
        {
            Id = Student.numberOfRow;
            studiskiProgram = studProgram;
            Student.numberOfRow++;
            Student.Podaci();
        }
    }
}
