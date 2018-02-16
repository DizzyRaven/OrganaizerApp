using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OrganaizerApp
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage()
		{
			InitializeComponent();

            Detail = new NavigationPage(new MainContentPage());
            IsPresented = false;
		}
        private void btn_mainPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MainContentPage());
            IsPresented = false;
        }
        private void btn_settingsPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SettingsContentPage());
            IsPresented = false;
        }
    }
}
