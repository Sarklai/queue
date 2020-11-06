using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace queue_test.Model
{
    public class simplequeue<T>
    {
        private List<T> items = new List<T>();

        private T Head => items.Last(); // Хвост

        private T Tail => items.First(); // Голова

        public int Count => items.Count; // Кол-во

        public simplequeue() { }

        public simplequeue(T data)
        {
            items.Add(data);
        }

        public void Enqueue (T data)
        {
            items.Insert(0, data);
        }

        public T Dequeue()
        {
            var item = Head;
            items.Remove(item);
            return item;
        }

        public T Peek()
        {
            return Head;
        }
    }
}
