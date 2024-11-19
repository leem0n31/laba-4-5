using System;

namespace RentalHousingLibrary
{
    public class RentalHousing
    {
        public string Address { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfBeds { get; set; }
        public decimal DailyRent { get; set; }
        public decimal InsuranceDeposit { get; set; }

        public RentalHousing(string address, int numberOfRooms, int numberOfBeds, decimal dailyRent, decimal insuranceDeposit)
        {
            Address = address;
            NumberOfRooms = numberOfRooms;
            NumberOfBeds = numberOfBeds;
            DailyRent = dailyRent;
            InsuranceDeposit = insuranceDeposit;
        }

        public decimal CalculateRent(int days)
        {
            return DailyRent * days;
        }

        public decimal CalculateTotalCost(int days)
        {
            return CalculateRent(days) + InsuranceDeposit;
        }

        public decimal CalculateBookingCost(int days)
        {
            return CalculateRent(days) * 0.10m;
        }
        public string GetInfo()
        {
            return $"Адрес: {Address}\n" +
                   $"Число комнат: {NumberOfRooms}\n" +
                   $"Число спальных мест: {NumberOfBeds}\n" +
                   $"Стоимость аренды в сутки: {DailyRent:C}\n" +
                   $"Сумма страхового взноса: {InsuranceDeposit:C}";
        }
    }
}
