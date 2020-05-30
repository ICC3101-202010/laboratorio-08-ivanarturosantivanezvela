using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8.CustomEvent_Args
{
    public class SendingRestaurantEventArgs:EventArgs
    {
        public string Nombreduenoenviado { get; set; }
        public string Identificadorenviado { get; set; }
        public string Horarioinicioenviado { get; set; }
        public string Horariocierreenviado { get; set; }
        public string Exlusividadenviado { get; set; }
    }
}
