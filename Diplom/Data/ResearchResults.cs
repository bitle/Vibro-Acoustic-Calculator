using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;

namespace Diplom.Data
{
    public class ResearchResults
    {
        public double[] SoundproofLefel = new double[7];
        public double[] Ratio = new double[7];
        public double[] SignalLevel = new double[7];
        public double[] NoiseLevel = new double[7];
        public double W { get; set; }

        public XmlElement ToXml(XmlDocument doc)
        {
            XmlElement results = doc.CreateElement("results");

            foreach (double d in SoundproofLefel)
            {
                XmlElement spl = doc.CreateElement("sound_proof");
                spl.AppendChild(doc.CreateTextNode(d.ToString()));
                results.AppendChild(spl);
            }

            foreach (double d in Ratio)
            {
                XmlElement ratio = doc.CreateElement("ratio");
                ratio.AppendChild(doc.CreateTextNode(d.ToString()));
                results.AppendChild(ratio);
            }

            foreach (double d in SignalLevel)
            {
                XmlElement signal_level = doc.CreateElement("signal_level");
                signal_level.AppendChild(doc.CreateTextNode(d.ToString()));
                results.AppendChild(signal_level);
            }

            if (NoiseLevel != null)
            {
                foreach (double d in NoiseLevel)
                {
                    XmlElement noise_level = doc.CreateElement("noise_level");
                    noise_level.AppendChild(doc.CreateTextNode(d.ToString()));
                    results.AppendChild(noise_level);
                }
            }

            XmlElement w = doc.CreateElement("w");
            w.AppendChild(doc.CreateTextNode(W.ToString()));
            results.AppendChild(w);

            return results;
        }

        public static ResearchResults FromXml(XmlNode node)
        {
            ResearchResults rr = new ResearchResults();

            if (node == null)
                return rr;

            int i = 0;
            int j = 0;
            int k = 0;
            int l = 0;
            foreach (XmlNode result_node in node.ChildNodes)
            {
                try
                {
                    switch (result_node.Name)
                    {
                        case "sound_proof":
                            rr.SoundproofLefel[i++] = Double.Parse(result_node.FirstChild.Value);
                            break;
                        case "ratio":
                            rr.Ratio[j++] = Double.Parse(result_node.FirstChild.Value);
                            break;
                        case "w":
                            rr.W = Double.Parse(result_node.FirstChild.Value);
                            break;
                        case "signal_level":
                            rr.SignalLevel[k++] = Double.Parse(result_node.FirstChild.Value);
                            break;
                        case "noise_level":
                            rr.NoiseLevel[l++] = Double.Parse(result_node.FirstChild.Value);
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Can't read Result Node");
                }
            }

            return rr;
        }
    }
}
