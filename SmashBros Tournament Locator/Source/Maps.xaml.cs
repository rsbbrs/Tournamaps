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
	public partial class Maps : ContentPage
	{
		// Private string storing the most recent search string.
		private string _searchText;

		// Public property to access the private string.
		public string SearchText
		{
			get
			{
				return _searchText;
			}
			set
			{
				_searchText = value;
				OnPropertyChanged("SearchText");
			} 
		}

		public Maps()
		{
			InitializeComponent();
			BindingContext = this;
		}

		void OnEntryCompleted(object sender, EventArgs e)
		{
			SearchText = ((Entry)sender).Text;
            //output.SetBinding(Label.TextProperty, "Text");
            Console.WriteLine(SearchText);
		}
    }
}