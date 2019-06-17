using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace CommunicationTools
{
    public static class XmlParser
    {
        public static string CreatePublicKeyXml(string path, string publicKey)
        {
            XmlWriter writer = XmlWriter.Create(path + "/cp_esclavo.xml");
            writer.WriteStartDocument();
            writer.WriteStartElement("root");
            writer.WriteElementString("clavepublica", publicKey);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            string content = writer.ToString();
            writer.Dispose();
            return content;
        }
        public static string CreateTdesXml(string path, string[] tdes, string iv)
        {
            XmlWriter writer = XmlWriter.Create(path + "/tdesencriptado.xml");
            writer.WriteStartDocument();
            writer.WriteStartElement("root");
            int count = 0;
            foreach (string des in tdes)
            {
                count++;
                writer.WriteElementString("tdes" + count, des);
            }
            writer.WriteElementString("iv", iv);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            string content = writer.ToString();
            writer.Dispose();
            return content;
        }
        public static string CreateMessageXml(string path, string message)
        {
            XmlWriter writer = XmlWriter.Create(path + "/textoencriptado.xml");
            writer.WriteStartDocument();
            writer.WriteStartElement("root");
            writer.WriteElementString("textoe", message);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            string content = writer.ToString();
            writer.Dispose();
            return content;
        }
        public static string ReadXmlGeneric(string path, string nodeToRead)
        {
            string nodeText = "";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/"+ nodeToRead);
            foreach (XmlNode node in nodes)
            {
                nodeText = node.InnerText;
            }
            return doc.SelectSingleNode("root").SelectSingleNode(nodeToRead).InnerText;
        }
        public static string[] ReadXmlTdes(string path)
        {
            IList<string> tdesList = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            tdesList.Add(doc.SelectSingleNode("root").SelectSingleNode("tdes1").InnerText);
            tdesList.Add(doc.SelectSingleNode("root").SelectSingleNode("tdes2").InnerText);
            tdesList.Add(doc.SelectSingleNode("root").SelectSingleNode("tdes3").InnerText);
            tdesList.Add(doc.SelectSingleNode("root").SelectSingleNode("iv").InnerText);
            return tdesList.ToArray();
        }
    }
}
