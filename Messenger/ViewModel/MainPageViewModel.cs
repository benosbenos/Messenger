using Messenger.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;



    namespace Messenger.ViewModel
    {
        public class MainPageViewModel : INotifyPropertyChanged
        {
            // Obiekt służący do tworzenia odświeżalnej listy
            public ObservableCollection<Napis> Napisy { get; set; }

            


            public MainPageViewModel()
            {
                Napisy = new ObservableCollection<Napis>
            {
                new Napis { Id = 1, Name = "Jan Postulski", Description = "Kawa to moje życie", ImageLink = "osoba1.jpg"},
                new Napis { Id = 2, Name = "Alicja Bystra", Description = "<brak opisu>", ImageLink = "osoba2.jpg" },
                new Napis { Id = 3, Name = "Adrianna Nowak", Description = "Przyroda to ciężki przedmiot", ImageLink = "osoba3.jpg" },
                new Napis { Id = 4, Name = "Grażyna Łuk", Description = "Życie mnie mnie", ImageLink = "osoba4.jpg"},
                new Napis { Id = 5, Name = "Krystian Błąd", Description = "Life is fun", ImageLink = "osoba5.jpg"},
                new Napis { Id = 6, Name = "Adrian Jańczyk", Description = "Droga do sukcesu nie jest prosta", ImageLink = "osoba6.jpg"},
                new Napis { Id = 7, Name = "Michaś Kowalczyk", Description = "Gry to moja specjalność", ImageLink = "osoba7.jpg"},
            };
               
            }
           

            /*
             *  GŁÓWNE SKŁADNIKI NASZEJ STRUKTURY MVVM
             *  Poza przypisaniem naszej klasy MainPageViewModel do interfejsu INotifyPropertyChanged potrzebujemy również
             *  utworzyć zdarzenie PropertyChanged oraz funkcje OnPropertyChanged(string propertyName) które służy do
             *  powiadomienia naszego widoku, że nastąpiła zmiana w naszych obiektach i ma odświeżyć dane w widoku!
             */
            public event PropertyChangedEventHandler? PropertyChanged;
            public void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

