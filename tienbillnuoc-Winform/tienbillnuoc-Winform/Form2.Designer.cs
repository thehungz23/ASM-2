namespace tienbillnuoc_Winform
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtLastMonthReading = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtExit = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtRemove = new System.Windows.Forms.Button();
            this.txtThisMonthReading = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.numPeople = new System.Windows.Forms.NumericUpDown();
            this.cbxCustomerType = new System.Windows.Forms.ComboBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtLastMonthReading
            // 
            this.txtLastMonthReading.Location = new System.Drawing.Point(221, 71);
            this.txtLastMonthReading.Name = "txtLastMonthReading";
            this.txtLastMonthReading.Size = new System.Drawing.Size(100, 26);
            this.txtLastMonthReading.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last water month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "This water month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Type cline";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Number people";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(609, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Result";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(221, 22);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(100, 26);
            this.txtClientName.TabIndex = 16;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 275);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1014, 163);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // txtExit
            // 
            this.txtExit.Location = new System.Drawing.Point(1032, 404);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(64, 34);
            this.txtExit.TabIndex = 18;
            this.txtExit.Text = "Exit";
            this.txtExit.UseVisualStyleBackColor = true;
            this.txtExit.Click += new System.EventHandler(this.txtExit_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(788, 12);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(89, 56);
            this.txtAdd.TabIndex = 19;
            this.txtAdd.Text = "Add";
            this.txtAdd.UseVisualStyleBackColor = true;
            this.txtAdd.Click += new System.EventHandler(this.txtAdd_Click_1);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(442, 165);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 74);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "Caculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(921, 13);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(91, 55);
            this.txtRemove.TabIndex = 21;
            this.txtRemove.Text = "Remove";
            this.txtRemove.UseVisualStyleBackColor = true;
            this.txtRemove.Click += new System.EventHandler(this.txtRemove_Click_1);
            // 
            // txtThisMonthReading
            // 
            this.txtThisMonthReading.Location = new System.Drawing.Point(224, 124);
            this.txtThisMonthReading.Name = "txtThisMonthReading";
            this.txtThisMonthReading.Size = new System.Drawing.Size(105, 26);
            this.txtThisMonthReading.TabIndex = 22;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(608, 74);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(477, 176);
            this.txtResult.TabIndex = 23;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // numPeople
            // 
            this.numPeople.Location = new System.Drawing.Point(214, 219);
            this.numPeople.Name = "numPeople";
            this.numPeople.Size = new System.Drawing.Size(106, 26);
            this.numPeople.TabIndex = 24;
            // 
            // cbxCustomerType
            // 
            this.cbxCustomerType.FormattingEnabled = true;
            this.cbxCustomerType.Items.AddRange(new object[] {
            "household",
            "administrative agency public services",
            "production units",
            "business services"});
            this.cbxCustomerType.Location = new System.Drawing.Point(224, 168);
            this.cbxCustomerType.Name = "cbxCustomerType";
            this.cbxCustomerType.Size = new System.Drawing.Size(121, 28);
            this.cbxCustomerType.TabIndex = 25;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last month water";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "This month water";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type client";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Water Consumption";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total bill (VND)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 450);
            this.Controls.Add(this.cbxCustomerType);
            this.Controls.Add(this.numPeople);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtThisMonthReading);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastMonthReading);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtLastMonthReading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button txtExit;
        private System.Windows.Forms.Button txtAdd;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button txtRemove;
        private System.Windows.Forms.TextBox txtThisMonthReading;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.NumericUpDown numPeople;
        private System.Windows.Forms.ComboBox cbxCustomerType;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}