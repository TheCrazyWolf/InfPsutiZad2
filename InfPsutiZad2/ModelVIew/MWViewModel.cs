using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfPsutiZad2.ModelVIew
{
    internal partial class MWViewModel : ObservableObject
    {
        [ObservableProperty] private DateTime selectedDate;
        [ObservableProperty] private string family;
        [ObservableProperty] private DateTime dateBirhday;
        [ObservableProperty] private int hourBirthay;
        [ObservableProperty] private int daysLearning;


        [ObservableProperty] private ObservableCollection<string> listResult;

        public MWViewModel()
        {
            ListResult = new ObservableCollection<string>();
            SelectedDate = DateTime.Now;
        }


        [RelayCommand]
        private void Do()
        {
            DateBirhday.AddHours(hourBirthay);

            listResult.Add($"Вы {Family}");
            listResult.Add($"Вы {(int)(SelectedDate - DateBirhday).TotalDays} дней прожили");
            listResult.Add($"Вы хотите учится {daysLearning} дней");
            listResult.Add($"Вы станете умным {(SelectedDate.AddDays(daysLearning))}");
            listResult.Add($"Это будет {(SelectedDate.AddDays(daysLearning).DayOfWeek)}");

        }
    }
}
