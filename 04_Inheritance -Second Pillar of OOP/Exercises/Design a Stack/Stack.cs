using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class Stack
    {
        public List<object> MyStack { get; set; } = new List<object>();
        public void Push(object obj)
        {
            if (obj != null)
            {
                MyStack.Add(obj);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public object Pop()
        {
            if (MyStack != null)
            {
                var lastMember = MyStack.Last();
                MyStack.Remove(lastMember);
                return lastMember;
            }
            else
            {
                throw new InvalidOperationException();
            }
            
        }

        public void Clear()
        {
            MyStack.Clear();
        }
    }
}
