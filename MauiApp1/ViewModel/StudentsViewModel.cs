using MauiApp1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MauiApp1.ViewModel
{
    internal class StudentsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public List<Student> students = new List<Student>();

        Student x = new Student() { Name = "Ivan", Surname = "Ivanov" };

        public Student TestStudent { get => x; set => x = value; }
        public StudentsViewModel() 
        {
            //students = new List<Student>();
            //students.Add(new Student() { Name = "Ivan", Surname = "Ivanov" });
            //var tmpStudent = new Student() { Name = "Petr", Surname = "Petrov" };
            students.Add(x);
            students.Add(new Student() { Name = "Petr", Surname = "Petrov" });
            //students.Add(tmpStudent);
        }
    }
}
