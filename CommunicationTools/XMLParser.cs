using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CommunicationTools
{
    public class XMLParser
    {
        public string CreatePublicKeyXml(string path, string publicKey)
        {
            XmlWriter writer = XmlWriter.Create(path + "/clavepublica.xml");
            writer.WriteStartDocument();
            writer.WriteElementString("clavepublica", publicKey);
            writer.WriteEndDocument();
            writer.Flush();
            return writer.ToString();
        }
        public string CreateTDESXml(string path, string[] tdes)
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
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            return writer.ToString();
        }
        public string CreateMessageXml(string path, string message)
        {
            XmlWriter writer = XmlWriter.Create(path + "/textoencriptado.xml");
            writer.WriteStartDocument();
            writer.WriteStartElement("root");
            writer.WriteElementString("textoe", message);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            return writer.ToString();
        }
        public string ReadXml(string path, string nodeToRead)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode node = doc.DocumentElement.SelectSingleNode(nodeToRead);
            return node.InnerText;
        }
    }
}
