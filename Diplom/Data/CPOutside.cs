using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Text;

namespace Diplom.Data
{
    public class CPOutside : CheckPoint
    {
        public CPOutside(string name)
        {
            Name = name;
        }

        override public XmlElement ToXml(XmlDocument doc)
        {
            XmlElement elementName = doc.CreateElement("name");
            elementName.AppendChild(doc.CreateTextNode(Name));

            XmlElement outside = doc.CreateElement("outside");
            outside.AppendChild(elementName);

            XmlElement signalLevel = doc.CreateElement("signal_level");
            signalLevel.AppendChild(doc.CreateTextNode(SignalLevelIndex.ToString()));
            outside.AppendChild(signalLevel);

            XmlElement noiseType = doc.CreateElement("noise_type");
            noiseType.AppendChild(doc.CreateTextNode(NoiseTypeIndex.ToString()));
            outside.AppendChild(noiseType);

            XmlElement reflectors = doc.CreateElement("reflectors");
            foreach(Reflector r in reflectorsList)
            {
                XmlElement reflector = doc.CreateElement("reflector");
                
                XmlElement reflSquare = doc.CreateElement("square");
                reflSquare.AppendChild(doc.CreateTextNode(r.square.ToString()));
                reflector.AppendChild(reflSquare);

                XmlElement reflMaterial = doc.CreateElement("material");
                reflMaterial.AppendChild(doc.CreateTextNode(r.MaterialIndex.ToString()));
                reflector.AppendChild(reflMaterial);

                reflectors.AppendChild(reflector);
            }
            outside.AppendChild(reflectors);

            XmlElement absorbers = doc.CreateElement("absorbers");
            foreach (Reflector r in absorbersList)
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
            foreach(int index in consumersList)
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

            XmlElement distance = doc.CreateElement("distance");
            distance.AppendChild(doc.CreateTextNode(Distance.ToString()));
            outside.AppendChild(distance);

            XmlElement sound_fading = doc.CreateElement("sound_fading");
            sound_fading.AppendChild(doc.CreateTextNode(SoundFadingIndex.ToString()));
            outside.AppendChild(sound_fading);

            XmlElement angle = doc.CreateElement("angle");
            angle.AppendChild(doc.CreateTextNode(AngleIndex.ToString()));
            outside.AppendChild(angle);

            XmlElement noise_reduction = doc.CreateElement("noise_reduction");
            noise_reduction.AppendChild(doc.CreateTextNode(NoiseReduction.ToString()));
            outside.AppendChild(noise_reduction);

            XmlElement mic = doc.CreateElement("microphone");
            mic.AppendChild(doc.CreateTextNode(Microphone.ToString()));
            outside.AppendChild(mic);

            XmlElement mic_value = doc.CreateElement("mic_value");
            mic_value.AppendChild(doc.CreateTextNode(MicrophoneText.ToString()));
            outside.AppendChild(mic_value);

            outside.AppendChild(Results.ToXml(doc));

            return outside;
        }

        public int SignalLevelIndex { get; set; }
        public int NoiseTypeIndex { get; set; }

        public ArrayList reflectorsList = new ArrayList();
        public ArrayList absorbersList = new ArrayList();
        public ArrayList consumersList = new ArrayList();

        public double Volume { get; set; }
        public int RoomTypeIndex { get; set; }

        public double Distance { get; set; }
        public int SoundFadingIndex { get; set; }

        public int AngleIndex { get; set; }
        public int NoiseReduction { get; set; }
        public int Microphone { get; set; }
        public double MicrophoneText { get; set; }

        public class Reflector
        {
            public double square;
            public int MaterialIndex;
        }
    }
}
