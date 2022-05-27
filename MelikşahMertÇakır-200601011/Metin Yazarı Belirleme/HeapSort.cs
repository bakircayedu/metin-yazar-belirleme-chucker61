using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazarı_Belirleme
{
    public class HeapSort
    {
        public int elemansayisi = 0;
        public LLTypedStack dizi = new LLTypedStack();
        public HeapSort(MaxHeap dizi,int elemansayisi)
        {
            for (int i = 0; i < elemansayisi; i++)
            {
                this.dizi.Push(dizi.Pop());
                this.elemansayisi = elemansayisi;
            }
        }
        public object[] Sort()
        {
            MaxHeap h = new MaxHeap(elemansayisi);
            object[] sorted = new object[elemansayisi];
            for (int j=0;j<elemansayisi;j++)
            {
                h.Add((Kelime)dizi.Pop());
            }
            int i = 0;
            while (!h.IsEmpty())
                sorted[i++] = ((Kelime)h.RemoveMax());
            return sorted;
        }
    }
}
