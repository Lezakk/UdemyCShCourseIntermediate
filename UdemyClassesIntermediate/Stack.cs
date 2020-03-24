using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyClassesIntermediate
{
    public class Stack
    {
        public List<object> stackList = new List<object>();

        public void Push(object obj)
        {
            if (obj is null) throw new InvalidOperationException();
            stackList.Add(obj);
        }

        public object Pop()
        {
            int lastItem = stackList.Count - 1;
            if (stackList.Count == 0) throw new InvalidOperationException();
            var result = stackList[lastItem];
            stackList.RemoveAt(lastItem);
            return result;
        }
        public void Clear()
        {
            stackList.Clear();
        }
    }
}
