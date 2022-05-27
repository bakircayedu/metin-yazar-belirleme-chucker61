using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazarı_Belirleme
{
    public class Kelime
    {
        public string Orijinal { get; set; }
        public int MetindeKacinci { get; set; }
        public int CumledeKacinci { get; set; }
        public string Preprocessed { get; set; }
        public int Frequency { get; set; }
    }
}
