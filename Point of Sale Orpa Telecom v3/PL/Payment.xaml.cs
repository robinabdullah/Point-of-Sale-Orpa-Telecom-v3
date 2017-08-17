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

namespace Point_of_Sale_Orpa_Telecom_v3.PL
{
    /// <summary>
    /// Interaction logic for Payment.xaml
    /// </summary>
    public partial class Payment : Window
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void customer_Click(object sender, RoutedEventArgs e)
        {
            CustomerPayment c = new CustomerPayment();
            c.ShowDialog();
        }

        private void supplier_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bank_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
