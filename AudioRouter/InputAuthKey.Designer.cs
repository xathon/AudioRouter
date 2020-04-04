namespace AudioRouter
{
    partial class InputAuthKey
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tB_TSKey = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your TeamSpeak API key here";
            this.toolTip1.SetToolTip(this.label1, "You can find the key in your TeamSpeak plugin settings.");
            // 
            // tB_TSKey
            // 
            this.tB_TSKey.AllowDrop = true;
            this.tB_TSKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tB_TSKey.Location = new System.Drawing.Point(17, 50);
            this.tB_TSKey.MaxLength = 29;
            this.tB_TSKey.Name = "tB_TSKey";
            this.tB_TSKey.Size = new System.Drawing.Size(319, 20);
            this.tB_TSKey.TabIndex = 1;
            this.tB_TSKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_TSKey_KeyDown);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(359, 50);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 2;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // InputAuthKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 97);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tB_TSKey);
            this.Controls.Add(this.label1);
            this.Name = "InputAuthKey";
            this.Text = "InputAuthKey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tB_TSKey;
        private System.Windows.Forms.Button btn_Submit;
    }
}