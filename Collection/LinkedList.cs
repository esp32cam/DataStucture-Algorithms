using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//mi
namespace Collection
{
    public class LinkedList : List
    {
        private LinkedNode first = new LinkedNode(null, null, null);
        private int SIZE;
        private class LinkedNode
        {
            public LinkedNode back;
            public LinkedNode next;
            public object e;
            public LinkedNode(object e, LinkedNode back, LinkedNode next)
            {
                this.e = e;
                this.back = back;
                this.next = next;
            }
        }
        private LinkedNode nodeAt(int index)
        {
            LinkedNode node = first;
            for (int i = -1; i < index; i++)
                node = node.next;
            return node;
        }

        private void removeNode(LinkedNode node)
        {
            LinkedNode before = node.back;
            LinkedNode after = node.next;
            before.next = after;
            after.next = before;
            SIZE--;
        }
        public LinkedList()
        {
            first.back = first.next = first;
        }
        

        public void add(int index, object e)
        {
            addBefore(nodeAt(index), e);
            throw new NotImplementedException();
        }

        public void add(object e)
        {
            addBefore(first, e);
            throw new NotImplementedException();
        }

        public bool contain(object e)
        {
            return indexOf(e) > -1;
            throw new NotImplementedException();
        }

        public object get(int index)
        {
            return nodeAt(index).e;
            throw new NotImplementedException();
        }

        public int indexOf(object e)
        {
            LinkedNode node = first.next;
            for (int i = 0; i < SIZE; i++)
            {
                if (node.e.Equals(e))
                    return i;
                node = node.next;
            }
            return -1;
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            return SIZE == 0;
            throw new NotImplementedException();
        }

        public void remove(int index)
        {
            removeNode(nodeAt(index));
            throw new NotImplementedException();
        }

        public void Remove(object e)
        {
            LinkedNode node = first.next;
            while (node != first)
            {
                if (node.e.Equals(e))
                {
                    removeNode(node);
                    break;
                }
                node = node.next;
            }
            throw new NotImplementedException();
        }

        private void addBefore(LinkedNode node, object e)
        {
            LinkedNode before = node.back;
            LinkedNode here = new LinkedNode(e, before, node);
            before.next = node.back = here;
            SIZE++;
        }

        public void set(int index, object e)
        {
            nodeAt(index).e = e;
            throw new NotImplementedException();
        }

        public int Size()
        {
            return SIZE;
            throw new NotImplementedException();
        }
    }
}
