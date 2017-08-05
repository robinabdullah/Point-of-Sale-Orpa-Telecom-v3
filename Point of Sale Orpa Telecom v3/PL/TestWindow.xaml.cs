using System;
using System.Collections.Generic;
using System.Data;
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
using Point_of_Sale_Orpa_Telecom_v3.DAL;

namespace Point_of_Sale_Orpa_Telecom_v3.PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        public TestWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //C_Reports.Customer obj = new C_Reports.Customer();
            //obj.Load(@"Customer.rep");
            //viewer.ViewerCore.ReportSource = obj;

            //C_Reports.DateWiseSalesAddingDiscount obj = new C_Reports.DateWiseSalesAddingDiscount();
            //obj.Load(@"DateWiseSalesAddingDiscount.rep");
            //viewer.ViewerCore.ReportSource = obj;

            //C_Reports.Journals obj = new C_Reports.Journals();
            //obj.Load(@"Journals.rep");
            //viewer.ViewerCore.ReportSource = obj;

            //C_Reports.TestReport obj = new C_Reports.TestReport();
            //var results = (from pp in DB.db.Barcodes
            //               select new { pp.Barcode_Serial }).ToList();

            //if (results == null)
            //    MessageBox.Show("ERROR");

            //obj.Load(@"TestReport.rpt");
            //obj.SetDataSource(results);
            //viewer.ViewerCore.ReportSource = obj;
        }
    }
}
