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
        static List<ConstructRow> list = new List<ConstructRow>();
        public StreamOpenDataGridView(string fileFolder)
        {
            list.Clear();
            list = CreateList(fileFolder);
        }
        private List<ConstructRow> CreateList(string fileFolder)
        {
            StreamReader streamReader = new StreamReader(fileFolder);
            string textFromFile = streamReader.ReadToEnd();
            Regex regular = new Regex(@"\d+\t\w+\t *\d+\,*\.*\d*\r\n");
            Match regularSeach = regular.Match(textFromFile);
            int counter = CountRows(textFromFile);
            while (regularSeach.Success)
            {
                string str = regularSeach.Value;
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
                    list.Add(constructRow);
                }
                regularSeach = regularSeach.NextMatch();
            }
            return list;
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
        public List<ConstructRow> ReturnList
        {
            get
            {
                return list;
            }
        }
    }
}
