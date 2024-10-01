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
using System.Windows.Shapes;

namespace Daily_TRAIN
{
    /// <summary>
    /// Lógica de interacción para Modelo_Ejercios.xaml
    /// </summary>
    public partial class Modelo_Ejercios : Window
    {
        public Modelo_Ejercios()
        {
            InitializeComponent();
            CurrentDateLabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
