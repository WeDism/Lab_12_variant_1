using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_12_variant_1.OpenOrCreateFile
{
    class ConstructRow
    {
        int? strNumber;
        string strTypeCalculation = "";
        double? strValue;
        public ConstructRow()
        {
        }
        public ConstructRow(int? strNumber, string strTypeCalculation, double? strValue)
            : base()
        {
            this.strNumber = strNumber;
            this.strTypeCalculation = strTypeCalculation;
            this.strValue = strValue;
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
