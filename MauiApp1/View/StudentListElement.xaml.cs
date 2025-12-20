//using AVFoundation;

namespace MauiApp1.View;

public partial class StudentListElement : ContentView
{
	private bool _isEditing = false;
	public StudentListElement()
	{
		InitializeComponent();
		var tapGestureRecognizer = new TapGestureRecognizer();
		tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
		this.GestureRecognizers.Add(tapGestureRecognizer);
	}

	private void TapGestureRecognizer_Tapped(object? sender, TappedEventArgs e)
	{
		_isEditing = !_isEditing;
		nameLabel.IsVisible = !_isEditing;
		surnameLabel.IsVisible = !_isEditing;
		nameEntry.IsVisible = _isEditing;
		surnameLabel.IsVisible = _isEditing;
	}
}