namespace AudioRouter
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
            this.cB_Casters_RX_Stream = new System.Windows.Forms.CheckBox();
            this.cB_Casters_RX_Headset = new System.Windows.Forms.CheckBox();
            this.cB_Casters_TX = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gB_Version = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cB_Observers_RX = new System.Windows.Forms.CheckBox();
            this.cB_Observers_TX = new System.Windows.Forms.CheckBox();
            this.cB_enableRadio_Version = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cB_Prod_RX = new System.Windows.Forms.CheckBox();
            this.cB_Prod_TX = new System.Windows.Forms.CheckBox();
            this.btn_Edit_Key = new System.Windows.Forms.Button();
            this.gB_Version.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Casters";
            // 
            // cB_Casters_RX_Stream
            // 
            this.cB_Casters_RX_Stream.AutoCheck = false;
            this.cB_Casters_RX_Stream.AutoSize = true;
            this.cB_Casters_RX_Stream.Enabled = false;
            this.cB_Casters_RX_Stream.Location = new System.Drawing.Point(91, 99);
            this.cB_Casters_RX_Stream.Name = "cB_Casters_RX_Stream";
            this.cB_Casters_RX_Stream.Size = new System.Drawing.Size(77, 17);
            this.cB_Casters_RX_Stream.TabIndex = 1;
            this.cB_Casters_RX_Stream.Text = "RX Stream";
            this.cB_Casters_RX_Stream.UseVisualStyleBackColor = true;
            this.cB_Casters_RX_Stream.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cB_Casters_RX_Headset
            // 
            this.cB_Casters_RX_Headset.Appearance = System.Windows.Forms.Appearance.Button;
            this.cB_Casters_RX_Headset.AutoSize = true;
            this.cB_Casters_RX_Headset.Location = new System.Drawing.Point(203, 95);
            this.cB_Casters_RX_Headset.Name = "cB_Casters_RX_Headset";
            this.cB_Casters_RX_Headset.Size = new System.Drawing.Size(75, 23);
            this.cB_Casters_RX_Headset.TabIndex = 2;
            this.cB_Casters_RX_Headset.Text = "RX Headset";
            this.cB_Casters_RX_Headset.UseVisualStyleBackColor = true;
            this.cB_Casters_RX_Headset.CheckedChanged += new System.EventHandler(this.cB_Casters_RX_Headset_CheckedChanged);
            // 
            // cB_Casters_TX
            // 
            this.cB_Casters_TX.Appearance = System.Windows.Forms.Appearance.Button;
            this.cB_Casters_TX.AutoSize = true;
            this.cB_Casters_TX.Location = new System.Drawing.Point(320, 95);
            this.cB_Casters_TX.Name = "cB_Casters_TX";
            this.cB_Casters_TX.Size = new System.Drawing.Size(31, 23);
            this.cB_Casters_TX.TabIndex = 3;
            this.cB_Casters_TX.Text = "TX";
            this.cB_Casters_TX.UseVisualStyleBackColor = true;
            this.cB_Casters_TX.CheckedChanged += new System.EventHandler(this.cB_Casters_TX_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Banana";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gB_Version
            // 
            this.gB_Version.Controls.Add(this.btn_Edit_Key);
            this.gB_Version.Controls.Add(this.radioButton2);
            this.gB_Version.Controls.Add(this.radioButton1);
            this.gB_Version.Enabled = false;
            this.gB_Version.Location = new System.Drawing.Point(17, 12);
            this.gB_Version.Name = "gB_Version";
            this.gB_Version.Size = new System.Drawing.Size(236, 46);
            this.gB_Version.TabIndex = 5;
            this.gB_Version.TabStop = false;
            this.gB_Version.Text = "VoiceMeeter Version";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(74, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Potato";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Observers";
            // 
            // cB_Observers_RX
            // 
            this.cB_Observers_RX.Appearance = System.Windows.Forms.Appearance.Button;
            this.cB_Observers_RX.AutoSize = true;
            this.cB_Observers_RX.Location = new System.Drawing.Point(203, 146);
            this.cB_Observers_RX.Name = "cB_Observers_RX";
            this.cB_Observers_RX.Size = new System.Drawing.Size(75, 23);
            this.cB_Observers_RX.TabIndex = 7;
            this.cB_Observers_RX.Text = "RX Headset";
            this.cB_Observers_RX.UseVisualStyleBackColor = true;
            this.cB_Observers_RX.CheckedChanged += new System.EventHandler(this.cB_Observers_RX_CheckedChanged);
            // 
            // cB_Observers_TX
            // 
            this.cB_Observers_TX.Appearance = System.Windows.Forms.Appearance.Button;
            this.cB_Observers_TX.AutoSize = true;
            this.cB_Observers_TX.Location = new System.Drawing.Point(320, 146);
            this.cB_Observers_TX.Name = "cB_Observers_TX";
            this.cB_Observers_TX.Size = new System.Drawing.Size(31, 23);
            this.cB_Observers_TX.TabIndex = 8;
            this.cB_Observers_TX.Text = "TX";
            this.cB_Observers_TX.UseVisualStyleBackColor = true;
            this.cB_Observers_TX.CheckedChanged += new System.EventHandler(this.cB_Observers_TX_CheckedChanged);
            // 
            // cB_enableRadio_Version
            // 
            this.cB_enableRadio_Version.Appearance = System.Windows.Forms.Appearance.Button;
            this.cB_enableRadio_Version.AutoSize = true;
            this.cB_enableRadio_Version.Location = new System.Drawing.Point(259, 28);
            this.cB_enableRadio_Version.Name = "cB_enableRadio_Version";
            this.cB_enableRadio_Version.Size = new System.Drawing.Size(51, 23);
            this.cB_enableRadio_Version.TabIndex = 9;
            this.cB_enableRadio_Version.Text = "Unlock";
            this.cB_enableRadio_Version.UseVisualStyleBackColor = true;
            this.cB_enableRadio_Version.CheckedChanged += new System.EventHandler(this.cb_enableRadio_Version_CheckedChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Backup Producer";
            // 
            // cB_Prod_RX
            // 
            this.cB_Prod_RX.Appearance = System.Windows.Forms.Appearance.Button;
            this.cB_Prod_RX.AutoSize = true;
            this.cB_Prod_RX.Location = new System.Drawing.Point(203, 195);
            this.cB_Prod_RX.Name = "cB_Prod_RX";
            this.cB_Prod_RX.Size = new System.Drawing.Size(75, 23);
            this.cB_Prod_RX.TabIndex = 11;
            this.cB_Prod_RX.Text = "RX Headset";
            this.cB_Prod_RX.UseVisualStyleBackColor = true;
            // 
            // cB_Prod_TX
            // 
            this.cB_Prod_TX.Appearance = System.Windows.Forms.Appearance.Button;
            this.cB_Prod_TX.AutoSize = true;
            this.cB_Prod_TX.Location = new System.Drawing.Point(320, 195);
            this.cB_Prod_TX.Name = "cB_Prod_TX";
            this.cB_Prod_TX.Size = new System.Drawing.Size(31, 23);
            this.cB_Prod_TX.TabIndex = 12;
            this.cB_Prod_TX.Text = "TX";
            this.cB_Prod_TX.UseVisualStyleBackColor = true;
            // 
            // btn_Edit_Key
            // 
            this.btn_Edit_Key.Enabled = false;
            this.btn_Edit_Key.Location = new System.Drawing.Point(136, 16);
            this.btn_Edit_Key.Name = "btn_Edit_Key";
            this.btn_Edit_Key.Size = new System.Drawing.Size(93, 23);
            this.btn_Edit_Key.TabIndex = 13;
            this.btn_Edit_Key.Text = "Edit TS API Key";
            this.btn_Edit_Key.UseVisualStyleBackColor = true;
            this.btn_Edit_Key.Click += new System.EventHandler(this.btn_Edit_Key_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 260);
            this.Controls.Add(this.cB_Prod_TX);
            this.Controls.Add(this.cB_Prod_RX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cB_enableRadio_Version);
            this.Controls.Add(this.cB_Observers_TX);
            this.Controls.Add(this.cB_Observers_RX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gB_Version);
            this.Controls.Add(this.cB_Casters_TX);
            this.Controls.Add(this.cB_Casters_RX_Headset);
            this.Controls.Add(this.cB_Casters_RX_Stream);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gB_Version.ResumeLayout(false);
            this.gB_Version.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cB_Casters_RX_Stream;
        private System.Windows.Forms.CheckBox cB_Casters_RX_Headset;
        private System.Windows.Forms.CheckBox cB_Casters_TX;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox gB_Version;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cB_Observers_RX;
        private System.Windows.Forms.CheckBox cB_Observers_TX;
        private System.Windows.Forms.CheckBox cB_enableRadio_Version;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cB_Prod_RX;
        private System.Windows.Forms.CheckBox cB_Prod_TX;
        private System.Windows.Forms.Button btn_Edit_Key;
    }
}

