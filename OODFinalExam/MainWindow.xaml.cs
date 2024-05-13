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
                DateTime selectedDate = dpDate.SelectedDate.Value;

                int bookingsCount = db.Bookings.Count(b => b.CustomerID == selectedCustomer.CustomerID && b.BookingsDate == selectedDate.Date);

                int availableSeats = 40 - bookingsCount;

                //Bookings and Available Space on bootom of xaml screen
                tblkBookingsCount.Text = $"Bookings: {bookingsCount}";

                tblkAvailable.Text = $"Available: {availableSeats}";

                //query the database using LINQ
                
            }
        }

        private void btnCustomerSearch_Click(object sender, RoutedEventArgs e)
        {
            Window1 secondWindow = new Window1();

            secondWindow.Owner = this;

            secondWindow.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (db)
            {
                var query1 = from c in db.Customers
                             select c.Name + c.ContactNumber ;
                             

                var result = query1.ToList();

                lbxBookingInfo.ItemsSource = result;


            }
        }
    }
}
