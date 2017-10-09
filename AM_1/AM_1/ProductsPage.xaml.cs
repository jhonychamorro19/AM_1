using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AM_1.ViewModels;
using System.Collections.ObjectModel;

namespace AM_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsPage : ContentPage
    {

        public ObservableCollection<Productos> elements { get; set; }
        public ProductsPage()
        {
            InitializeComponent();
            elements = new ObservableCollection<Productos>();
            elements.Add(new Productos
            {
                Image = "icon.png",
                Name = "Cloruro Blano",
                Type = "Generico"
            });
            elements.Add(new Productos
            {
                Image = "icon.png",
                Name = "Cloruro de Potasio",
                Type = "Generico"
            });
            elements.Add(new Productos
            {
                Image = "icon.png",
                Name = "Fosfato",
                Type = "Generico"
            });
            elements.Add(new Productos
            {
                Image = "urea.png",
                Name = "Molimax",
                Type = "Mezcla"
            });
            elements.Add(new Productos
            {
                Image = "icon.png",
                Name = "Molimax para Café",
                Type = "Mezcla"
            });
            elements.Add(new Productos
            {
                Image = "icon.png",
                Name = "Molimax para Maiz",
                Type = "Mezcla"
            });
            elements.Add(new Productos
            {
                Image = "icon.png",
                Name = "Acido Fosforico",
                Type = "Solubles"
            });
            elements.Add(new Productos
            {
                Image = "icon.png",
                Name = "Nitrato de Calcio",
                Type = "Solubles"
            });
            elements.Add(new Productos
            {
                Image = "icon.png",
                Name = "Sulfato de Zinc",
                Type = "Solubles"
            });
            listView.ItemsSource = elements;

        }
    }
}