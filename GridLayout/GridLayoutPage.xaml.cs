using Xamarin.Forms;
using System.Diagnostics;

namespace GridLayout
{
	public partial class GridLayoutPage : ContentPage
	{
		public GridLayoutPage()
		{
			InitializeComponent();

			//var grid = new Grid();

			//grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
			//grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });

			//grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
			//grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });

			//var top_left = new Label {
			//	Text = "Top Left",
			//	BackgroundColor = Color.Red
			//};
			//var top_right = new Label
			//{
			//	Text = "Top Right",
			//	BackgroundColor = Color.Green
			//};
			//var bottom_left = new Label
			//{
			//	Text = "Bottom Left",
			//	BackgroundColor = Color.Blue
			//};
			//var bottom_right = new Label
			//{
			//	Text = "Bottom Right",
			//	BackgroundColor = Color.Yellow
			//};

			//grid.Children.Add(top_left, 0, 0);
			//grid.Children.Add(top_right, 1, 0);
			//grid.Children.Add(bottom_left, 0, 1);
			//grid.Children.Add(bottom_right, 1, 1);

			//Content = grid;
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			var btn = sender as Button;
			var number = btn.Text;

			PhoneNumber.Text += number;
			//throw new NotImplementedException();
		}

		async void Dial_Clicked(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
			//Debug.WriteLine("call phone number is {0}", PhoneNumber.Text);
			await DisplayAlert("System Info", $"call phone number is {PhoneNumber.Text}", "確定");
		}
	}
}
