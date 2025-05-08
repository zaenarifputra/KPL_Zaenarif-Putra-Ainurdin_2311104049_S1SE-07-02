namespace Tpmodul12_2311104049
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
            this.cekButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cekButton
            // 
            this.cekButton.Location = new System.Drawing.Point(376, 155);
            this.cekButton.Name = "cekButton";
            this.cekButton.Size = new System.Drawing.Size(75, 37);
            this.cekButton.TabIndex = 0;
            this.cekButton.Text = "Check";
            this.cekButton.UseVisualStyleBackColor = true;
            this.cekButton.Click += new System.EventHandler(this.cekButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.Window;
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(334, 66);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(158, 61);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(313, 12);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(189, 26);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.cekButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cekButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}

