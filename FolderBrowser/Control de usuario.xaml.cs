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

namespace FolderBrowser
{
    /// <summary>
    /// Lógica de interacción para Control_de_usuario.xaml
    /// </summary>
    public partial class Control_de_usuario : UserControl
    {
        public Control_de_usuario()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Titulo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TituloProperty =
            DependencyProperty.Register("Titulo", typeof(string), typeof(Control_de_usuario), new PropertyMetadata(""));

        public string Ruta
        {
            get { return (string)GetValue(RutaProperty); }
            set { SetValue(RutaProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Ruta.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RutaProperty =
            DependencyProperty.Register("Ruta", typeof(string), typeof(Control_de_usuario), new PropertyMetadata(""));

        private void SeleccionarButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog selectorDirectorio = new System.Windows.Forms.FolderBrowserDialog();

            System.Windows.Forms.DialogResult resultado = selectorDirectorio.ShowDialog();

            if(resultado == System.Windows.Forms.DialogResult.OK)
            {
                Ruta = selectorDirectorio.SelectedPath;
            }
        }
    }
}
