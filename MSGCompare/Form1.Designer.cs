namespace MSGCompare
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBrowseFile2 = new System.Windows.Forms.Button();
            this.buttonBrowseFile1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFile2 = new System.Windows.Forms.TextBox();
            this.textBoxFile1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxProperties = new System.Windows.Forms.ListBox();
            this.comboBoxComparison = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxNamedPropName = new System.Windows.Forms.TextBox();
            this.listBoxPartialNames = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxExactNames = new System.Windows.Forms.ListBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxTag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxValue2 = new System.Windows.Forms.TextBox();
            this.textBoxValue1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBrowseFile2);
            this.groupBox1.Controls.Add(this.buttonBrowseFile1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxFile2);
            this.groupBox1.Controls.Add(this.textBoxFile1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files to compare";
            // 
            // buttonBrowseFile2
            // 
            this.buttonBrowseFile2.Location = new System.Drawing.Point(533, 43);
            this.buttonBrowseFile2.Name = "buttonBrowseFile2";
            this.buttonBrowseFile2.Size = new System.Drawing.Size(25, 23);
            this.buttonBrowseFile2.TabIndex = 5;
            this.buttonBrowseFile2.Text = "...";
            this.buttonBrowseFile2.UseVisualStyleBackColor = true;
            this.buttonBrowseFile2.Click += new System.EventHandler(this.buttonBrowseFile2_Click);
            // 
            // buttonBrowseFile1
            // 
            this.buttonBrowseFile1.Location = new System.Drawing.Point(533, 17);
            this.buttonBrowseFile1.Name = "buttonBrowseFile1";
            this.buttonBrowseFile1.Size = new System.Drawing.Size(25, 23);
            this.buttonBrowseFile1.TabIndex = 4;
            this.buttonBrowseFile1.Text = "...";
            this.buttonBrowseFile1.UseVisualStyleBackColor = true;
            this.buttonBrowseFile1.Click += new System.EventHandler(this.buttonBrowseFile1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "File 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File 1:";
            // 
            // textBoxFile2
            // 
            this.textBoxFile2.Location = new System.Drawing.Point(47, 45);
            this.textBoxFile2.Name = "textBoxFile2";
            this.textBoxFile2.Size = new System.Drawing.Size(483, 20);
            this.textBoxFile2.TabIndex = 1;
            this.textBoxFile2.TextChanged += new System.EventHandler(this.textBoxFile2_TextChanged);
            // 
            // textBoxFile1
            // 
            this.textBoxFile1.Location = new System.Drawing.Point(47, 19);
            this.textBoxFile1.Name = "textBoxFile1";
            this.textBoxFile1.Size = new System.Drawing.Size(483, 20);
            this.textBoxFile1.TabIndex = 0;
            this.textBoxFile1.TextChanged += new System.EventHandler(this.textBoxFile1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxProperties);
            this.groupBox2.Controls.Add(this.comboBoxComparison);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 267);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comparison";
            // 
            // listBoxProperties
            // 
            this.listBoxProperties.DisplayMember = "Name";
            this.listBoxProperties.FormattingEnabled = true;
            this.listBoxProperties.Location = new System.Drawing.Point(6, 46);
            this.listBoxProperties.Name = "listBoxProperties";
            this.listBoxProperties.Size = new System.Drawing.Size(247, 212);
            this.listBoxProperties.TabIndex = 1;
            this.listBoxProperties.ValueMember = "TagString";
            this.listBoxProperties.SelectedIndexChanged += new System.EventHandler(this.listBoxProperties_SelectedIndexChanged);
            // 
            // comboBoxComparison
            // 
            this.comboBoxComparison.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComparison.FormattingEnabled = true;
            this.comboBoxComparison.Items.AddRange(new object[] {
            "Properties in file 1 but not file 2",
            "Properties in file 2 but not file 1",
            "Properties that differ",
            "Properties that are the same"});
            this.comboBoxComparison.Location = new System.Drawing.Point(6, 19);
            this.comboBoxComparison.Name = "comboBoxComparison";
            this.comboBoxComparison.Size = new System.Drawing.Size(247, 21);
            this.comboBoxComparison.TabIndex = 0;
            this.comboBoxComparison.SelectedIndexChanged += new System.EventHandler(this.comboBoxComparison_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxNamedPropName);
            this.groupBox3.Controls.Add(this.listBoxPartialNames);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.listBoxExactNames);
            this.groupBox3.Controls.Add(this.textBoxType);
            this.groupBox3.Controls.Add(this.textBoxTag);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(277, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 267);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Property Definition";
            // 
            // textBoxNamedPropName
            // 
            this.textBoxNamedPropName.Location = new System.Drawing.Point(6, 238);
            this.textBoxNamedPropName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNamedPropName.Name = "textBoxNamedPropName";
            this.textBoxNamedPropName.Size = new System.Drawing.Size(287, 20);
            this.textBoxNamedPropName.TabIndex = 8;
            // 
            // listBoxPartialNames
            // 
            this.listBoxPartialNames.FormattingEnabled = true;
            this.listBoxPartialNames.Location = new System.Drawing.Point(6, 148);
            this.listBoxPartialNames.Name = "listBoxPartialNames";
            this.listBoxPartialNames.Size = new System.Drawing.Size(287, 69);
            this.listBoxPartialNames.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Other names";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Names";
            // 
            // listBoxExactNames
            // 
            this.listBoxExactNames.FormattingEnabled = true;
            this.listBoxExactNames.Location = new System.Drawing.Point(6, 73);
            this.listBoxExactNames.Name = "listBoxExactNames";
            this.listBoxExactNames.Size = new System.Drawing.Size(287, 56);
            this.listBoxExactNames.TabIndex = 4;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(136, 34);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(157, 20);
            this.textBoxType.TabIndex = 3;
            // 
            // textBoxTag
            // 
            this.textBoxTag.Location = new System.Drawing.Point(6, 34);
            this.textBoxTag.Name = "textBoxTag";
            this.textBoxTag.Size = new System.Drawing.Size(124, 20);
            this.textBoxTag.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tag";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxValue2);
            this.groupBox4.Controls.Add(this.textBoxValue1);
            this.groupBox4.Location = new System.Drawing.Point(12, 373);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(564, 135);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Property Value";
            // 
            // textBoxValue2
            // 
            this.textBoxValue2.Location = new System.Drawing.Point(283, 19);
            this.textBoxValue2.Multiline = true;
            this.textBoxValue2.Name = "textBoxValue2";
            this.textBoxValue2.Size = new System.Drawing.Size(275, 110);
            this.textBoxValue2.TabIndex = 1;
            // 
            // textBoxValue1
            // 
            this.textBoxValue1.Location = new System.Drawing.Point(6, 19);
            this.textBoxValue1.Multiline = true;
            this.textBoxValue1.Name = "textBoxValue1";
            this.textBoxValue1.Size = new System.Drawing.Size(275, 110);
            this.textBoxValue1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Named Property Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 520);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "MSG Comparator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBrowseFile2;
        private System.Windows.Forms.Button buttonBrowseFile1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFile2;
        private System.Windows.Forms.TextBox textBoxFile1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxTag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxExactNames;
        private System.Windows.Forms.ListBox listBoxProperties;
        private System.Windows.Forms.ComboBox comboBoxComparison;
        private System.Windows.Forms.ListBox listBoxPartialNames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxValue2;
        private System.Windows.Forms.TextBox textBoxValue1;
        private System.Windows.Forms.TextBox textBoxNamedPropName;
        private System.Windows.Forms.Label label7;
    }
}

