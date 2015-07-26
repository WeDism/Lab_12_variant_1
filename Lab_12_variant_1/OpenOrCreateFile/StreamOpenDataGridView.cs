using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;

namespace Lab_12_variant_1.OpenOrCreateFile
{
    class StreamOpenDataGridView
    {
        static List<ConstructRow> ListStreamOpen = new List<ConstructRow>();
        static LinkedList<Triangle> Triangles = new LinkedList<Triangle>();
        Match regularSeach;
        public enum OpenAs
        {
            None, txt, xml
        }
        public StreamOpenDataGridView(string fileFolder, OpenAs openAs)
        {
            if (openAs.Equals(OpenAs.None) || openAs.Equals(OpenAs.txt))
            {
                ListStreamOpen.Clear();
                ListStreamOpen = CreateList(fileFolder);
                Triangles = TriangleTransform(ListStreamOpen);
            }
            else if (openAs.Equals(OpenAs.xml))
                Triangles = TriangleTransform(fileFolder);
            else throw new ArgumentException();

        }
        private List<ConstructRow> CreateList(string fileFolder)
        {
            StreamReader streamReader = new StreamReader(fileFolder);
            string textFromFile = streamReader.ReadToEnd();
            streamReader.Close();
            Regex regular = new Regex(@"\d+\t(Area)*(Perimeter)*\t *\d+\,*\.*\d*\r\n");
            regularSeach = regular.Match(textFromFile);
            int counter = CountRows(textFromFile);
            while (regularSeach.Success)
            {
                DisasembleRegularSeach(regularSeach.Value);
            }
            ConstructRow constrictRow = new ConstructRow();
            ListStreamOpen.Sort(constrictRow);
            return ListStreamOpen;
        }
        private int CountRows(string stringText)
        {
            Regex regularOnlyOne = new Regex("(Number\tType_Calculation\tValue\r\n){1}");
            Regex regularRN = new Regex("\r\n");
            Match textRNSeach = regularRN.Match(stringText);
            int counter = 0;
            if (regularOnlyOne.IsMatch(stringText))
            {
                while (textRNSeach.Success)
                {
                    ++counter;
                    textRNSeach = textRNSeach.NextMatch();
                }
            }
            else throw new FormatException();
            return counter;
        }
        private void DisasembleRegularSeach(string str)
        {
            Regex regularString = new Regex(@"Area|Perimeter|\d+\,*\.*\d*");
            Match regularSeachString = regularString.Match(str);
            ConstructRow constructRow = new ConstructRow();
            bool first = true;
            bool second = false;
            while (regularSeachString.Success)
            {
                if (first)
                {
                    constructRow.StrNumber = int.Parse(regularSeachString.Value);
                    first = false;
                    second = true;
                    regularSeachString = regularSeachString.NextMatch();
                }
                if (second)
                {
                    constructRow.StrTypeCalculation = regularSeachString.Value;
                    first = false;
                    second = false;
                    regularSeachString = regularSeachString.NextMatch();
                }
                if (!first && !second)
                {
                    constructRow.StrValue = double.Parse(regularSeachString.Value);
                    regularSeachString = regularSeachString.NextMatch();
                }
                ListStreamOpen.Add(constructRow);
            }
            regularSeach = regularSeach.NextMatch();
        }
        private List<List<int>> CheckTriangleTransform(List<ConstructRow> ListStreamOpen)
        {
            int length = ListStreamOpen.Count;
            List<List<int>> strNumbers = new List<List<int>>();
            int index = 0;
            for (int i = 0; i < length - 1; i++)
            {
                int counterNumbers = 0;
                strNumbers.Add(new List<int>());
                for (int j = i + 1; j < length; j++)
                {
                    if (ListStreamOpen.ElementAt(i) == ListStreamOpen.ElementAt(j))
                    {
                        counterNumbers++;
                        strNumbers[index].Add(i);
                        strNumbers[index].Add(j);
                    }
                    else
                    {
                        //bool first = !(strNumbers[index].Contains(i) && strNumbers[index].Contains(j));
                        //bool second = !strNumbers[index].Contains(i);
                        if (!(strNumbers[index].Contains(i) && strNumbers[index].Contains(j)) && !strNumbers[index].Contains(i))
                        {
                            strNumbers[index].Add(i);
                            strNumbers[index].Add(i);
                        }
                    }
                }
                if (counterNumbers > 1)
                    throw new FormatException();
                index++;
            }
            return strNumbers;
        }
        private LinkedList<Triangle> TriangleTransform(List<ConstructRow> ListStreamOpen)
        {
            List<List<int>> strNumbers = CheckTriangleTransform(ListStreamOpen);
            int length = strNumbers.Count;
            for (int i = 0; i < length; i++)
            {
                Triangle triangle = new Triangle();
                if (strNumbers[i][0] != strNumbers[i][1])
                {
                    triangle.Area = ListStreamOpen.ElementAt(strNumbers[i][0]).StrTypeCalculation.Equals("Area") ?
                        ListStreamOpen.ElementAt(strNumbers[i][0]).StrValue : null;
                    triangle.Perimeter = ListStreamOpen.ElementAt(strNumbers[i][1]).StrTypeCalculation.Equals("Perimeter") ?
                        ListStreamOpen.ElementAt(strNumbers[i][1]).StrValue : null;
                    if (!ListStreamOpen.ElementAt(strNumbers[i][0]).StrTypeCalculation.Equals("Area"))
                        triangle.Perimeter = ListStreamOpen.ElementAt(strNumbers[i][0]).StrTypeCalculation.Equals("Perimeter") ?
                            ListStreamOpen.ElementAt(strNumbers[i][0]).StrValue : null;
                    if (!ListStreamOpen.ElementAt(strNumbers[i][1]).StrTypeCalculation.Equals("Perimeter"))
                        triangle.Perimeter = ListStreamOpen.ElementAt(strNumbers[i][1]).StrTypeCalculation.Equals("Area") ?
                            ListStreamOpen.ElementAt(strNumbers[i][1]).StrValue : null;
                    Triangles.AddLast(triangle);
                }
                else
                {
                    triangle.Area = ListStreamOpen.ElementAt(i).StrTypeCalculation.Equals("Area") ?
                          ListStreamOpen.ElementAt(i).StrValue : null;
                    triangle.Perimeter = ListStreamOpen.ElementAt(i).StrTypeCalculation.Equals("Perimeter") ?
                        ListStreamOpen.ElementAt(i).StrValue : null;
                    Triangles.AddLast(triangle);
                }
            }
            return Triangles;
        }
        private LinkedList<Triangle> TriangleTransform(string fileFolder)
        {
            StreamReader stream = new StreamReader(fileFolder);
            XmlReader xmlReader = new XmlTextReader(stream);
            while (xmlReader.Read())
            {
                if (xmlReader.Name == "Triangle")
                {
                    Triangle triangle = new Triangle();
                    xmlReader.Read();
                    xmlReader.Read();
                    xmlReader.Read();
                    xmlReader.Read();
                    if (xmlReader.Name == "Area")
                    {
                        triangle.Area = double.Parse(xmlReader.ReadElementString());
                    }
                    if (xmlReader.Name == "Perimeter")
                    {
                        triangle.Perimeter = double.Parse(xmlReader.ReadElementString());
                    }
                    Triangles.AddLast(triangle);
                }
            }
            xmlReader.Close();
            return Triangles;
        }
        public List<ConstructRow> ReturnLinkedListStreamOpen
        {
            get
            {
                return ListStreamOpen;
            }
        }
        public LinkedList<Triangle> ReturnTriangles
        {
            get
            {
                return Triangles;
            }
        }
    }
}
