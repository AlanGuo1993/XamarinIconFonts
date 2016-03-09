using Xamarin.Forms.Platform.Android;
using Android.App;
using Xamarin.Forms;
using IconFonts.Droid;

[assembly:ExportRenderer (typeof(ContentPage), typeof(IconPageRenderer))]
namespace IconFonts.Droid
{
	public class IconPageRenderer : PageRenderer
	{
		protected override void OnAttachedToWindow()
		{
			base.OnAttachedToWindow();

			var tabPage = this.Element as ITabPage;
			var actionBar = ((Activity)this.Context)?.ActionBar;
			if (actionBar != null && !string.IsNullOrEmpty(tabPage?.TabIcon))
			{
				actionBar.SetIcon(new FontDrawable(this.Context, tabPage.TabIcon, Color.White.ToAndroid(), 32));
			}
		}
	}
}