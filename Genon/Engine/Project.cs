using System;
using System.IO;
using System.Xml;

namespace Engine
{
    class Project
    {
        public Schema Schema { get; private set; }

        public long RowsToCreate { get; set; }

        public Project()
        {
            Schema = new Schema();
        }

        public Project Load(Stream stream)
        {
            throw new NotImplementedException();
        }

        public void Save(Stream stream)
        {
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
            xmlWriterSettings.WriteEndDocumentOnClose = true;

            using (XmlWriter xw = XmlWriter.Create(stream, xmlWriterSettings))
            {
                xw.WriteStartDocument();
                xw.WriteStartElement("Project");

                xw.WriteStartElement("General");
                xw.WriteAttributeString("RowsToCreate", RowsToCreate.ToString());
                xw.WriteEndElement();

                xw.WriteStartElement("Schema");
                xw.WriteRaw(Schema.SerializeAsXml());
                xw.WriteEndElement();

                xw.WriteEndElement();
                xw.WriteEndDocument();
            }
        }
    }
}
