namespace EnglishToPigLatin
{
    partial class frmEngToPigLatin
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
         this.txtEng = new System.Windows.Forms.RichTextBox();
         this.txtPigL = new System.Windows.Forms.RichTextBox();
         this.lblEng = new System.Windows.Forms.Label();
         this.lblPigL = new System.Windows.Forms.Label();
         this.btnConvert = new System.Windows.Forms.Button();
         this.btnClear = new System.Windows.Forms.Button();
         this.btnExit = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // txtEng
         // 
         this.txtEng.Location = new System.Drawing.Point(12, 30);
         this.txtEng.Name = "txtEng";
         this.txtEng.Size = new System.Drawing.Size(290, 121);
         this.txtEng.TabIndex = 1;
         this.txtEng.Text = "";
         // 
         // txtPigL
         // 
         this.txtPigL.BackColor = System.Drawing.SystemColors.Window;
         this.txtPigL.Location = new System.Drawing.Point(311, 30);
         this.txtPigL.Name = "txtPigL";
         this.txtPigL.ReadOnly = true;
         this.txtPigL.Size = new System.Drawing.Size(290, 121);
         this.txtPigL.TabIndex = 6;
         this.txtPigL.Text = "";
         // 
         // lblEng
         // 
         this.lblEng.AutoSize = true;
         this.lblEng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblEng.Location = new System.Drawing.Point(9, 9);
         this.lblEng.Name = "lblEng";
         this.lblEng.Size = new System.Drawing.Size(68, 18);
         this.lblEng.TabIndex = 0;
         this.lblEng.Text = "&English:";
         // 
         // lblPigL
         // 
         this.lblPigL.AutoSize = true;
         this.lblPigL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblPigL.Location = new System.Drawing.Point(308, 9);
         this.lblPigL.Name = "lblPigL";
         this.lblPigL.Size = new System.Drawing.Size(78, 18);
         this.lblPigL.TabIndex = 5;
         this.lblPigL.Text = "Pig Latin:";
         // 
         // btnConvert
         // 
         this.btnConvert.Location = new System.Drawing.Point(227, 157);
         this.btnConvert.Name = "btnConvert";
         this.btnConvert.Size = new System.Drawing.Size(75, 23);
         this.btnConvert.TabIndex = 2;
         this.btnConvert.Text = "&Convert";
         this.btnConvert.UseVisualStyleBackColor = true;
         this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
         // 
         // btnClear
         // 
         this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnClear.Location = new System.Drawing.Point(445, 157);
         this.btnClear.Name = "btnClear";
         this.btnClear.Size = new System.Drawing.Size(75, 23);
         this.btnClear.TabIndex = 3;
         this.btnClear.Text = "C&lear";
         this.btnClear.UseVisualStyleBackColor = true;
         this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
         // 
         // btnExit
         // 
         this.btnExit.Location = new System.Drawing.Point(526, 157);
         this.btnExit.Name = "btnExit";
         this.btnExit.Size = new System.Drawing.Size(75, 23);
         this.btnExit.TabIndex = 4;
         this.btnExit.Text = "E&xit";
         this.btnExit.UseVisualStyleBackColor = true;
         this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
         // 
         // frmEngToPigLatin
         // 
         this.AcceptButton = this.btnConvert;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnClear;
         this.ClientSize = new System.Drawing.Size(613, 188);
         this.Controls.Add(this.btnExit);
         this.Controls.Add(this.btnClear);
         this.Controls.Add(this.btnConvert);
         this.Controls.Add(this.lblPigL);
         this.Controls.Add(this.lblEng);
         this.Controls.Add(this.txtPigL);
         this.Controls.Add(this.txtEng);
         this.Name = "frmEngToPigLatin";
         this.Text = "English to Pig Latin Translator ";
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtEng;
        private System.Windows.Forms.RichTextBox txtPigL;
        private System.Windows.Forms.Label lblEng;
        private System.Windows.Forms.Label lblPigL;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

