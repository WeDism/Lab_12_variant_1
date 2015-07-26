using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Lab_12_variant_1.OpenOrCreateFile
{
    class StreamSaveDataGridView
    {
        string data;
        public enum SaveAs
        {
            None, txt, xls, xml
        }
        public StreamSaveDataGridView(LinkedList<Triangle> linkedList, string fileFolder, SaveAs saveAs)
        {
            if (saveAs.Equals(SaveAs.txt) || saveAs.Equals(SaveAs.xls) || saveAs.Equals(SaveAs.None))
            {
                data = LinkedListToString(linkedList);
                StreamWriter file = new StreamWriter(fileFolder);
                file.WriteLine(data);
                file.Close();
            }
            else if (saveAs.Equals(SaveAs.xml))
                LinkedListToXml(linkedList, fileFolder);
            else throw new ArgumentException();
        }
        private string LinkedListToString(LinkedList<Triangle> linkedList)
        {
            StringBuilder stringBuilder = new StringBuilder("Number\tType_Calculation\tValue\r\n");
            for (int i = 0; i < linkedList.Count; i++)
            {
                if (linkedList.ElementAt(i).Perimeter != null)
                {
                    stringBuilder.Append(i + 1 + "\t" + "Perimeter\t" + string.Format("{0,8:0.####}",
                        linkedList.ElementAt(i).Perimeter) + "\r\n");
                }
                if (linkedList.ElementAt(i).Area != null)
                {
                    stringBuilder.Append(i + 1 + "\t" + "Area\t" + string.Format("{0,8:0.####}",
                        linkedList.ElementAt(i).Area) + "\r\n");
                }
            }
            return stringBuilder.ToString();
        }
        private void LinkedListToXml(LinkedList<Triangle> linkedList, string fileFolder)
        {
            var xmlWriter = new XmlTextWriter(fileFolder, null);
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("ListOfTriangles");
            for (int i = 0; i < linkedList.Count; i++)
            {
                xmlWriter.WriteStartElement("Triangle");
                if ((linkedList.ElementAt(i).Area != null) || (linkedList.ElementAt(i).Perimeter != null))
                {
                    xmlWriter.WriteStartElement("Number");
                    xmlWriter.WriteString((i + 1).ToString());
                    xmlWriter.WriteEndElement();
                }
                if (linkedList.ElementAt(i).Area != null)
                {
                    xmlWriter.WriteStartElement("Area");
                    xmlWriter.WriteString(string.Format("{0,8:0.####}", linkedList.ElementAt(i).Area));
                    xmlWriter.WriteEndElement();
                }
                if (linkedList.ElementAt(i).Perimeter != null)
                {
                    xmlWriter.WriteStartElement("Perimeter");
                    xmlWriter.WriteString(string.Format("{0,8:0.####}", linkedList.ElementAt(i).Perimeter));
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
            }
            xmlWriter.Close();
        }
    }
}
