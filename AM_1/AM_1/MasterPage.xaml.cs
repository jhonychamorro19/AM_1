using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AM_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }
        public MasterPage()
        {
            InitializeComponent();

            var masterPageItem = new List<MasterPageItem>();
            masterPageItem.Add(new MasterPageItem
            {
                Title = "HomePage",
                IconSource = "fox.png",
                TargetType = typeof(HomePage)
            });

            masterPageItem.Add(new MasterPageItem
            {
                Title = "PerfilPage",
                IconSource = "person.png",
                TargetType = typeof(PerfilPage)
            });

            masterPageItem.Add(new MasterPageItem
            {
                //Quienes somos
                Title = "AboutUsPage",
                IconSource = "home.png",
                TargetType = typeof(AboutUsPage)
            });
            
            masterPageItem.Add(new MasterPageItem
            {
                Title = "ProductsPage",
                IconSource = "",
                TargetType = typeof(ProductsPage)
            });
            
            masterPageItem.Add(new MasterPageItem
            {
                //Sucursales
                Title = "BranchPage",
                IconSource = "",
                TargetType = typeof(BranchPage)
            });
           
            masterPageItem.Add(new MasterPageItem
            {
                Title = "NewsPage",
                IconSource = "",
                TargetType = typeof(NewsPage)
            });
           
            masterPageItem.Add(new MasterPageItem
            {
                Title = "ContactPage",
                IconSource = "",
                TargetType = typeof(ContactPage)
            });

            listView.ItemsSource = masterPageItem;
        }
    }
}