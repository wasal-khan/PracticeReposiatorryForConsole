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
    public void RemoveStudent(int id)
    {
        var student = students.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            students.Remove(student);
        }
    }
    public Student GetStudent(int id)
    {
        return students.FirstOrDefault(s => s.Id == id);
    }
    public List<Student> GetAllStudents()
    {
        Console.WriteLine("This is a test repository for Paracti Project");
        return students;
    }
    public List<Student> GetAllStudentss()
    {
        return students;
    }
}
