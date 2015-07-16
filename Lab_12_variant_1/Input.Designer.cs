namespace Lab_12_variant_1
{
    partial class Input
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
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.checkBoxPerimeter = new System.Windows.Forms.CheckBox();
            this.checkBoxArea = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownC = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonAddCollection = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlyFirst = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(12, 29);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(71, 24);
            this.labelA.TabIndex = 3;
            this.labelA.Text = "Side A:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(12, 80);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(70, 24);
            this.labelB.TabIndex = 4;
            this.labelB.Text = "Side B:";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelC.Location = new System.Drawing.Point(12, 131);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(71, 24);
            this.labelC.TabIndex = 5;
            this.labelC.Text = "Side C:";
            // 
            // checkBoxPerimeter
            // 
            this.checkBoxPerimeter.AutoSize = true;
            this.checkBoxPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPerimeter.Location = new System.Drawing.Point(6, 26);
            this.checkBoxPerimeter.Name = "checkBoxPerimeter";
            this.checkBoxPerimeter.Size = new System.Drawing.Size(104, 24);
            this.checkBoxPerimeter.TabIndex = 7;
            this.checkBoxPerimeter.Text = "Perimeter";
            this.checkBoxPerimeter.UseVisualStyleBackColor = true;
            // 
            // checkBoxArea
            // 
            this.checkBoxArea.AutoSize = true;
            this.checkBoxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxArea.Location = new System.Drawing.Point(174, 25);
            this.checkBoxArea.Name = "checkBoxArea";
            this.checkBoxArea.Size = new System.Drawing.Size(66, 24);
            this.checkBoxArea.TabIndex = 8;
            this.checkBoxArea.Text = "Area";
            this.checkBoxArea.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(12, 306);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(92, 34);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(227, 306);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 34);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxPerimeter);
            this.groupBox1.Controls.Add(this.checkBoxArea);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(68, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 55);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type calculation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownC);
            this.groupBox2.Controls.Add(this.numericUpDownB);
            this.groupBox2.Controls.Add(this.numericUpDownA);
            this.groupBox2.Controls.Add(this.labelC);
            this.groupBox2.Controls.Add(this.labelA);
            this.groupBox2.Controls.Add(this.labelB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 171);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input value the sides length triangle";
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownC.Hexadecimal = true;
            this.numericUpDownC.InterceptArrowKeys = false;
            this.numericUpDownC.Location = new System.Drawing.Point(98, 132);
            this.numericUpDownC.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.Size = new System.Drawing.Size(201, 24);
            this.numericUpDownC.TabIndex = 8;
            this.numericUpDownC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownC.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownB.Hexadecimal = true;
            this.numericUpDownB.InterceptArrowKeys = false;
            this.numericUpDownB.Location = new System.Drawing.Point(98, 81);
            this.numericUpDownB.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(201, 24);
            this.numericUpDownB.TabIndex = 7;
            this.numericUpDownB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownB.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownA.Hexadecimal = true;
            this.numericUpDownA.InterceptArrowKeys = false;
            this.numericUpDownA.Location = new System.Drawing.Point(98, 27);
            this.numericUpDownA.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(201, 24);
            this.numericUpDownA.TabIndex = 6;
            this.numericUpDownA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownA.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(12, 251);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(54, 49);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonAddCollection);
            this.groupBox3.Controls.Add(this.radioButtonOnlyFirst);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 55);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type view";
            // 
            // radioButtonAddCollection
            // 
            this.radioButtonAddCollection.AutoSize = true;
            this.radioButtonAddCollection.Checked = true;
            this.radioButtonAddCollection.Location = new System.Drawing.Point(164, 25);
            this.radioButtonAddCollection.Name = "radioButtonAddCollection";
            this.radioButtonAddCollection.Size = new System.Drawing.Size(135, 24);
            this.radioButtonAddCollection.TabIndex = 10;
            this.radioButtonAddCollection.TabStop = true;
            this.radioButtonAddCollection.Text = "Add collection";
            this.radioButtonAddCollection.UseVisualStyleBackColor = true;
            // 
            // radioButtonOnlyFirst
            // 
            this.radioButtonOnlyFirst.AutoSize = true;
            this.radioButtonOnlyFirst.Location = new System.Drawing.Point(6, 25);
            this.radioButtonOnlyFirst.Name = "radioButtonOnlyFirst";
            this.radioButtonOnlyFirst.Size = new System.Drawing.Size(98, 24);
            this.radioButtonOnlyFirst.TabIndex = 9;
            this.radioButtonOnlyFirst.Text = "Only first";
            this.radioButtonOnlyFirst.UseVisualStyleBackColor = true;
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 343);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Input";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.CheckBox checkBoxPerimeter;
        private System.Windows.Forms.CheckBox checkBoxArea;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.NumericUpDown numericUpDownC;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonAddCollection;
        private System.Windows.Forms.RadioButton radioButtonOnlyFirst;

    }
}