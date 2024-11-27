using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Model
{
    public class Napis : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public string? ImageLink { get; set; }
        
        /*
         *  Dla obiektu również potrzebujemy składnik odświeżania naszego widoku, jeżeli wiemy, że będzie również następowała zmiana wartości w naszej zmiennej
         *  jak np. ilość książek
         */
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
