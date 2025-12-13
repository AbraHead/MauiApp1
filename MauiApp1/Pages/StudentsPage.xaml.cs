using MauiApp1.Model;
namespace MauiApp1.Pages;

public partial class StudentsPage : ContentPage
{
	List<Student> students;

	Student x = new Student() { Name = "Ivan", Surname = "Ivanov" };

	public Student TestStudent { get => x; set => x = value; }
	public StudentsPage()
	{
		InitializeComponent();
        students = new List<Student>();
		//students.Add(new Student() { Name = "Ivan", Surname = "Ivanov" });
		//var tmpStudent = new Student() { Name = "Petr", Surname = "Petrov" };
		students.Add(x);
		students.Add(new Student() { Name="Petr", Surname="Petrov"});
        //students.Add(tmpStudent);

        studentsList.ItemsSource = students;

		buttonExample.SetBinding(Button.TextProperty, new Binding("Name"));
		//buttonExample.BindingContext = tmpStudent;
		buttonExample.BindingContext = x;
		//ButtonExample.SetBinding(Button.TextProperty, new Binding("Name"));

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(AddStudentsPage));
    }

    private void studentsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		students[0].Name = "test";
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
		var tmp = sender as Entry;
		var parent = tmp.Parent as HorizontalStackLayout;
		if (parent != null)
		{
			var label = parent.Children[1] as Label;
			var student = students.Where(x => x.Name == label.Text).FirstOrDefault();
			if (student != null)
			{
				//label.Text = tmp.Text;
				student.Name = tmp.Text;
			}
			//students.Where(x => x.Name == label.Text).FirstOrDefault();

		}
    }
}