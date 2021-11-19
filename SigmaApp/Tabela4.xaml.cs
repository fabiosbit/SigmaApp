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
    public partial class Tabela4 : ContentPage
    {
        public Tabela4()
        {
            InitializeComponent();
        }

        private void btnCalcularDist_Clicked(object sender, EventArgs e)
        {
            decimal s, d, c, t;

            try
            {
                d = Convert.ToDecimal(entryResol.Text);
                t = Convert.ToDecimal(entryTempo.Text);

                if (t < 0)
                {
                    t *= -1;
                }

                if (entryResol.Text == null || entryTempo.Text == null)
                {
                    DisplayAlert("Erro", "Entre com os valores de T e D", "voltar");
                }
                else
                {
                    c = 8 * (d - 14);   //c não pode ser negativo.

                    if (c < 0)
                    {
                        c = 0;
                    }

                    s = (2000 * t) + c;

                    if (s >= 500)
                    {
                        s = (1600 * t) + c;
                    }



                    DisplayAlert("Resultado", "S = " + Convert.ToString(s) + " mm", "ok");
                }

            }
            catch (FormatException)
            {
                DisplayAlert("Erro", "Valor informado é inválido", "ok");
            }
        }

        //Verifica se o caracter digitado é um número e o apaga caso não seja.
        private void TextChanged(object sender, TextChangedEventArgs args)
        {
            if (!string.IsNullOrWhiteSpace(args.NewTextValue))
            {
                bool numeroOk = args.NewTextValue.ToCharArray().All(x => char.IsDigit(x));

                ((Entry)sender).Text = numeroOk ? args.NewTextValue : args.NewTextValue.Remove(args.NewTextValue.Length - 1);
            }
        }
    }
}