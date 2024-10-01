using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Daily_TRAIN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }




        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Obtener el botón que fue clickeado
            Button button = sender as Button;
            string muscleGroup = button.Content.ToString();

            // Simular el entrenamiento de esa semana basado en el grupo muscular seleccionado
            switch (muscleGroup)
            {
                case "Pecho":
                    Modelo_Ejercios modelo_Ejercios = new Modelo_Ejercios();
                    modelo_Ejercios.Show();

                    break;
                case "Espalda":
                    
                    break;
                case "Brazo":
                    
                    break;
                case "Pierna":
                    
                    break;
            }
        }
    }
}