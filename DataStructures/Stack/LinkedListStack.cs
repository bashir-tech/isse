﻿using LinkedList.Singly;
using Stack.Contract;

namespace Stack
{
    public class LinkedListStack<T> : IStack<T>
    {
        private SinglyLinkedList<T> _innerList;
        public LinkedListStack()
        {
            _innerList = new SinglyLinkedList<T>();
        }

        public int Count => _innerList.Count();

        public T Peek()
        {
            return _innerList.Head is null
                ? default(T)
                : _innerList.Head.Value;
        }

        public T Pop()
        {
            if (_innerList.Head is null)
                throw new Exception("Underflow stack is empty");
            return _innerList.RemoveFirst();
        }

        public void Push(T item)
        {
             _innerList.AddFirst(item);
        }
    }
}