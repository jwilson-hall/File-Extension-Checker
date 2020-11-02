namespace File_Extension_Checker
{
    partial class Main
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
            this.btn_SelectFiles = new DarkUI.Controls.DarkButton();
            this.txt_output = new DarkUI.Controls.DarkTextBox();
            this.SuspendLayout();
            // 
            // btn_SelectFiles
            // 
            this.btn_SelectFiles.Location = new System.Drawing.Point(52, 536);
            this.btn_SelectFiles.Name = "btn_SelectFiles";
            this.btn_SelectFiles.Padding = new System.Windows.Forms.Padding(5);
            this.btn_SelectFiles.Size = new System.Drawing.Size(133, 51);
            this.btn_SelectFiles.TabIndex = 0;
            this.btn_SelectFiles.Text = "Select Files";
            this.btn_SelectFiles.Click += new System.EventHandler(this.btn_SelectFiles_Click);
            // 
            // txt_output
            // 
            this.txt_output.BackColor = System.Drawing.Color.Black;
            this.txt_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_output.ForeColor = System.Drawing.Color.Green;
            this.txt_output.Location = new System.Drawing.Point(247, 177);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(493, 423);
            this.txt_output.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(752, 612);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.btn_SelectFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkButton btn_SelectFiles;
        private DarkUI.Controls.DarkTextBox txt_output;
    }
}

