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

namespace GO5_SupplierPreview.Views
{
    /// <summary>
    /// Logica di interazione per AnteprimaStampa.xaml
    /// </summary>
    public partial class AnteprimaStampa : Window
    {
        public AnteprimaStampa(FixedDocument document)

        {
            InitializeComponent();
            documentViewer.Document = document;
        }
    }
}
