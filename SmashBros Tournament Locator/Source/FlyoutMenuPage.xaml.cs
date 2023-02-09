using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmashBros_Tournament_Locator
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FlyoutMenuPage : ContentPage
	{
		public FlyoutMenuPage ()
		{
			InitializeComponent ();
		}
	}

    class FlyoutPageItem
    {
        public string Title { get; set; }
        public Type TargetPage { get; set; }
    }
}