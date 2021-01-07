using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Design_A_Stack
{
    public class Stack
    {
        // a stack is always a list, thus we put it it in a list with 
        // data type object (Object Type is the ultimate base class for all)
        private readonly List<object> list = new List<object>();
        private object _object;
        public void Push(object obj)
        {
            _object = obj;

            if (_object == null)
                throw new InvalidOperationException("Cannot push null object to list");

            list.Insert(0, _object);
        }
        public object Pop()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Cannot use .Pop() if list is empty");

            _object = list.FirstOrDefault();

            list.RemoveAt(0);


            return _object;
        }
        public void Clear()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Cannot clear from an empty List.");

            list.Clear();
        }


    }
}
