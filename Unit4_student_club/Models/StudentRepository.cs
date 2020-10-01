using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unit4_student_club.Models
{
    public class StudentRepository
    {
        List<StudentModel> myStudents = new List<StudentModel>();

        public StudentRepository()
        {
            myStudents.Add(new StudentModel(0, "Tom", 16));
            myStudents.Add(new StudentModel(1, "Jen", 8));
            myStudents.Add(new StudentModel(2, "Sabah", 16));
        }

        public List<StudentModel>  getAllStudent()
        {
            return (myStudents);
        }

        public StudentModel getOneStudent(int index)
        {
            return (myStudents[index]);
        }
    }
}
