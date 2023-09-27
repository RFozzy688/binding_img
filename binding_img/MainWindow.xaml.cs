using System;
using System.Collections.Generic;
using System.IO;
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

namespace binding_img
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] _paths;
        public MainWindow()
        {
            InitializeComponent();

            _paths = Directory.GetFiles(@"C:\img");
            AddPathToListBox();
        }
        private void AddPathToListBox()
        {
            foreach (string path in _paths)
            {
                ListBoxItem lbi = new ListBoxItem();
                lbi.Content = path;
                ListBox.Items.Add(lbi);
            }
        }
    }
}
