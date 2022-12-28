using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PerfectPay.MVVM.ViewModels
{
    public partial class PerfectPayVM:ObservableObject
    {

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(TipAmount))]
        [NotifyPropertyChangedFor(nameof(SubTotalAmount))]
        [NotifyPropertyChangedFor(nameof(TotalAmount))]
        public string billAmount;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(TipAmount))]
        [NotifyPropertyChangedFor(nameof(SubTotalAmount))]
        [NotifyPropertyChangedFor(nameof(TotalAmount))]
        public double tipPercentage;


        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(TipAmount))]
        [NotifyPropertyChangedFor(nameof(SubTotalAmount))]
        [NotifyPropertyChangedFor(nameof(TotalAmount))]
        public double numberOfPeople;

        public double TipAmount
        {
            get { return (Convert.ToDouble(BillAmount) * (TipPercentage / 100)); }
        }


        public double SubTotalAmount
        {
            get { return Convert.ToDouble(BillAmount) + (Convert.ToDouble(BillAmount) * (TipPercentage / 100)); }
        }


        public double TotalAmount
        {
            get { return (Convert.ToDouble(BillAmount) + (Convert.ToDouble(BillAmount) * (TipPercentage / 100))) / NumberOfPeople ; }
        }

        public PerfectPayVM()
        {
            BillAmount = "0";
            TipPercentage = 0;
            NumberOfPeople = 1;

        }

        [RelayCommand]
        public void TipFixedPercentage(string value)
        {
            value = value.Replace('%',' ');
           TipPercentage = Convert.ToDouble(value);
        }



        [RelayCommand]
        public void BillAmountConvert(string value)
        {
            TipPercentage = Convert.ToDouble(value);
        }


        [RelayCommand]
        public void RemoveAnotherPerson()
        {
            NumberOfPeople = NumberOfPeople <= 1 ? 1 : --NumberOfPeople;
        }




        [RelayCommand]
        public void AddAnotherPerson()
        {
            NumberOfPeople++;
        }








    }
}
