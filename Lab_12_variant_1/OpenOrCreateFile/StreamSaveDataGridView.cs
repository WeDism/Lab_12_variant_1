using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Lab_12_variant_1.OpenOrCreateFile
{
    class StreamSaveDataGridView
    {
        string data;
        public StreamSaveDataGridView(LinkedList<Triangle> linkedList, string fileFolder)
        {
            data = LinkedListToString(linkedList);
            StreamWriter file = new StreamWriter(fileFolder);
            file.WriteLine(data);
            file.Close();
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
    }
}
