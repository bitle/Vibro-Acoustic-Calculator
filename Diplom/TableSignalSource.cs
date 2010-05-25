using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diplom
{
    class SignalSource
    {
        public SignalSource(string name, int[] values)
        {
            this.name = name;
            this.values = values;
        }

        public int[] Values
        {
            get
            {
                return values;
            }
        }
        override public string ToString()
        {
            return name;
        }

        private int[] values;
        private string name;
    }

    class Row
    {
        public Row(string name, int[] values)
        {
            this.name = name;
            this.values = values;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int[] Values
        {
            get
            {
                return values;
            }
        }
        override public string ToString()
        {
            return name;
        }

        private int[] values;
        private string name;
    }
    public class RowFloat
    {
        public RowFloat(string name, double[] values)
        {
            this.name = name;
            this.values = values;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public double[] Values
        {
            get
            {
                return values;
            }
        }
        override public string ToString()
        {
            return name;
        }

        public override bool Equals(object obj)
        {
            RowFloat f = (RowFloat)obj;
            return name.Equals(f.Name);
        }

        private double[] values;
        private string name;
    }
}
