//#define VAR
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Lab_12_variant_1.OpenOrCreateFile;

namespace Lab_12_variant_1
{
    partial class Calc : PerentForm
    {
        bool logic = false;
        int count = linkedListTypesCalculation.Count;
        public Calc()
        {
            InitializeComponent();
            CancelButton = buttonClose;
            if (onlyOne)
            {
                checkBoxViewMyOnlyPastInput.Visible = false;
                if (linkedListTypesCalculation.ElementAt(0).Perimeter != null)
                    dataGridViewTypeCalculated.Rows.Add("Only first", "Perimeter",
                        string.Format("{0,8:0.####}", linkedListTypesCalculation.ElementAt(0).Perimeter));
                if (linkedListTypesCalculation.ElementAt(0).Area != null)
                    dataGridViewTypeCalculated.Rows.Add("Only first", "Area",
                        string.Format("{0,8:0.####}", linkedListTypesCalculation.ElementAt(0).Area));
            }
            else if (addCollection)
            {
                checkBoxViewMyOnlyPastInput.Visible = true;
                AddCollectionLinkedList();
            }
        }

        private void AddCollectionLinkedList()
        {
            for (int i = 0; i < count; i++)
            {
                if (linkedListTypesCalculation.ElementAt(i).Perimeter != null)
                    dataGridViewTypeCalculated.Rows.Add(i + 1, "Perimeter",
                        string.Format("{0,8:0.####}", linkedListTypesCalculation.ElementAt(i).Perimeter));
                if (linkedListTypesCalculation.ElementAt(i).Area != null)
                    dataGridViewTypeCalculated.Rows.Add(i + 1, "Area",
                        string.Format("{0,8:0.####}", linkedListTypesCalculation.ElementAt(i).Area));
            }
        }

        private void Calc_Load(object sender, EventArgs e)
        {
            if (linkedListTypesCalculation.First == null)
            {
                MessageBox.Show("You are not input data");
                logic = true;
            }
            if (logic) this.Dispose();
        }

        private void checkBoxViewMyPastInputOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxViewMyOnlyPastInput.Checked)
            {
                dataGridViewTypeCalculated.Rows.Clear();
                if (linkedListTypesCalculation.ElementAt(count - 1).Perimeter != null)
                    dataGridViewTypeCalculated.Rows.Add("Last element", "Perimeter",
                        string.Format("{0,8:0.####}", linkedListTypesCalculation.ElementAt(count - 1).Perimeter));
                if (linkedListTypesCalculation.ElementAt(count - 1).Area != null)
                    dataGridViewTypeCalculated.Rows.Add("Last element", "Area",
                        string.Format("{0,8:0.####}", linkedListTypesCalculation.ElementAt(count - 1).Area));
            }
            else
            {
                dataGridViewTypeCalculated.Rows.Clear();
                AddCollectionLinkedList();
            }
        }

        private void comboBoxWorkWithExcel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxWorkWithExcel.SelectedItem.ToString() == "Save")
            {
                SaveFileDialog Save = new SaveFileDialog();
                Save.Filter = "txt files (*.txt)|*.txt|xls files (*.xls)|*.xls|All files (*.*)|*.*";
                Save.FilterIndex = 1;
                Save.RestoreDirectory = true;

                if (Save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (Save.FilterIndex == 1)
                        {
                            StreamSaveDataGridView bSDGV =
                                new StreamSaveDataGridView(linkedListTypesCalculation, Save.FileName);
                        }
                        if (Save.FilterIndex == 2)
                        {
                            StreamSaveDataGridView bSDGV =
                                new StreamSaveDataGridView(linkedListTypesCalculation, Save.FileName);
                        }
                        if (Save.FilterIndex == 3)
                        {
                            StreamSaveDataGridView bSDGV =
                                new StreamSaveDataGridView(linkedListTypesCalculation, Save.FileName);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (comboBoxWorkWithExcel.SelectedItem.ToString() == "Open")
            {
#if VAR
                MessageBox.Show("This is function is not realized", "Warning");
#else
                OpenFileDialog Open = new OpenFileDialog();
                Open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                Open.FilterIndex = 1;
                Open.RestoreDirectory = true;

                if (Open.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StreamOpenDataGridView SODGV = new StreamOpenDataGridView(Open.FileName);
                        AddCollectionList(SODGV);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
#endif
            }
        }
        private void AddCollectionList(StreamOpenDataGridView _object)
        {
            dataGridViewTypeCalculated.Rows.Clear();
            List<ConstructRow> list = _object.ReturnList;
            int counter = list.Count;
            for (int i = 0; i < counter; i++)
            {
                if ((list.ElementAt(i).StrNumber != null) &&
                    (list.ElementAt(i).StrTypeCalculation != null) &&
                    (list.ElementAt(i).StrValue != null))
                    dataGridViewTypeCalculated.Rows.Add(list.ElementAt(i).StrNumber,
                        list.ElementAt(i).StrTypeCalculation,
                        string.Format("{0,8:0.####}", list.ElementAt(i).StrValue));
            }
        }
    }
}
