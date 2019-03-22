using System;
using System.Collections.Generic;

namespace Design_a_Stack
{
    public class Stack
    {
        private List<object> _stackList;

        public Stack()
        {
            _stackList = new List<object>();
        }

        public object this[int i]
        {
            get
            {
                return _stackList[i];
            }
        }

        public int Length
        {
            get { return _stackList.Count; }
        }

        public void Push(object obj)
        {
            if(obj is null)
                throw new InvalidOperationException("Null is an invalid value for type Stack");
            else
                _stackList.Insert(0, obj);
        }

        public object Pop()
        {
            if (Length >= 1)
            {
                object returnObject = _stackList[_stackList.Count - 1];
                _stackList.RemoveAt(_stackList.Count - 1);
                return returnObject;
            }
            else
                throw new InvalidOperationException("Cannot remove element from Stack size: 0");
        }

        public void Clear()
        {
            if(Length >= 1)
            {
                while (Length >= 1)
                {
                    _stackList.RemoveAt(0);
                }
            }
            else
            {
                throw new InvalidOperationException("Cannot clear an empty Stack");
            }
        }

    }
}
