using Xamarin.Forms;

namespace IconFonts
{
	public partial class ContactsPage : ContentPage, ITabPage
	{
		public string TabIcon => "\uf41a";

		public string SelectedTabIcon => "\uf419";

		public ContactsPage()
		{
			this.InitializeComponent();
			this.Title = "Contacts";
		}
	}
}