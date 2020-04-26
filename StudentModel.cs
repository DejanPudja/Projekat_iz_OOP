using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat__Windows_Forms_App_
{
    class StudentModel:Student
    {
        public StudentModel(Student student)
        {
            Id = student.Id;
            Ime = student.Ime;
            Prezime = student.Prezime;
            Godine = student.Godine;
            studiskiProgram = student.studiskiProgram;
        }
    }
}
