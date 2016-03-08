using Xamarin.Forms;

namespace IconFonts
{
	public class MainPage : TabbedPage
	{
		public MainPage()
		{
			this.Children.Add(new ContactsPage());
			this.Children.Add(new SettingsPage());
		}
	}
}