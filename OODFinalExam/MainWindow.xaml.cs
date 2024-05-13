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

namespace OODFinalExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CustomerData db = new CustomerData("OOD_KianReynolds");
        public MainWindow()
        {
            InitializeComponent();

        }




        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Customer selectedCustomer = lbxBookingInfo.SelectedItem as Customer;
            if (selectedCustomer != null && dpDate.SelectedDate.HasValue)
            {
                DateTime selectedDate

                //query the database using LINQ
                using (db)
                {
                    var query1 = from c in db.Customers
                                 select c;

                    var result = query1.ToList();

                    lbxBookingInfo.ItemsSource = result;


                }
            }
        }
    }
}
