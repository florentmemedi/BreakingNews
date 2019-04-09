using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingNewsAndGenericList
{
    public class GenericList
    {
        public class CustomList<T>
        {
            public CustomList()
            {
                Array = new T[1];
            }
            private T[] Array { get; set; }
            public int Count { get { return Array.Count(); } }
            public void Add(T item)
            {
                var t = Array.ToList();
                t.Add(item);
                Array = t.ToArray();
            }
            public void Remove(int index)
            {
                var t = Array.ToList();
                t.RemoveAt(index);
                Array = t.ToArray();
            }
            public T GetElementByIndex(int index)
            {
                return Array.ToList().ElementAt(index);
            }
            public T this[int index]
            {
                get
                {
                    return Array.ToList().ElementAt(index);
                }
            }
        }
    }
}

