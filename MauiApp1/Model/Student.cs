using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MauiApp1.Model
{
    public partial class Student: ObservableObject
    {
        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        public string _surname;
        public override string ToString()
        {
            return $"{this.Name} - {this.Surname}";
        }
    }
}
