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
        public enum SaveAs
        {
            None, txt, xml, html
        }
        public StreamSaveDataGridView(LinkedList<Triangle> linkedList, string fileFolder, SaveAs saveAs)
        {
            if (saveAs.Equals(SaveAs.txt) || saveAs.Equals(SaveAs.None))
                LinkedListToString(linkedList, fileFolder);

            else if (saveAs.Equals(SaveAs.xml))
                LinkedListToXml(linkedList, fileFolder);

            else if (saveAs.Equals(SaveAs.html))
                LinkedListToHtml(linkedList, fileFolder);

            else throw new ArgumentException();
        }
        private void LinkedListToString(LinkedList<Triangle> linkedList, string fileFolder)
        {
            StreamWriter file = new StreamWriter(fileFolder);
            StringBuilder stringBuilder = new StringBuilder("Number\tType_Calculation\tValue\r\n");
            for (int i = 0; i < linkedList.Count; i++)
            {
                if (linkedList.ElementAt(i).Area != null)
                {
                    stringBuilder.Append(i + 1 + "\tArea\t" + string.Format("{0,8:0.####}",
                        linkedList.ElementAt(i).Area).Trim() + "\r\n");
                }
                if (linkedList.ElementAt(i).Perimeter != null)
                {
                    stringBuilder.Append(i + 1 + "\tPerimeter\t" + string.Format("{0,8:0.####}",
                        linkedList.ElementAt(i).Perimeter).Trim() + "\r\n");
                }
            }
            file.WriteLine(stringBuilder.ToString());
            file.Close();
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
                    xmlWriter.WriteString(string.Format("{0,8:0.####}", linkedList.ElementAt(i).Area).Trim());
                    xmlWriter.WriteEndElement();
                }
                if (linkedList.ElementAt(i).Perimeter != null)
                {
                    xmlWriter.WriteStartElement("Perimeter");
                    xmlWriter.WriteString(string.Format("{0,8:0.####}", linkedList.ElementAt(i).Perimeter).Trim());
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
            }
            xmlWriter.Close();
        }
        private void LinkedListToHtml(LinkedList<Triangle> linkedList, string fileFolder)
        {
            StreamWriter file = new StreamWriter(fileFolder);
            StringBuilder stringBuilder = new StringBuilder
                (@"<html><head><title>Report</title></head><body><table border = 1><tr><td>Number<td>Type_Calculation<td>Value</tr>");
            for (int i = 0; i < linkedList.Count; i++)
            {
                if (linkedList.ElementAt(i).Area != null)
                {
                    stringBuilder.Append("<tr><td>" + (i + 1) + "<td>Area<td>" + string.Format("{0,8:#.####}",
                        linkedList.ElementAt(i).Area).Trim() + "</tr>");
                }
                if (linkedList.ElementAt(i).Perimeter != null)
                {
                    stringBuilder.Append("<tr><td>" + (i + 1) + "<td>Perimeter<td>" + string.Format("{0,8:#.####}",
                        linkedList.ElementAt(i).Perimeter).Trim() + "</tr>");
                }
            }
            stringBuilder.Append("</table></body></html>");
            file.WriteLine(stringBuilder.ToString());
            file.Close();
        }
    }
}
