using System;
using System.Windows;
using RentalHousingLibrary;

namespace RentalHousingApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
                string address = AddressTextBox.Text;
                int numberOfRooms = int.Parse(RoomsTextBox.Text);
                int numberOfBeds = int.Parse(BedsTextBox.Text);
                decimal dailyRent = decimal.Parse(RentTextBox.Text);
                decimal insuranceDeposit = decimal.Parse(InsuranceTextBox.Text);
                int days = int.Parse(DaysTextBox.Text);

                
                RentalHousing rentalHousing = new RentalHousing(address, numberOfRooms, numberOfBeds, dailyRent, insuranceDeposit);

                
                decimal totalRent = rentalHousing.CalculateRent(days);
                decimal totalCost = rentalHousing.CalculateTotalCost(days);
                decimal bookingCost = rentalHousing.CalculateBookingCost(days);

                ResultLabel.Content = $"Стоимость аренды: {totalRent:C}\nОбщая сумма: {totalCost:C}\nСтоимость бронирования: {bookingCost:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных: " + ex.Message);
            }
        }
    }
}
