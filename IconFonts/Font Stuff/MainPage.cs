using Xamarin.Forms;

namespace IconFonts
{
	public class MainPage : TabbedPage
	{
		public MainPage()
		{
			this.Children.Add(new ContactsPage());
			this.Children.Add(new SettingsPage());

			this.CurrentPageChanged += (sender, e) =>
			{
				this.Title = this.CurrentPage.Title;
			};

			this.Title = this.Children [0].Title;
		}
	}
}