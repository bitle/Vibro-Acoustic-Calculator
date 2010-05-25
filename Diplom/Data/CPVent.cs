using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Text;

namespace Diplom.Data
{
    public class CPVent : CheckPoint
    {
        public CPVent(string name)
        {
            Name = name;
        }

        override public XmlElement ToXml(XmlDocument doc)
        {
            XmlElement outside = doc.CreateElement("vent");
            XmlElement elementName = doc.CreateElement("name");
            elementName.AppendChild(doc.CreateTextNode(Name));
            outside.AppendChild(elementName);

            XmlElement signalLevel = doc.CreateElement("signal_level");
            signalLevel.AppendChild(doc.CreateTextNode(SignalLevelIndex.ToString()));
            outside.AppendChild(signalLevel);

            XmlElement signalPlace = doc.CreateElement("signal_place");
            signalPlace.AppendChild(doc.CreateTextNode(SignalPlace.ToString()));
            outside.AppendChild(signalPlace);

            XmlElement distance = doc.CreateElement("distance");
            distance.AppendChild(doc.CreateTextNode(Distance.ToString()));
            outside.AppendChild(distance);

            XmlElement noiseType = doc.CreateElement("noise_type");
            noiseType.AppendChild(doc.CreateTextNode(NoiseTypeIndex.ToString()));
            outside.AppendChild(noiseType);

            XmlElement absorbers = doc.CreateElement("absorbers");
            foreach (CPOutside.Reflector r in absorbersList)
            {
                XmlElement absorber = doc.CreateElement("absorber");

                XmlElement absorbSquare = doc.CreateElement("square");
                absorbSquare.AppendChild(doc.CreateTextNode(r.square.ToString()));
                absorber.AppendChild(absorbSquare);

                XmlElement absorbRatio = doc.CreateElement("ratio");
                absorbRatio.AppendChild(doc.CreateTextNode(r.MaterialIndex.ToString()));
                absorber.AppendChild(absorbRatio);

                absorbers.AppendChild(absorber);
            }
            outside.AppendChild(absorbers);

            XmlElement consumers = doc.CreateElement("consumers");
            foreach (int index in consumersList)
            {
                XmlElement consumer = doc.CreateElement("consumer");
                consumer.AppendChild(doc.CreateTextNode(index.ToString()));

                consumers.AppendChild(consumer);
            }
            outside.AppendChild(consumers);

            XmlElement vol = doc.CreateElement("volume");
            vol.AppendChild(doc.CreateTextNode(Volume.ToString()));
            outside.AppendChild(vol);

            XmlElement room_type = doc.CreateElement("room_type");
            room_type.AppendChild(doc.CreateTextNode(RoomTypeIndex.ToString()));
            outside.AppendChild(room_type);

            XmlElement noise_reduction = doc.CreateElement("noise_reduction");
            noise_reduction.AppendChild(doc.CreateTextNode(NoiseReduction.ToString()));
            outside.AppendChild(noise_reduction);

            XmlElement sectors = doc.CreateElement("sectors");
            foreach(FormVent.Sector s in Sectors)
            {
                sectors.AppendChild(s.ToXml(doc));
            }
            outside.AppendChild(sectors);

            outside.AppendChild(Results.ToXml(doc));

            return outside;
        }

        public int SignalLevelIndex { get; set; }
        public int NoiseTypeIndex { get; set; }

        public int SignalPlace { get; set; }
        public double Distance { get; set; }

        public ArrayList absorbersList = new ArrayList();
        public ArrayList consumersList = new ArrayList();

        public double Volume { get; set; }
        public int RoomTypeIndex { get; set; }

        public int NoiseReduction { get; set; }

        public List<FormVent.Sector> Sectors = new List<FormVent.Sector>();
    }
}
