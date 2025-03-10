namespace tpmodul3_2311104049
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.DarkCyan;
            this.txtInput.Location = new System.Drawing.Point(211, 24);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(389, 31);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "Masukkan Inputan";
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnInput.Location = new System.Drawing.Point(340, 66);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(128, 48);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "Click";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblOutput.Location = new System.Drawing.Point(285, 127);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblOutput.Size = new System.Drawing.Size(240, 51);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "output";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Label lblOutput;
    }
}

