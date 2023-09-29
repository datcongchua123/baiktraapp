namespace baiktraapp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.GroupBox();
            this.sale100 = new System.Windows.Forms.RadioButton();
            this.sale50 = new System.Windows.Forms.RadioButton();
            this.sale10 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtcourse = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.ComboBox();
            this.txtunit = new System.Windows.Forms.TextBox();
            this.discount.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year";
            // 
            // discount
            // 
            this.discount.Controls.Add(this.sale100);
            this.discount.Controls.Add(this.sale50);
            this.discount.Controls.Add(this.sale10);
            this.discount.Location = new System.Drawing.Point(76, 300);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(426, 114);
            this.discount.TabIndex = 4;
            this.discount.TabStop = false;
            this.discount.Text = "Discount";
            // 
            // sale100
            // 
            this.sale100.AutoSize = true;
            this.sale100.Location = new System.Drawing.Point(304, 55);
            this.sale100.Name = "sale100";
            this.sale100.Size = new System.Drawing.Size(61, 20);
            this.sale100.TabIndex = 2;
            this.sale100.TabStop = true;
            this.sale100.Text = "100%";
            this.sale100.UseVisualStyleBackColor = true;
            // 
            // sale50
            // 
            this.sale50.AutoSize = true;
            this.sale50.Location = new System.Drawing.Point(161, 55);
            this.sale50.Name = "sale50";
            this.sale50.Size = new System.Drawing.Size(54, 20);
            this.sale50.TabIndex = 1;
            this.sale50.TabStop = true;
            this.sale50.Text = "50%";
            this.sale50.UseVisualStyleBackColor = true;
            // 
            // sale10
            // 
            this.sale10.AutoSize = true;
            this.sale10.Location = new System.Drawing.Point(25, 55);
            this.sale10.Name = "sale10";
            this.sale10.Size = new System.Drawing.Size(54, 20);
            this.sale10.TabIndex = 0;
            this.sale10.TabStop = true;
            this.sale10.Text = "10%";
            this.sale10.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Unit";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(483, 447);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 6;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(155, 59);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 7;
            // 
            // txtcourse
            // 
            this.txtcourse.Location = new System.Drawing.Point(155, 167);
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.Size = new System.Drawing.Size(100, 22);
            this.txtcourse.TabIndex = 8;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(155, 113);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 9;
            // 
            // txtyear
            // 
            this.txtyear.FormattingEnabled = true;
            this.txtyear.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004"});
            this.txtyear.Location = new System.Drawing.Point(155, 226);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(121, 24);
            this.txtyear.TabIndex = 10;
            // 
            // txtunit
            // 
            this.txtunit.Location = new System.Drawing.Point(87, 444);
            this.txtunit.Name = "txtunit";
            this.txtunit.Size = new System.Drawing.Size(100, 22);
            this.txtunit.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 507);
            this.Controls.Add(this.txtunit);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtcourse);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.discount.ResumeLayout(false);
            this.discount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox discount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtcourse;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox txtyear;
        private System.Windows.Forms.RadioButton sale100;
        private System.Windows.Forms.RadioButton sale50;
        private System.Windows.Forms.RadioButton sale10;
        private System.Windows.Forms.TextBox txtunit;
    }
}

