using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace MauiApp1.ViewModel
{
    internal partial class StudentsViewModel : ObservableObject
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        //public ICommand GoToAddStudentsCommand { get; set; }
        
        //public ICommand ChangeStudentNameCommand { get; set; }
        
        [ObservableProperty]
        private ObservableCollection<Student> _students = new ObservableCollection<Student>();

        
        //Student x = new Student() { Name = "Ivan", Surname = "Ivanov" };

        [ObservableProperty]
        private Student _testStudent = new Student() { Name = "Ivan", Surname = "Ivanov" };
        public StudentsViewModel() 
        {
            //students = new List<Student>();
            //students.Add(new Student() { Name = "Ivan", Surname = "Ivanov" });
            //var tmpStudent = new Student() { Name = "Petr", Surname = "Petrov" };
            //GoToAddStudentsCommand = new Command(GoToAddStudentsPage);
            //ChangeStudentNameCommand = new Command(ChangeStudentName);
            _students.Add(TestStudent);
            _students.Add(new Student() { Name = "Petr", Surname = "Petrov" });
            //students.Add(tmpStudent);
        }

        [RelayCommand]
        private void GoToAddStudentsPage()
        {
            Shell.Current.GoToAsync(nameof(AddStudentsPage));
            Students.Add(new Student() { Name = "Petr", Surname = "Ivanov" });
        }
        //private bool Test()
        //{
        //    return false;
        //}

        [RelayCommand]
        private void ChangeStudentName()
        {
            _students[0].Name = "Test";
        }
    }
}
