using Covid19Berlin.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Covid19Berlin
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Item> itemListe; 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            XMLReader reader = new XMLReader();
            int index = 0;
            itemListe = reader.XmlRead();

            lblGesFallzahlen.Content = itemListe[11].Fallzahl;
            lblGesDifferenz.Content = itemListe[11].Differenz;
            lblGesInzidenz.Content = itemListe[11].Inzidenz;
            lblGesGenesen.Content = itemListe[11].Genesen;

            foreach(Item item in itemListe)
            {
                fuelleButtonListe(item.Bezirk, index);
                index++;
            }

        }

        private void fuelleButtonListe(string bezirkName, int index)
        {
            if (bezirkName != "Berlin")
            {
                Button btnBezirk = new Button();
                btnBezirk.Content = bezirkName;
                btnBezirk.Name = "b" + Convert.ToString(index);
                btnBezirk.Click += new RoutedEventHandler(BtnBezirk_Click);
                btnBezirk.Height = 38;
                btnBezirk.Width = 200;
                btnBezirk.HorizontalAlignment = HorizontalAlignment.Center;
                btnBezirk.BorderThickness = new Thickness(2);
                btnBezirk.Margin = new Thickness(0, 1, 0, 0);
                //btnBezirk.BorderBrush = 
                pnlListeAlleBezirke.Children.Add(btnBezirk);
                pnlListeAlleBezirke.UpdateLayout();

            }
        }

        private void BtnBezirk_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            int index = Convert.ToInt32(btn.Name.Substring(1));

            lblBezirkname.Content = itemListe[index].Bezirk;
            lblFallzahlen.Content = itemListe[index].Fallzahl;
            lblDifferenz.Content = itemListe[index].Differenz;
            lblInzidenz.Content = itemListe[index].Inzidenz;
            lblGenesen.Content = itemListe[index].Genesen;
            pnlAktuellerBezirk.UpdateLayout();
        }
        
    }
}
