using MauiApp1.Model;
using MauiApp1.ViewModel;
namespace MauiApp1.Pages;

public partial class StudentsPage : ContentPage
{
	StudentsViewModel viewModel = new StudentsViewModel();
	public StudentsPage()
	{
		InitializeComponent();

        studentsList.ItemsSource = viewModel.students;

		buttonExample.SetBinding(Button.TextProperty, new Binding("Name"));
		//buttonExample.BindingContext = tmpStudent;
		buttonExample.BindingContext = viewModel.TestStudent;
		//ButtonExample.SetBinding(Button.TextProperty, new Binding("Name"));

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(AddStudentsPage));
    }

    private void studentsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		viewModel.students[0].Name = "test";
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
		var tmp = sender as Entry;
		var parent = tmp.Parent as HorizontalStackLayout;
		if (parent != null)
		{
			var label = parent.Children[1] as Label;
			var student = viewModel.students.Where(x => x.Name == label.Text).FirstOrDefault();
			if (student != null)
			{
				//label.Text = tmp.Text;
				student.Name = tmp.Text;
			}
			//students.Where(x => x.Name == label.Text).FirstOrDefault();

		}
    }
}