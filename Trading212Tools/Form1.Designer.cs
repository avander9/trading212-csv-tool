namespace Trading212Tools
{
    partial class Form1
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
            this.selectFile = new System.Windows.Forms.Button();
            this.processButtom = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checboxCleanddbb = new System.Windows.Forms.CheckBox();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectFile
            // 
            this.selectFile.Location = new System.Drawing.Point(212, 80);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(75, 23);
            this.selectFile.TabIndex = 1;
            this.selectFile.Text = "Select File";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // processButtom
            // 
            this.processButtom.Location = new System.Drawing.Point(437, 130);
            this.processButtom.Name = "processButtom";
            this.processButtom.Size = new System.Drawing.Size(75, 23);
            this.processButtom.TabIndex = 2;
            this.processButtom.Text = "Process";
            this.processButtom.UseVisualStyleBackColor = true;
            this.processButtom.Click += new System.EventHandler(this.processButtom_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checboxCleanddbb
            // 
            this.checboxCleanddbb.AutoSize = true;
            this.checboxCleanddbb.BackColor = System.Drawing.Color.IndianRed;
            this.checboxCleanddbb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checboxCleanddbb.Location = new System.Drawing.Point(12, 134);
            this.checboxCleanddbb.Name = "checboxCleanddbb";
            this.checboxCleanddbb.Size = new System.Drawing.Size(101, 19);
            this.checboxCleanddbb.TabIndex = 3;
            this.checboxCleanddbb.Text = "Delete DDBB";
            this.checboxCleanddbb.UseVisualStyleBackColor = false;
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Enabled = false;
            this.filePathTextBox.Location = new System.Drawing.Point(12, 36);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.PlaceholderText = "no file selected";
            this.filePathTextBox.Size = new System.Drawing.Size(500, 23);
            this.filePathTextBox.TabIndex = 4;
            this.filePathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 165);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.checboxCleanddbb);
            this.Controls.Add(this.processButtom);
            this.Controls.Add(this.selectFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Trading212 Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button selectFile;
        private Button processButtom;
        private OpenFileDialog openFileDialog1;
        private CheckBox checboxCleanddbb;
        private TextBox filePathTextBox;
    }
}