
namespace W5Jumat
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
            this.labelData = new System.Windows.Forms.Label();
            this.labelMode = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.listBoxKiri = new System.Windows.Forms.ListBox();
            this.listBoxKanan = new System.Windows.Forms.ListBox();
            this.buttonProses = new System.Windows.Forms.Button();
            this.buttonKKanan = new System.Windows.Forms.Button();
            this.buttonKanan = new System.Windows.Forms.Button();
            this.buttonKiri = new System.Windows.Forms.Button();
            this.buttonKKiri = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.checkBoxBlock = new System.Windows.Forms.CheckBox();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(51, 45);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(48, 20);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Data :";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Location = new System.Drawing.Point(51, 94);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(55, 20);
            this.labelMode.TabIndex = 1;
            this.labelMode.Text = "Mode :";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(117, 45);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(377, 27);
            this.textBoxInput.TabIndex = 2;
            // 
            // listBoxKiri
            // 
            this.listBoxKiri.FormattingEnabled = true;
            this.listBoxKiri.ItemHeight = 20;
            this.listBoxKiri.Location = new System.Drawing.Point(51, 214);
            this.listBoxKiri.Name = "listBoxKiri";
            this.listBoxKiri.Size = new System.Drawing.Size(255, 284);
            this.listBoxKiri.TabIndex = 4;
            this.listBoxKiri.SelectedIndexChanged += new System.EventHandler(this.listBoxKiri_SelectedIndexChanged);
            // 
            // listBoxKanan
            // 
            this.listBoxKanan.FormattingEnabled = true;
            this.listBoxKanan.ItemHeight = 20;
            this.listBoxKanan.Location = new System.Drawing.Point(414, 214);
            this.listBoxKanan.Name = "listBoxKanan";
            this.listBoxKanan.Size = new System.Drawing.Size(255, 284);
            this.listBoxKanan.TabIndex = 5;
            // 
            // buttonProses
            // 
            this.buttonProses.Location = new System.Drawing.Point(51, 159);
            this.buttonProses.Name = "buttonProses";
            this.buttonProses.Size = new System.Drawing.Size(94, 29);
            this.buttonProses.TabIndex = 6;
            this.buttonProses.Text = "Proses";
            this.buttonProses.UseVisualStyleBackColor = true;
            this.buttonProses.Click += new System.EventHandler(this.buttonProses_Click);
            // 
            // buttonKKanan
            // 
            this.buttonKKanan.Location = new System.Drawing.Point(322, 232);
            this.buttonKKanan.Name = "buttonKKanan";
            this.buttonKKanan.Size = new System.Drawing.Size(75, 29);
            this.buttonKKanan.TabIndex = 7;
            this.buttonKKanan.Text = ">>";
            this.buttonKKanan.UseVisualStyleBackColor = true;
            this.buttonKKanan.Click += new System.EventHandler(this.buttonKKanan_Click);
            // 
            // buttonKanan
            // 
            this.buttonKanan.Location = new System.Drawing.Point(322, 290);
            this.buttonKanan.Name = "buttonKanan";
            this.buttonKanan.Size = new System.Drawing.Size(75, 29);
            this.buttonKanan.TabIndex = 8;
            this.buttonKanan.Text = ">";
            this.buttonKanan.UseVisualStyleBackColor = true;
            this.buttonKanan.Click += new System.EventHandler(this.buttonKanan_Click);
            // 
            // buttonKiri
            // 
            this.buttonKiri.Location = new System.Drawing.Point(322, 347);
            this.buttonKiri.Name = "buttonKiri";
            this.buttonKiri.Size = new System.Drawing.Size(75, 29);
            this.buttonKiri.TabIndex = 9;
            this.buttonKiri.Text = "<";
            this.buttonKiri.UseVisualStyleBackColor = true;
            this.buttonKiri.Click += new System.EventHandler(this.buttonKiri_Click);
            // 
            // buttonKKiri
            // 
            this.buttonKKiri.Location = new System.Drawing.Point(322, 405);
            this.buttonKKiri.Name = "buttonKKiri";
            this.buttonKKiri.Size = new System.Drawing.Size(75, 29);
            this.buttonKKiri.TabIndex = 10;
            this.buttonKKiri.Text = "<<";
            this.buttonKKiri.UseVisualStyleBackColor = true;
            this.buttonKKiri.Click += new System.EventHandler(this.buttonKKiri_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(322, 452);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(75, 29);
            this.buttonHapus.TabIndex = 11;
            this.buttonHapus.Text = "X";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // checkBoxBlock
            // 
            this.checkBoxBlock.AutoSize = true;
            this.checkBoxBlock.Location = new System.Drawing.Point(414, 132);
            this.checkBoxBlock.Name = "checkBoxBlock";
            this.checkBoxBlock.Size = new System.Drawing.Size(67, 24);
            this.checkBoxBlock.TabIndex = 12;
            this.checkBoxBlock.Text = "Block";
            this.checkBoxBlock.UseVisualStyleBackColor = true;
            this.checkBoxBlock.CheckedChanged += new System.EventHandler(this.checkBoxBlock_CheckedChanged);
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "Add",
            "Replace"});
            this.comboBoxMode.Location = new System.Drawing.Point(117, 91);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(151, 28);
            this.comboBoxMode.TabIndex = 13;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonHapus;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 594);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.checkBoxBlock);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonKKiri);
            this.Controls.Add(this.buttonKiri);
            this.Controls.Add(this.buttonKanan);
            this.Controls.Add(this.buttonKKanan);
            this.Controls.Add(this.buttonProses);
            this.Controls.Add(this.listBoxKanan);
            this.Controls.Add(this.listBoxKiri);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.labelData);
            this.Name = "Form1";
            this.Text = "Input and Replace Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.ListBox listBoxKiri;
        private System.Windows.Forms.ListBox listBoxKanan;
        private System.Windows.Forms.Button buttonProses;
        private System.Windows.Forms.Button buttonKKanan;
        private System.Windows.Forms.Button buttonKanan;
        private System.Windows.Forms.Button buttonKiri;
        private System.Windows.Forms.Button buttonKKiri;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.CheckBox checkBoxBlock;
        private System.Windows.Forms.ComboBox comboBoxMode;
    }
}

