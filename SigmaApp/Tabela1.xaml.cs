using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SigmaApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tabela1 : ContentPage
    {
        public Tabela1()
        {
            Content = new Grid 
            { 
                Padding = new Thickness(20), Children = 
                { 
                    new PinchPanContainer
                    {
                        Content = new Image 
                        {
                           Source = ImageSource.FromFile ("Tabela1")
                        }
                    }
                }
            };
        }

    }
}