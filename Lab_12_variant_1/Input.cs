using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_12_variant_1
{
    partial class Input : PerentForm
    {

        public Input()
        {
            InitializeComponent();
            AcceptButton = buttonOK;
            CancelButton = buttonCancel;
            numericUpDownA.Value = (decimal)a;
            numericUpDownB.Value = (decimal)b;
            numericUpDownC.Value = (decimal)c;
            checkBoxPerimeter.Checked = perimeter;
            checkBoxArea.Checked = area;
            radioButtonAddCollection.Checked = addCollection;
            radioButtonOnlyFirst.Checked = onlyOne;
            checkBoxTest.Checked = test;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            bool isClose = false;
            bool isMessage = true;
            Triangle iTriangle = null;
            bool av = numericUpDownA.Value != 0m;
            bool bv = numericUpDownB.Value != 0m;
            bool cv = numericUpDownC.Value != 0m;
            bool cp = checkBoxPerimeter.Checked;
            bool ca = checkBoxArea.Checked;
            bool ra = radioButtonAddCollection.Checked;
            bool ro = radioButtonOnlyFirst.Checked;

            if (((av)
                && (bv)
                && (cv))
                && ((cp)
                || (ca))
                && ((ra)
                || (ro)))
            {
                isClose = true;
                iTriangle = new Triangle((double)numericUpDownA.Value,
                            (double)numericUpDownB.Value, (double)numericUpDownC.Value);
            }
            else
            {
                DialogResult result = MessageBox.Show("You are not input minimum data");
                isClose = false;
            }

            if (checkBoxPerimeter.Checked && isClose)
            {
                try
                {
                    iTriangle.CalculatePerimeter();
                    a = (double)numericUpDownA.Value;
                    b = (double)numericUpDownB.Value;
                    c = (double)numericUpDownC.Value;
                }
                catch (ArgumentException)
                {
                    isMessage = false;
                    MessageBox.Show("Figure is not triangle!");
                    checkBoxPerimeter.Checked = false;
                    isClose = false;
                }
            }
            else if(iTriangle!=null) iTriangle.Perimeter = null;
            if (checkBoxArea.Checked && isClose)
            {
                try
                {
                    iTriangle.CalculateArea();
                    a = (double)numericUpDownA.Value;
                    b = (double)numericUpDownB.Value;
                    c = (double)numericUpDownC.Value;
                }
                catch (ArgumentException)
                {
                    if (isMessage)
                    {
                        MessageBox.Show("Figure is not triangle!");
                        isClose = false;
                    }
                    checkBoxArea.Checked = false;
                }
            }
            else if (iTriangle != null) iTriangle.Area = null;

            if (radioButtonOnlyFirst.Checked && isClose)
            {
                linkedListTypesCalculation.Clear();
                linkedListTypesCalculation.AddFirst(iTriangle);
            }

            if (radioButtonAddCollection.Checked && isClose)
            {
                linkedListTypesCalculation.AddLast(iTriangle);
                iTriangle = null;
            }

            onlyOne = radioButtonOnlyFirst.Checked;
            addCollection = radioButtonAddCollection.Checked;
            perimeter = checkBoxPerimeter.Checked;
            area = checkBoxArea.Checked;
            test = checkBoxTest.Checked;

            if (isClose) this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            bool logic = true;
            if ((numericUpDownA.Value == 0m) && (numericUpDownB.Value == 0m) &&
                (numericUpDownC.Value == 0m) && (checkBoxPerimeter.Checked) &&
                (checkBoxArea.Checked) && (radioButtonAddCollection.Checked) &&
                (radioButtonOnlyFirst.Checked))
            {
                MessageBox.Show("You are not input data");
                logic = false;
            }
            if (logic)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Clear all?", "Clearing", buttons);
                if (result == DialogResult.Yes)
                {
                    numericUpDownA.Value = 0m;
                    numericUpDownB.Value = 0m;
                    numericUpDownC.Value = 0m;
                    a = 0;
                    b = 0;
                    c = 0;
                    checkBoxPerimeter.Checked = false;
                    checkBoxArea.Checked = false;
                    radioButtonAddCollection.Checked = false;
                    radioButtonOnlyFirst.Checked = false;
                }
            }
        }

        private void checkBoxTest_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTest.Checked)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                numericUpDownA.Value = 6m;
                numericUpDownB.Value = 7m;
                numericUpDownC.Value = 8m;
                checkBoxPerimeter.Checked = true;
                checkBoxArea.Checked = true;
                radioButtonAddCollection.Checked = true;
                radioButtonOnlyFirst.Checked = false;
                buttonClear.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                numericUpDownA.Value = (decimal)a;
                numericUpDownB.Value = (decimal)b;
                numericUpDownC.Value = (decimal)c;
                checkBoxPerimeter.Checked = perimeter;
                checkBoxArea.Checked = area;
                radioButtonAddCollection.Checked = addCollection;
                radioButtonOnlyFirst.Checked = onlyOne;
                buttonClear.Enabled = true;
            }
        }
    }
}
