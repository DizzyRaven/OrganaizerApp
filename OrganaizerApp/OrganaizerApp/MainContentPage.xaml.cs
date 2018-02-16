using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrganaizerApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainContentPage : ContentPage
	{
		public MainContentPage ()
		{
			InitializeComponent ();

            ToolbarItem tb = new ToolbarItem()
            {
                Text = "Add",
                Order = ToolbarItemOrder.Primary,
                Priority = 0,
                Icon = new FileImageSource
                {
                    File = "Pencil.png"
                }
            };
            ToolbarItems.Add(tb);
		}
	}
}