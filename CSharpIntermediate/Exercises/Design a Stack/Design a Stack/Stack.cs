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

        /*
         * Class indexer
         */
        public object this[int i]
        {
            get
            {
                return _stackList[i];
            }
        }

        /*
         * Length prop for own indexer Stack
         */
        public int Length
        {
            get { return _stackList.Count; }
        }

        /*
         * Add element to start
         */
        public void Push(object obj)
        {
            _stackList.Insert(0, obj);
        }

        /*
         * Remove element from end / store it in a variable if you wish
         */
        public object Pop()
        {
            object returnObject = _stackList[_stackList.Count - 1];
            _stackList.RemoveAt(_stackList.Count - 1);
            return returnObject;
        }

        void Clear()
        {

        }

    }
}
