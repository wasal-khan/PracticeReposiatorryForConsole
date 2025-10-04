using paractiprojectFprReopsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace paractiprojectFprReopsitory
{
    public class Student
    {
        public int Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        
    }

   
}
public class StudentRepository
{
    private List<Student> students = new List<Student>();
    public void AddStudent(Student student)
    {
        students.Add(student);
    }
 
}
