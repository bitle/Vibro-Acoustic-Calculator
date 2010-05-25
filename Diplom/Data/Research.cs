using System;
using System.Collections.Generic;
using System.Collections;
using System.Xml;
using System.Text;

namespace Diplom.Data
{
    class Research
    {
        public Research(string name)
        {
            this.name = name;
            CheckPoints = new ArrayList();
        }

        public XmlElement ToXml(XmlDocument doc)
        {
            XmlElement research = doc.CreateElement("research");

            //Добавляем имя в XML
            XmlElement name_element = doc.CreateElement("name");
            name_element.AppendChild(doc.CreateTextNode(name));

            //Добавляем контрольные точки
            XmlElement KT_element = doc.CreateElement("KT");
            foreach (CheckPoint cp in CheckPoints)
            {
                KT_element.AppendChild(cp.ToXml(doc));
            }

            //Добавляем изображения
            XmlElement frontViewElement = doc.CreateElement("front_view");
            frontViewElement.AppendChild(doc.CreateTextNode(front_view_path));

            XmlElement sideViewElement = doc.CreateElement("side_view");
            sideViewElement.AppendChild(doc.CreateTextNode(side_view_path));

            //Запихиваем все в корневой элемент
            research.AppendChild(name_element);
            research.AppendChild(KT_element);
            research.AppendChild(frontViewElement);
            research.AppendChild(sideViewElement);

            return research;
        }

        public override string ToString()
        {
            return name;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string FrontViewPath
        {
            get
            {
                return front_view_path;
            }
            set
            {
                front_view_path = value;
            }
        }

        public string SideViewPath
        {
            get
            {
                return side_view_path;
            }
            set
            {
                side_view_path = value;
            }
        }

        private string name;
        private string front_view_path;
        private string side_view_path;
        public ArrayList CheckPoints;
    }
}
