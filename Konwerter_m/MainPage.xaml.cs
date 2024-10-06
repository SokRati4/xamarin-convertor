using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Konwerter_m
{
    public partial class MainPage : ContentPage
    {
        private int numer;
        public MainPage()
        {
            InitializeComponent();
        }


       
        private void Sec_Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = (Picker)sender;

            if (picker.SelectedIndex == 0)
            {

                input_text.IsVisible = true;



            }
            else if (picker.SelectedIndex == 1)
            {

                input_text.IsVisible = true;


            }
            else if (picker.SelectedIndex == 2)
            {

                input_text.IsVisible = true;


            }
            else
            {
                input_text.IsVisible = false;
            }
        }
        public void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = (Picker)sender;
            numer = picker.SelectedIndex;

            ClearPickerOptions();

            if (picker.SelectedIndex == 0)
            {

                jednostka_poczatkowa.IsVisible = true;
                jednostka_poczatkowa.Items.Add("Kilometry");
                jednostka_poczatkowa.Items.Add("Metry");
                jednostka_poczatkowa.Items.Add("Centymetry");

                jednostka_konieczna.IsVisible = true;
                jednostka_konieczna.Items.Add("Kilometry");
                jednostka_konieczna.Items.Add("Metry");
                jednostka_konieczna.Items.Add("Centymetry");

            }
            else if (picker.SelectedIndex == 1)
            {

                jednostka_poczatkowa.IsVisible = true;
                jednostka_poczatkowa.Items.Add("Tony");
                jednostka_poczatkowa.Items.Add("Kilogramy");
                jednostka_poczatkowa.Items.Add("Gramy");

                jednostka_konieczna.IsVisible = true;
                jednostka_konieczna.Items.Add("Tony");
                jednostka_konieczna.Items.Add("Kilogramy");
                jednostka_konieczna.Items.Add("Gramy");

            }
            else if (picker.SelectedIndex == 2)
            {

                jednostka_poczatkowa.IsVisible = true;
                jednostka_poczatkowa.Items.Add("Celsjusze");
                jednostka_poczatkowa.Items.Add("Kelwiny");
                jednostka_poczatkowa.Items.Add("Fahrenheit");

                jednostka_konieczna.IsVisible = true;
                jednostka_konieczna.Items.Add("Celsjusze");
                jednostka_konieczna.Items.Add("Kelwiny");
                jednostka_konieczna.Items.Add("Fahrenheit");

            }
            else
            {
                jednostka_poczatkowa.IsVisible = false;
                jednostka_poczatkowa.Items.Clear();
            }
        }

        
        private void ClearPickerOptions()
        {
            jednostka_poczatkowa.Items.Clear();
            jednostka_konieczna.Items.Clear();
        }


        private bool IsNumeric(string input)
        {
            return double.TryParse(input, out _);
        }
        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (numer == 0)
            {
                int jednostkaPoczatkowaIndex = jednostka_poczatkowa.SelectedIndex;
                int jednostkaKoniecznaIndex = jednostka_konieczna.SelectedIndex;
                wpr_Label.Text = e.NewTextValue;
                double valueToConvert;
                try
                {
                    valueToConvert = double.Parse(e.NewTextValue);
                    switch (jednostkaPoczatkowaIndex)
                    {
                        case 0:
                            wpr_Label.Text = e.NewTextValue + "km ";
                            break;
                        case 1:
                            wpr_Label.Text = e.NewTextValue + "m ";
                            break;
                        case 2:
                            wpr_Label.Text = e.NewTextValue + "cm ";
                            break;
                        default:
                            wpr_Label.Text = e.NewTextValue + "";
                            break;
                    }

                    switch (jednostkaKoniecznaIndex)
                    {
                        case 0:
                            if (jednostkaPoczatkowaIndex == 0)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + valueToConvert + "km";
                                break;
                            }
                            else if (jednostkaPoczatkowaIndex == 1)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + (valueToConvert / 1000) + "km";
                                break;
                            }
                            else if (jednostkaPoczatkowaIndex == 2)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + (valueToConvert / 100000) + "km";
                                break;
                            }
                            break;
                        case 1:
                            if (jednostkaPoczatkowaIndex == 0)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + (valueToConvert * 1000) + "m";
                                break;
                            }
                            else if (jednostkaPoczatkowaIndex == 1)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + valueToConvert + "m";
                                break;
                            }
                            else if (jednostkaPoczatkowaIndex == 2)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + (valueToConvert / 100) + "m";
                                break;
                            }
                            break;
                        case 2:
                            if (jednostkaPoczatkowaIndex == 0)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + (valueToConvert * 100000) + "cm";
                                break;
                            }
                            else if (jednostkaPoczatkowaIndex == 1)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + (valueToConvert * 100) + "cm";
                                break;
                            }
                            else if (jednostkaPoczatkowaIndex == 2)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + valueToConvert + "cm";
                                break;
                            }
                            break;
                        default:
                            wpr_Label.Text = e.NewTextValue + "";
                            break;
                    }
                }
                catch (FormatException)
                {
                    wpr_Label.Text += "Zły format liczby";
                }

            }
            else if (numer == 1)
            {
                int jednostkaPoczatkowaIndex = jednostka_poczatkowa.SelectedIndex;
                int jednostkaKoniecznaIndex = jednostka_konieczna.SelectedIndex;
                wpr_Label.Text = e.NewTextValue;
                double valueToConvert;
                try
                {
                    valueToConvert = double.Parse(e.NewTextValue);
                    switch (jednostkaPoczatkowaIndex)
                    {
                        case 0:
                            wpr_Label.Text = e.NewTextValue + "t ";
                            break;
                        case 1:
                            wpr_Label.Text = e.NewTextValue + "kg ";
                            break;
                        case 2:
                            wpr_Label.Text = e.NewTextValue + "g ";
                            break;
                        default:
                            wpr_Label.Text = e.NewTextValue + "";
                            break;
                    }

                    switch (jednostkaKoniecznaIndex)
                    {
                        case 0:
                            if (jednostkaPoczatkowaIndex == 0)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + valueToConvert + "t";
                                break;
                            }
                            else if (jednostkaPoczatkowaIndex == 1)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + (valueToConvert / 1000) + "t";
                                break;
                            }
                            else if (jednostkaPoczatkowaIndex == 2)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + (valueToConvert / 1000000) + "t";
                                break;
                            }
                            break;
                        case 1:
                            if (jednostkaPoczatkowaIndex == 0)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + (valueToConvert * 1000) + "kg";
                                break;
                            }
                            else if (jednostkaPoczatkowaIndex == 1)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + valueToConvert + "kg";
                                break;
                            }
                            else if (jednostkaPoczatkowaIndex == 2)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + (valueToConvert / 1000) + "kg";
                                break;
                            }
                            break;
                        case 2:
                            if (jednostkaPoczatkowaIndex == 0)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + (valueToConvert * 1000000) + "g";
                                break;
                            }
                            else if (jednostkaPoczatkowaIndex == 1)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + (valueToConvert * 1000) + "g";
                                break;
                            }
                            else if (jednostkaPoczatkowaIndex == 2)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + valueToConvert + "g";
                                break;
                            }
                            break;
                        default:
                            wpr_Label.Text = e.NewTextValue + "";
                            break;
                    }
                }
                catch (FormatException)
                {
                    wpr_Label.Text += "Zły format liczby";
                }

            }
            else if (numer == 2)
            {
                int jednostkaPoczatkowaIndex = jednostka_poczatkowa.SelectedIndex;
                int jednostkaKoniecznaIndex = jednostka_konieczna.SelectedIndex;
                wpr_Label.Text = e.NewTextValue;
                double valueToConvert;
                try
                {
                    valueToConvert = double.Parse(e.NewTextValue);
                    switch (jednostkaPoczatkowaIndex)
                    {
                        case 0:
                            wpr_Label.Text = e.NewTextValue + "°C ";
                            break;
                        case 1:
                            wpr_Label.Text = e.NewTextValue + "°K ";
                            break;
                        case 2:
                            wpr_Label.Text = e.NewTextValue + "°F ";
                            break;
                        default:
                            wpr_Label.Text = e.NewTextValue + "";
                            break;
                    }

                    switch (jednostkaKoniecznaIndex)
                    {
                        case 0:
                            if (jednostkaPoczatkowaIndex == 0)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + valueToConvert + "°C";
                                break;
                            }
                            else if (jednostkaPoczatkowaIndex == 1)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + (valueToConvert + 273.15) + "°C";
                                break;
                            }
                            else if (jednostkaPoczatkowaIndex == 2)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + ((valueToConvert * 2) + 30) + "°C";
                                break;
                            }
                            break;
                        case 1:
                            if (jednostkaPoczatkowaIndex == 0)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + (valueToConvert - 273.15) + "°K";
                                break;
                            }
                            else if (jednostkaPoczatkowaIndex == 1)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + valueToConvert + "°K";
                                break;
                            }
                            else if (jednostkaPoczatkowaIndex == 2)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + (((valueToConvert - 273.15) * 2) + 30) + "°K";
                                break;
                            }
                            break;
                        case 2:
                            if (jednostkaPoczatkowaIndex == 0)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + ((valueToConvert - 30) / 2) + "°F";
                                break;
                            }
                            else if (jednostkaPoczatkowaIndex == 1)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + (((valueToConvert - 30) / 2) + 273.15) + "°F";
                                break;
                            }
                            else if (jednostkaPoczatkowaIndex == 2)
                            {
                                wpr_Label.Text = wpr_Label.Text + "= " + valueToConvert + "°F";
                                break;
                            }
                            break;
                        default:
                            wpr_Label.Text = e.NewTextValue + "";
                            break;
                    }
                }
                catch (FormatException)
                {
                    wpr_Label.Text += "Zły format liczby";
                }

            }

        }
    }
}