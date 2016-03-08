using Xamarin.Forms;

namespace IconFonts
{
	public partial class SettingsPage : ContentPage, ITabPage
	{
		public string TabIcon => "\uf411";

		public string SelectedTabIcon => "\uf412";

		public SettingsPage()
		{
			this.InitializeComponent();
			this.Title = "Settings";
		}
	}
}