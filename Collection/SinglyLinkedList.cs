﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class SinglyLinkedList : List
    {
        private LinkedNode first = new LinkedNode(null, null);
        private int SIZE;
        private class LinkedNode
        {
            public object e;
            public LinkedNode next;
            public LinkedNode(object e, LinkedNode next)
            {
                this.e = e;
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
        public void add(int index, object e)
        {
            if (index <= SIZE)
            {
                LinkedNode node = nodeAt(index - 1);
                node.next = new LinkedNode(e, node.next);
                SIZE++;
            }
            else
                throw new NotImplementedException();
        }

        public void add(object e)
        {
            add(SIZE, e);
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

        private void removeAfter(LinkedNode node)
        {
            if (node.next != null)
            {
                node.next = node.next.next;
                SIZE--;

            }
        }
        public void remove(int index)
        {
            LinkedNode node = nodeAt(index - 1);
            removeAfter(node);
            throw new NotImplementedException();
        }

        public void Remove(object e)
        {
            int i = indexOf(e);
            if (i > -1)
                remove(i);
            throw new NotImplementedException();
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
