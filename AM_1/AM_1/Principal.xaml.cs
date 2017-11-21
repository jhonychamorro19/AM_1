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
    public partial class HomePage : ContentPage
    {
        public class Datos
        {
            public string img { get; set; }

            public string texto { get; set; }
        }

        List<Datos> lista;

        public HomePage()
        {
            InitializeComponent();

            lista = new List<Datos>();

            lista.Add(new Datos
            {
                img = "campo1.jpg",
                texto = "Elige el mejor campo"
            });
            lista.Add(new Datos
            {
                img = "campo2.jpg",
                texto = "Juega con los mejore"
            });
            lista.Add(new Datos
            {
                img = "campo3.jpg",
                texto = "Ofertas"
            });
            lista.Add(new Datos
            {
                img = "campo4.gif",
                texto = "Holi"
            });

            car.ItemsSource = lista;
        }
    }
}