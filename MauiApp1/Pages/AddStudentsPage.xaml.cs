using MauiApp1.Pages;

namespace MauiApp1
{
    public partial class AddStudentsPage : ContentPage
    {
        int count = 0;

        public AddStudentsPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync($"//{nameof(StudentsPage)}");
        }
    }
}
