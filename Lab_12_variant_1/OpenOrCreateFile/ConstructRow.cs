using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_12_variant_1.OpenOrCreateFile
{
    class ConstructRow : IComparer<ConstructRow>, IComparable<ConstructRow>
    {
        int? strNumber;
        string strTypeCalculation = "";
        double? strValue;
        public ConstructRow() { }
        public ConstructRow(int? strNumber, string strTypeCalculation, double? strValue)
            : base()
        {
            this.strNumber = strNumber;
            this.strTypeCalculation = strTypeCalculation;
            this.strValue = strValue;
        }
        public int Compare(ConstructRow first, ConstructRow second)
        {
            if (first.strNumber > second.strNumber) return 1;
            if (first.strNumber < second.strNumber) return -1;
            if (first.strNumber == second.strNumber)
            {
                if (first.strTypeCalculation.Length > second.strTypeCalculation.Length) return 1;
                if (first.strTypeCalculation.Length < second.strTypeCalculation.Length) return -1;
            }
            return 0;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            ConstructRow constructRow = (ConstructRow)obj;
            return strNumber == constructRow.strNumber &&
                strTypeCalculation != constructRow.strTypeCalculation;
        }
        public override int GetHashCode()
        {
            return strNumber.GetHashCode();
        }
        public static bool operator ==(ConstructRow first, ConstructRow second)
        {
            return first.Equals(second);
        }
        public static bool operator !=(ConstructRow first, ConstructRow second)
        {
            return !first.Equals(second);
        }
        public int CompareTo(ConstructRow constructRow)
        {
            if (strTypeCalculation.Length > constructRow.strTypeCalculation.Length) return 1;
            if (strTypeCalculation.Length < constructRow.strTypeCalculation.Length) return -1;
            return 0;
        }
        public int? StrNumber
        {
            get
            {
                return strNumber;
            }
            set
            {
                strNumber = value;
            }
        }
        public string StrTypeCalculation
        {
            get
            {
                return strTypeCalculation;
            }
            set
            {
                strTypeCalculation = value;
            }
        }
        public double? StrValue
        {
            get
            {
                return strValue;
            }
            set
            {
                strValue = value;
            }
        }
    }
}
