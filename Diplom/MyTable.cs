using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diplom
{
    class MyTable
    {
        public void Add(string name, object value)
        {
            list.Add(new Pair(name, value));
        }

        public ICollection Names
        {
            get
            {
                ArrayList ret = new ArrayList(list.Count);
                foreach (Pair p in list)
                {
                    ret.Add(p.Name);
                }
                return ret;
            }
        }

        public ICollection Values
        {
            get
            {
                ArrayList ret = new ArrayList(list.Count);
                foreach (Pair p in list)
                {
                    ret.Add(p.Value);
                }
                return ret;
            }
        }
        
        private ArrayList list = new ArrayList();
    }

    class Pair
    {
        public Pair(string name, object value)
        {
            this.name = name;
            this.value = value;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public object Value
        {
            get { return value; }
            set { this.value = value; }
        }
        private string name;
        private object value;
    }
}
