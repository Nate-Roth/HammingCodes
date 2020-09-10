namespace HammingCodes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.HamTheDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // DataMaskedTextBox
            // 
            this.DataMaskedTextBox.AsciiOnly = true;
            this.DataMaskedTextBox.Location = new System.Drawing.Point(12, 18);
            this.DataMaskedTextBox.Mask = "0-0-0-0-0-0-0-0-0-0-0";
            this.DataMaskedTextBox.Name = "DataMaskedTextBox";
            this.DataMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.DataMaskedTextBox.TabIndex = 1;
            this.DataMaskedTextBox.Text = "10101010101";
            // 
            // HamTheDataButton
            // 
            this.HamTheDataButton.Location = new System.Drawing.Point(139, 18);
            this.HamTheDataButton.Name = "HamTheDataButton";
            this.HamTheDataButton.Size = new System.Drawing.Size(75, 23);
            this.HamTheDataButton.TabIndex = 2;
            this.HamTheDataButton.Text = "Ham It";
            this.HamTheDataButton.UseVisualStyleBackColor = true;
            this.HamTheDataButton.Click += new System.EventHandler(this.HamTheDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HamTheDataButton);
            this.Controls.Add(this.DataMaskedTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox DataMaskedTextBox;
        private System.Windows.Forms.Button HamTheDataButton;
    }
}

