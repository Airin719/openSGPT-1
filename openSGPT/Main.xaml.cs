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
using Hammer.MDIContainer.Control;
using openSGPT.administracion;

namespace openSGPT
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            usrCntbody = new UsuarioPerfil();
            usrCntbody.Visibility = System.Windows.Visibility.Visible;
        }

        private void menuSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();           
        }
    }
}
