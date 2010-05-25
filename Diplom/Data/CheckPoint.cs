using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;

namespace Diplom.Data
{
    public abstract class CheckPoint
    {
        public CheckPoint()
        {
            Results = new ResearchResults();
        }
        virtual public string Name { get; set; }

        abstract public XmlElement ToXml(XmlDocument doc);

        public override string ToString()
        {
            return Name;
        }

        public ResearchResults Results { get; set; }
    }
}
