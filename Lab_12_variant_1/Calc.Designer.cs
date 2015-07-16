namespace Lab_12_variant_1
{
    partial class Calc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxViewMyOnlyPastInput = new System.Windows.Forms.CheckBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridViewTypeCalculated = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTypeCalculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxWorkWithExcel = new System.Windows.Forms.ComboBox();
            this.groupBoxExportToExcel = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypeCalculated)).BeginInit();
            this.groupBoxExportToExcel.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxViewMyOnlyPastInput
            // 
            this.checkBoxViewMyOnlyPastInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxViewMyOnlyPastInput.AutoSize = true;
            this.checkBoxViewMyOnlyPastInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxViewMyOnlyPastInput.Location = new System.Drawing.Point(12, 360);
            this.checkBoxViewMyOnlyPastInput.Name = "checkBoxViewMyOnlyPastInput";
            this.checkBoxViewMyOnlyPastInput.Size = new System.Drawing.Size(207, 24);
            this.checkBoxViewMyOnlyPastInput.TabIndex = 13;
            this.checkBoxViewMyOnlyPastInput.Text = "View only my past input";
            this.checkBoxViewMyOnlyPastInput.UseVisualStyleBackColor = true;
            this.checkBoxViewMyOnlyPastInput.CheckedChanged += new System.EventHandler(this.checkBoxViewMyPastInputOnly_CheckedChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(424, 353);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(88, 34);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTypeCalculated
            // 
            this.dataGridViewTypeCalculated.AllowUserToAddRows = false;
            this.dataGridViewTypeCalculated.AllowUserToDeleteRows = false;
            this.dataGridViewTypeCalculated.AllowUserToResizeColumns = false;
            this.dataGridViewTypeCalculated.AllowUserToResizeRows = false;
            this.dataGridViewTypeCalculated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTypeCalculated.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridViewTypeCalculated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTypeCalculated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTypeCalculated.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnTypeCalculation,
            this.ColumnValue});
            this.dataGridViewTypeCalculated.Location = new System.Drawing.Point(-4, -2);
            this.dataGridViewTypeCalculated.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewTypeCalculated.Name = "dataGridViewTypeCalculated";
            this.dataGridViewTypeCalculated.ReadOnly = true;
            this.dataGridViewTypeCalculated.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTypeCalculated.RowTemplate.Height = 24;
            this.dataGridViewTypeCalculated.Size = new System.Drawing.Size(530, 337);
            this.dataGridViewTypeCalculated.TabIndex = 0;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.HeaderText = "№";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            this.ColumnNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnNumber.Width = 130;
            // 
            // ColumnTypeCalculation
            // 
            this.ColumnTypeCalculation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnTypeCalculation.HeaderText = "Type Calculation";
            this.ColumnTypeCalculation.Name = "ColumnTypeCalculation";
            this.ColumnTypeCalculation.ReadOnly = true;
            this.ColumnTypeCalculation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnTypeCalculation.Width = 182;
            // 
            // ColumnValue
            // 
            this.ColumnValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnValue.HeaderText = "Value";
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.ReadOnly = true;
            this.ColumnValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // comboBoxWorkWithExcel
            // 
            this.comboBoxWorkWithExcel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorkWithExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxWorkWithExcel.FormattingEnabled = true;
            this.comboBoxWorkWithExcel.Items.AddRange(new object[] {
            "Save",
            "Open"});
            this.comboBoxWorkWithExcel.Location = new System.Drawing.Point(6, 22);
            this.comboBoxWorkWithExcel.Name = "comboBoxWorkWithExcel";
            this.comboBoxWorkWithExcel.Size = new System.Drawing.Size(187, 26);
            this.comboBoxWorkWithExcel.TabIndex = 16;
            this.comboBoxWorkWithExcel.SelectedIndexChanged += new System.EventHandler(this.comboBoxWorkWithExcel_SelectedIndexChanged);
            // 
            // groupBoxExportToExcel
            // 
            this.groupBoxExportToExcel.Controls.Add(this.comboBoxWorkWithExcel);
            this.groupBoxExportToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxExportToExcel.Location = new System.Drawing.Point(218, 337);
            this.groupBoxExportToExcel.Name = "groupBoxExportToExcel";
            this.groupBoxExportToExcel.Size = new System.Drawing.Size(200, 56);
            this.groupBoxExportToExcel.TabIndex = 17;
            this.groupBoxExportToExcel.TabStop = false;
            this.groupBoxExportToExcel.Text = "Save or Open";
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 399);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxExportToExcel);
            this.Controls.Add(this.checkBoxViewMyOnlyPastInput);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridViewTypeCalculated);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calc";
            this.Load += new System.EventHandler(this.Calc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypeCalculated)).EndInit();
            this.groupBoxExportToExcel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTypeCalculated;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.CheckBox checkBoxViewMyOnlyPastInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTypeCalculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;
        private System.Windows.Forms.ComboBox comboBoxWorkWithExcel;
        private System.Windows.Forms.GroupBox groupBoxExportToExcel;
    }
}