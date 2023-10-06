using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class ArrayListQueue : Queue
    {
        private List list;
        
        public ArrayListQueue(int cap)
        {
            list = new ArrayList(cap);
        }
        public object dequeue()
        {
            object e = peek();
            list.remove(0);
            return e;
        }

        public void enqueue(object e)
        {
            list.add(e);
        }

        public bool isEmpty()
        {
            return list.IsEmpty();
        }

        public object peek()
        {
            if (isEmpty())
                throw new System.MissisngMemberException();
            return list.get(0);
        }

        public int size()
        {
            return list.Size();
        }


    }
}
