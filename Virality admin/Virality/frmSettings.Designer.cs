namespace Virality
{
    partial class frmSettings
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteA = new System.Windows.Forms.Button();
            this.cbPrivate = new System.Windows.Forms.CheckBox();
            this.cbPublic = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Virality.Properties.Resources.icons8_gear_24;
            this.pictureBox1.Location = new System.Drawing.Point(194, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnDeleteA);
            this.panel3.Controls.Add(this.cbPrivate);
            this.panel3.Controls.Add(this.cbPublic);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(129, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 452);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "If you are having issues with your account. \r\n         Please go talk to the Help" +
    " Team";
            // 
            // btnDeleteA
            // 
            this.btnDeleteA.BackColor = System.Drawing.Color.Red;
            this.btnDeleteA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteA.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteA.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteA.Location = new System.Drawing.Point(142, 376);
            this.btnDeleteA.Name = "btnDeleteA";
            this.btnDeleteA.Size = new System.Drawing.Size(179, 36);
            this.btnDeleteA.TabIndex = 3;
            this.btnDeleteA.Text = "Delete Account";
            this.btnDeleteA.UseVisualStyleBackColor = false;
            this.btnDeleteA.Click += new System.EventHandler(this.btnDeleteA_Click);
            // 
            // cbPrivate
            // 
            this.cbPrivate.AutoSize = true;
            this.cbPrivate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbPrivate.ForeColor = System.Drawing.Color.White;
            this.cbPrivate.Location = new System.Drawing.Point(271, 142);
            this.cbPrivate.Name = "cbPrivate";
            this.cbPrivate.Size = new System.Drawing.Size(172, 29);
            this.cbPrivate.TabIndex = 2;
            this.cbPrivate.Text = "Private Account";
            this.cbPrivate.UseVisualStyleBackColor = true;
            this.cbPrivate.CheckedChanged += new System.EventHandler(this.cbPrivate_CheckedChanged);
            // 
            // cbPublic
            // 
            this.cbPublic.AutoSize = true;
            this.cbPublic.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbPublic.ForeColor = System.Drawing.Color.White;
            this.cbPublic.Location = new System.Drawing.Point(27, 142);
            this.cbPublic.Name = "cbPublic";
            this.cbPublic.Size = new System.Drawing.Size(165, 29);
            this.cbPublic.TabIndex = 2;
            this.cbPublic.Text = "Public Account";
            this.cbPublic.UseVisualStyleBackColor = true;
            this.cbPublic.CheckedChanged += new System.EventHandler(this.cbPublic_CheckedChanged);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel3;
        private Button btnDeleteA;
        private CheckBox cbPrivate;
        private CheckBox cbPublic;
        private Label label1;
    }
}