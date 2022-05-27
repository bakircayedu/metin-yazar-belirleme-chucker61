using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazarı_Belirleme
{
    public class LLTypedStack : IStack
    {
        Node top;
        public LLTypedStack()
        {
            this.top = null;
        }
        public Node GetNode(object data)
        {
            Node node = new Node(data);
            return node;
        }
        public void Push(object item)
        {
            Node newNode = GetNode(item);
            if (top== null)
            {
                top = newNode;
                return;
            }
            newNode.Next = top;
            top = newNode;
        }
        public object Pop()
        {
            object peek = -1;
            if (top != null)
            {
                peek = top.Data;
                top = top.Next;
            }
            return peek;
        }
        public object Peek()
        {
            if (top != null)
            {
                return top.Data;
            }
            return -1;
        }  
    }

}
