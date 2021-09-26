
namespace SoPhuc
{
    partial class Complex
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSetNo1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btSetNo2 = new System.Windows.Forms.Button();
            this.realLabel = new System.Windows.Forms.Label();
            this.imaginaryLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.imaginaryTextBox = new System.Windows.Forms.TextBox();
            this.realTextBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.subtractBtn = new System.Windows.Forms.Button();
            this.mutiplyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSetNo1
            // 
            this.btSetNo1.Location = new System.Drawing.Point(288, 69);
            this.btSetNo1.Name = "btSetNo1";
            this.btSetNo1.Size = new System.Drawing.Size(75, 23);
            this.btSetNo1.TabIndex = 0;
            this.btSetNo1.Text = "Set No 1";
            this.btSetNo1.UseVisualStyleBackColor = true;
            this.btSetNo1.Click += new System.EventHandler(this.btSetNo1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btSetNo2
            // 
            this.btSetNo2.Location = new System.Drawing.Point(288, 148);
            this.btSetNo2.Name = "btSetNo2";
            this.btSetNo2.Size = new System.Drawing.Size(75, 23);
            this.btSetNo2.TabIndex = 2;
            this.btSetNo2.Text = "Set No 2";
            this.btSetNo2.UseVisualStyleBackColor = true;
            this.btSetNo2.Click += new System.EventHandler(this.btSetNo2_Click);
            // 
            // realLabel
            // 
            this.realLabel.AutoSize = true;
            this.realLabel.Location = new System.Drawing.Point(47, 72);
            this.realLabel.Name = "realLabel";
            this.realLabel.Size = new System.Drawing.Size(29, 15);
            this.realLabel.TabIndex = 3;
            this.realLabel.Text = "Real";
            // 
            // imaginaryLabel
            // 
            this.imaginaryLabel.AutoSize = true;
            this.imaginaryLabel.Location = new System.Drawing.Point(47, 151);
            this.imaginaryLabel.Name = "imaginaryLabel";
            this.imaginaryLabel.Size = new System.Drawing.Size(60, 15);
            this.imaginaryLabel.TabIndex = 4;
            this.imaginaryLabel.Text = "Imaginary";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(47, 347);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 15);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Status";
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click_1);
            // 
            // imaginaryTextBox
            // 
            this.imaginaryTextBox.Location = new System.Drawing.Point(116, 149);
            this.imaginaryTextBox.Name = "imaginaryTextBox";
            this.imaginaryTextBox.Size = new System.Drawing.Size(100, 23);
            this.imaginaryTextBox.TabIndex = 6;
            // 
            // realTextBox
            // 
            this.realTextBox.Location = new System.Drawing.Point(116, 69);
            this.realTextBox.Name = "realTextBox";
            this.realTextBox.Size = new System.Drawing.Size(100, 23);
            this.realTextBox.TabIndex = 7;
            this.realTextBox.TextChanged += new System.EventHandler(this.realTextBox_TextChanged_1);
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addBtn.Location = new System.Drawing.Point(76, 269);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            // 
            // subtractBtn
            // 
            this.subtractBtn.Location = new System.Drawing.Point(227, 269);
            this.subtractBtn.Name = "subtractBtn";
            this.subtractBtn.Size = new System.Drawing.Size(75, 23);
            this.subtractBtn.TabIndex = 9;
            this.subtractBtn.Text = "Subtract";
            this.subtractBtn.UseVisualStyleBackColor = true;
            this.subtractBtn.Click += new System.EventHandler(this.subtractBtn_Click_1);
            // 
            // mutiplyBtn
            // 
            this.mutiplyBtn.Location = new System.Drawing.Point(372, 269);
            this.mutiplyBtn.Name = "mutiplyBtn";
            this.mutiplyBtn.Size = new System.Drawing.Size(75, 23);
            this.mutiplyBtn.TabIndex = 10;
            this.mutiplyBtn.Text = "Mutiply";
            this.mutiplyBtn.UseVisualStyleBackColor = true;
            this.mutiplyBtn.Click += new System.EventHandler(this.mutiplyBtn_Click_1);
            // 
            // Complex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 388);
            this.Controls.Add(this.mutiplyBtn);
            this.Controls.Add(this.subtractBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.realTextBox);
            this.Controls.Add(this.imaginaryTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.imaginaryLabel);
            this.Controls.Add(this.realLabel);
            this.Controls.Add(this.btSetNo2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btSetNo1);
            this.Name = "Complex";
            this.Text = "Complex Number";
            this.Load += new System.EventHandler(this.Complex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSetNo1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btSetNo2;
        private System.Windows.Forms.Label realLabel;
        private System.Windows.Forms.Label imaginaryLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox imaginaryTextBox;
        private System.Windows.Forms.TextBox realTextBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button subtractBtn;
        private System.Windows.Forms.Button mutiplyBtn;
    }
}

