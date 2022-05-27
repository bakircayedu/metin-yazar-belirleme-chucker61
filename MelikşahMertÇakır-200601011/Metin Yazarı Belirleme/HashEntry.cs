using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazarı_Belirleme
{
    public class HashEntry
    {
        public string Anahtar { get; set; }
        public object Deger { get; set; }
        public HashEntry Next { get; set; }
        
    }
}
