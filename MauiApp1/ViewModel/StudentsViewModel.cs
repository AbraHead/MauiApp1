using MauiApp1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace MauiApp1.ViewModel
{
    internal class StudentsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ICommand GoToAddStudentsCommand { get; set; }
        public ICommand ChangeStudentNameCommand { get; set; }
        public List<Student> students { get; set; } = new List<Student>();

        Student x = new Student() { Name = "Ivan", Surname = "Ivanov" };

        public Student TestStudent { get => x; set => x = value; }
        public StudentsViewModel() 
        {
            //students = new List<Student>();
            //students.Add(new Student() { Name = "Ivan", Surname = "Ivanov" });
            //var tmpStudent = new Student() { Name = "Petr", Surname = "Petrov" };
            GoToAddStudentsCommand = new Command(GoToAddStudentsPage);
            ChangeStudentNameCommand = new Command(ChangeStudentName);
            students.Add(x);
            students.Add(new Student() { Name = "Petr", Surname = "Petrov" });
            //students.Add(tmpStudent);
        }
        public void GoToAddStudentsPage()
        {
            Shell.Current.GoToAsync(nameof(AddStudentsPage));
        }

        public void ChangeStudentName()
        {
            students[0].Name = "Test";
        }
    }
}
