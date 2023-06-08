using System.Windows;
using System.Windows.Controls;

namespace CafeApp.View
{
    /// <summary>
    /// Interaction logic for CustomersView.xaml
    /// </summary>
    public partial class CustomersView : UserControl
    {
        public CustomersView()
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
            Grid.SetColumn(this.gridCustomerList, newColumn);
        }
    }
}
