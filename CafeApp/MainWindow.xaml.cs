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

namespace CafeApp
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

        private void btnMoveClick(object sender, RoutedEventArgs e)
        {
            //var valueColumnProperty = (int) this.gridCustomerList.GetValue(Grid.ColumnProperty);

            //var newvalueColumnProperty = valueColumnProperty == 0 ? 2 : 0;
            //this.gridCustomerList.SetValue(Grid.ColumnProperty, newvalueColumnProperty);

            var column = Grid.GetColumn(this.gridCustomerList);

            var newColumn = column == 0 ? 2 : 0;
            Grid.SetColumn(this.gridCustomerList,newColumn);
        }
    }
}
