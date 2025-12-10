using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MauiApp1.Model
{
    internal class Student:INotifyPropertyChanged
    {
        private string _name;
        public string Name 
        {
            get => _name; 
            set 
            {
                if (_name != value)
                {
                    _name = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
                }
            } 
        }
        public string Surname { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public override string ToString()
        {
            return $"{this.Name} - {this.Surname}";
        }
    }
}
