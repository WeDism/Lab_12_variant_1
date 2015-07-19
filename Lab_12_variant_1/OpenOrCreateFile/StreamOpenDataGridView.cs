using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab_12_variant_1.OpenOrCreateFile
{
    class StreamOpenDataGridView
    {
        static List<ConstructRow> ListStreamOpen = new List<ConstructRow>();
        static LinkedList<Triangle> Triangles = new LinkedList<Triangle>();
        Match regularSeach;
        public StreamOpenDataGridView(string fileFolder)
        {
            ListStreamOpen.Clear();
            ListStreamOpen = CreateList(fileFolder);
            Triangles = TriangleTransform(ListStreamOpen);
        }
        private List<ConstructRow> CreateList(string fileFolder)
        {
            StreamReader streamReader = new StreamReader(fileFolder);
            string textFromFile = streamReader.ReadToEnd();
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
        private void CheckTriangleTransform(List<ConstructRow> ListStreamOpen)
        {
            int length = ListStreamOpen.Count;
            for (int i = 0; i < length - 1; i++)
            {
                int counterNumbers = 0;
                for (int j = i + 1; j < length; j++)
                {
                    if (ListStreamOpen.ElementAt(i) == ListStreamOpen.ElementAt(j))
                    {
                        counterNumbers++;
                    }
                }
                if (counterNumbers > 1)
                    throw new FormatException();
            }
        }
        private LinkedList<Triangle> TriangleTransform(List<ConstructRow> ListStreamOpen)
        {
            CheckTriangleTransform(ListStreamOpen);
            int length = ListStreamOpen.Count;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (ListStreamOpen.ElementAt(i) == ListStreamOpen.ElementAt(j))
                    {
                        Triangle triangle = new Triangle();
                        triangle.Area = ListStreamOpen.ElementAt(i).StrTypeCalculation.Equals("Area") ?
                            ListStreamOpen.ElementAt(i).StrValue : null;
                        triangle.Perimeter = ListStreamOpen.ElementAt(j).StrTypeCalculation.Equals("Perimeter") ?
                            ListStreamOpen.ElementAt(j).StrValue : null;
                        Triangles.AddLast(triangle);
                    }
                }
            }
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
