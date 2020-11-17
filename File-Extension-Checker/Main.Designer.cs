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
            this.btn_FixFIles = new DarkUI.Controls.DarkButton();
            this.btn_ScanFiles = new DarkUI.Controls.DarkButton();
            this.txt_output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_SelectFiles
            // 
            this.btn_SelectFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_SelectFiles.Location = new System.Drawing.Point(12, 12);
            this.btn_SelectFiles.Name = "btn_SelectFiles";
            this.btn_SelectFiles.Padding = new System.Windows.Forms.Padding(5);
            this.btn_SelectFiles.Size = new System.Drawing.Size(173, 51);
            this.btn_SelectFiles.TabIndex = 0;
            this.btn_SelectFiles.Text = "Select Files";
            this.btn_SelectFiles.Click += new System.EventHandler(this.btn_SelectFiles_Click);
            // 
            // btn_FixFIles
            // 
            this.btn_FixFIles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FixFIles.Location = new System.Drawing.Point(12, 160);
            this.btn_FixFIles.Name = "btn_FixFIles";
            this.btn_FixFIles.Padding = new System.Windows.Forms.Padding(5);
            this.btn_FixFIles.Size = new System.Drawing.Size(173, 51);
            this.btn_FixFIles.TabIndex = 2;
            this.btn_FixFIles.Text = "Fix Files";
            this.btn_FixFIles.Click += new System.EventHandler(this.btn_FixFIles_Click);
            // 
            // btn_ScanFiles
            // 
            this.btn_ScanFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ScanFiles.Location = new System.Drawing.Point(12, 85);
            this.btn_ScanFiles.Name = "btn_ScanFiles";
            this.btn_ScanFiles.Padding = new System.Windows.Forms.Padding(5);
            this.btn_ScanFiles.Size = new System.Drawing.Size(173, 51);
            this.btn_ScanFiles.TabIndex = 3;
            this.btn_ScanFiles.Text = "Scan Files";
            this.btn_ScanFiles.Click += new System.EventHandler(this.btn_ScanFiles_Click);
            // 
            // txt_output
            // 
            this.txt_output.BackColor = System.Drawing.Color.Black;
            this.txt_output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_output.ForeColor = System.Drawing.Color.Green;
            this.txt_output.Location = new System.Drawing.Point(191, 12);
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.Size = new System.Drawing.Size(561, 468);
            this.txt_output.TabIndex = 4;
            this.txt_output.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(752, 492);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.btn_ScanFiles);
            this.Controls.Add(this.btn_FixFIles);
            this.Controls.Add(this.btn_SelectFiles);
            this.Name = "Main";
            this.Text = "File Extension Checker";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkButton btn_SelectFiles;
        private DarkUI.Controls.DarkButton btn_FixFIles;
        private DarkUI.Controls.DarkButton btn_ScanFiles;
        private System.Windows.Forms.RichTextBox txt_output;
    }
}

