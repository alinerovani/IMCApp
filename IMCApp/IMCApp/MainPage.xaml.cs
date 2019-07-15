using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IMCApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void Calcular(object sender, EventArgs args)
        {
            //Verifica se as informações foram preenchidas
            if (pckSexo.SelectedIndex == -1 || txtIdade.Text == string.Empty || txtPeso.Text == string.Empty || txtAltura.Text == string.Empty)
            {
                await DisplayAlert("Erro", "Para realizar o cálculo os dados devem ser preenchidos.", "OK");
                return;
            }

            //Verifica a idade informada
            if (int.Parse(txtIdade.Text) < 6)
            {
                await DisplayAlert("Erro", "Esse cálculo não se aplica a crianças menores de 6 anos.", "OK");
                return;
            }

            //Realiza o cálculo
            int sexo = pckSexo.SelectedIndex;
            int idade = int.Parse(txtIdade.Text);
            decimal peso = decimal.Parse(txtPeso.Text);
            decimal altura = decimal.Parse(txtAltura.Text);

            decimal imc = peso / (altura * altura);
            imc = decimal.Parse(imc.ToString("0.##"));

            //O seu IMC é 
            lblIMC.Text = string.Format("O seu IMC é {0}", imc);

            //Diagnóstico:
            lblDiagnostico.Text = "Diagnóstico: ";

            if (idade > 15)
            {
                if (imc < 17)
                {
                    lblDiagnostico.Text += "Muito abaixo do peso";
                }
                else if (imc >= 17 && imc <= (decimal)18.49)
                {
                    lblDiagnostico.Text += "Abaixo do peso";
                }
                else if (imc >= (decimal)18.5 && imc <= (decimal)24.99)
                {
                    lblDiagnostico.Text += "Peso normal";
                }
                else if (imc >= 25 && imc <= (decimal)29.99)
                {
                    lblDiagnostico.Text += "Acima do Peso";
                }
                else if (imc >= 30 && imc <= (decimal)34.99)
                {
                    lblDiagnostico.Text += "Obesidade I";
                }
                else if (imc >= 35 && imc <= (decimal)39.99)
                {
                    lblDiagnostico.Text += "Obesidade II (severa)";
                }
                else if (imc > 40)
                {
                    lblDiagnostico.Text += "Obesidade III (mórbida)";
                }
            }
            else
            {
                //Meninas
                if (pckSexo.SelectedIndex == 0)
                {
                    switch (idade)
                    {
                        case 6:
                            if (imc >= (decimal)14.3 && imc <= (decimal)16.1)
                            {
                                lblDiagnostico.Text += "Peso normal";
                            }
                            else if (imc > (decimal)16.1 && imc <= (decimal)17.4)
                            {
                                lblDiagnostico.Text += "Sobrepeso";
                            }
                            else
                            {
                                lblDiagnostico.Text += "Obesidade";
                            }
                            break;
                        case 7:
                            if (imc >= (decimal)14.9 && imc <= (decimal)17.1)
                            {
                                lblDiagnostico.Text += "Peso normal";
                            }
                            else if (imc > (decimal)17.1 && imc <= (decimal)18.9)
                            {
                                lblDiagnostico.Text += "Sobrepeso";
                            }
                            else
                            {
                                lblDiagnostico.Text += "Obesidade";
                            }
                            break;
                        case 8:
                            if (imc >= (decimal)15.6 && imc <= (decimal)18.1)
                            {
                                lblDiagnostico.Text += "Peso normal";
                            }
                            else if (imc > (decimal)18.1 && imc <= (decimal)20.3)
                            {
                                lblDiagnostico.Text += "Sobrepeso";
                            }
                            else
                            {
                                lblDiagnostico.Text += "Obesidade";
                            }
                            break;
                        case 9:
                            if (imc >= (decimal)16.3 && imc <= (decimal)19.1)
                            {
                                lblDiagnostico.Text += "Peso normal";
                            }
                            else if (imc > (decimal)19.1 && imc <= (decimal)21.7)
                            {
                                lblDiagnostico.Text += "Sobrepeso";
                            }
                            else
                            {
                                lblDiagnostico.Text += "Obesidade";
                            }
                            break;
                        case 10:
                            if (imc >= 17 && imc <= (decimal)20.1)
                            {
                                lblDiagnostico.Text += "Peso normal";
                            }
                            else if (imc > (decimal)20.1 && imc <= (decimal)23.2)
                            {
                                lblDiagnostico.Text += "Sobrepeso";
                            }
                            else
                            {
                                lblDiagnostico.Text += "Obesidade";
                            }
                            break;
                        case 11:
                            if (imc >= (decimal)17.6 && imc <= (decimal)21.1)
                            {
                                lblDiagnostico.Text += "Peso normal";
                            }
                            else if (imc > (decimal)21.1 && imc <= (decimal)24.5)
                            {
                                lblDiagnostico.Text += "Sobrepeso";
                            }
                            else
                            {
                                lblDiagnostico.Text += "Obesidade";
                            }
                            break;
                        case 12:
                            if (imc >= (decimal)18.3 && imc <= (decimal)22.1)
                            {
                                lblDiagnostico.Text += "Peso normal";
                            }
                            else if (imc > (decimal)22.1 && imc <= (decimal)25.9)
                            {
                                lblDiagnostico.Text += "Sobrepeso";
                            }
                            else
                            {
                                lblDiagnostico.Text += "Obesidade";
                            }
                            break;
                        case 13:
                            if (imc >= (decimal)18.9 && imc <= 23)
                            {
                                lblDiagnostico.Text += "Peso normal";
                            }
                            else if (imc > 23 && imc <= (decimal)27.7)
                            {
                                lblDiagnostico.Text += "Sobrepeso";
                            }
                            else
                            {
                                lblDiagnostico.Text += "Obesidade";
                            }
                            break;
                        case 14:
                            if (imc >= (decimal)19.3 && imc <= (decimal)23.8)
                            {
                                lblDiagnostico.Text += "Peso normal";
                            }
                            else if (imc > (decimal)23.8 && imc <= (decimal)27.9)
                            {
                                lblDiagnostico.Text += "Sobrepeso";
                            }
                            else
                            {
                                lblDiagnostico.Text += "Obesidade";
                            }
                            break;
                        case 15:
                            if (imc >= (decimal)19.6 && imc <= (decimal)24.2)
                            {
                                lblDiagnostico.Text += "Peso normal";
                            }
                            else if (imc > (decimal)24.2 && imc <= (decimal)28.8)
                            {
                                lblDiagnostico.Text += "Sobrepeso";
                            }
                            else
                            {
                                lblDiagnostico.Text += "Obesidade";
                            }
                            break;
                    }
                }
                //Meninos
                else
                {
                    switch (idade)
                    {
                        case 6:
                            if (imc >= (decimal)14.5 && imc <= (decimal)16.6)
                            {
                                lblDiagnostico.Text += "Peso normal";
                            }
                            else if (imc > (decimal)16.6 && imc <= 18)
                            {
                                lblDiagnostico.Text += "Sobrepeso";
                            }
                            else
                            {
                                lblDiagnostico.Text += "Obesidade";
                            }
                            break;
                        case 7:
                            if (imc >= 15 && imc <= (decimal)17.3)
                            {
                                lblDiagnostico.Text += "Peso normal";
                            }
                            else if (imc > (decimal)17.3 && imc <= (decimal)19.1)
                            {
                                lblDiagnostico.Text += "Sobrepeso";
                            }
                            else
                            {
                                lblDiagnostico.Text += "Obesidade";
                            }
                            break;
                        case 8:
                            if (imc >= (decimal)15.6 && imc <= (decimal)16.7)
                            {
                                lblDiagnostico.Text += "Peso normal";
                            }
                            else if (imc > (decimal)16.7 && imc <= (decimal)20.3)
                            {
                                lblDiagnostico.Text += "Sobrepeso";
                            }
                            else
                            {
                                lblDiagnostico.Text += "Obesidade";
                            }
                            break;
                        case 9:
                            if (imc >= (decimal)16.1 && imc <= (decimal)18.8)
                            {
                                lblDiagnostico.Text += "Peso normal";
                            }
                            else if (imc > (decimal)18.8 && imc <= (decimal)21.4)
                            {
                                lblDiagnostico.Text += "Sobrepeso";
                            }
                            else
                            {
                                lblDiagnostico.Text += "Obesidade";
                            }
                            break;
                        case 10:
                            if (imc >= (decimal)16.7 && imc <= (decimal)19.6)
                            {
                                lblDiagnostico.Text += "Peso normal";
                            }
                            else if (imc > (decimal)19.6 && imc <= (decimal)22.5)
                            {
                                lblDiagnostico.Text += "Sobrepeso";
                            }
                            else
                            {
                                lblDiagnostico.Text += "Obesidade";
                            }
                            break;
                        case 11:
                            if (imc >= (decimal)17.2 && imc <= (decimal)20.3)
                            {
                                lblDiagnostico.Text += "Peso normal";
                            }
                            else if (imc > (decimal)20.3 && imc <= (decimal)23.7)
                            {
                                lblDiagnostico.Text += "Sobrepeso";
                            }
                            else
                            {
                                lblDiagnostico.Text += "Obesidade";
                            }
                            break;
                        case 12:
                            if (imc >= (decimal)17.8 && imc <= (decimal)21.1)
                            {
                                lblDiagnostico.Text += "Peso normal";
                            }
                            else if (imc > (decimal)21.1 && imc <= (decimal)24.8)
                            {
                                lblDiagnostico.Text += "Sobrepeso";
                            }
                            else
                            {
                                lblDiagnostico.Text += "Obesidade";
                            }
                            break;
                        case 13:
                            if (imc >= (decimal)18.5 && imc <= (decimal)21.9)
                            {
                                lblDiagnostico.Text += "Peso normal";
                            }
                            else if (imc > (decimal)21.9 && imc <= (decimal)25.9)
                            {
                                lblDiagnostico.Text += "Sobrepeso";
                            }
                            else
                            {
                                lblDiagnostico.Text += "Obesidade";
                            }
                            break;
                        case 14:
                            if (imc >= (decimal)19.2 && imc <= (decimal)22.7)
                            {
                                lblDiagnostico.Text += "Peso normal";
                            }
                            else if (imc > (decimal)22.7 && imc <= (decimal)26.9)
                            {
                                lblDiagnostico.Text += "Sobrepeso";
                            }
                            else
                            {
                                lblDiagnostico.Text += "Obesidade";
                            }
                            break;
                        case 15:
                            if (imc >= (decimal)19.9 && imc <= (decimal)23.6)
                            {
                                lblDiagnostico.Text += "Peso normal";
                            }
                            else if (imc > (decimal)23.6 && imc <= (decimal)27.7)
                            {
                                lblDiagnostico.Text += "Sobrepeso";
                            }
                            else
                            {
                                lblDiagnostico.Text += "Obesidade";
                            }
                            break;
                    }
                }
            }
        }

        public void Limpar(object sender, EventArgs args)
        {
            pckSexo.SelectedIndex = -1;
            txtIdade.Text = string.Empty;
            txtPeso.Text = string.Empty;
            txtAltura.Text = string.Empty;

            lblIMC.Text = string.Empty;
            lblDiagnostico.Text = string.Empty;

            lblIMC.IsVisible = false;
            lblDiagnostico.IsVisible = false;
        }
    }
}
