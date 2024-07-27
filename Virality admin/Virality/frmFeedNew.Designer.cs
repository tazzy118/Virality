namespace Virality
{
    partial class frmFeedNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFeedNew));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.commentlbl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnComment = new System.Windows.Forms.Button();
            this.btnlike = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.txtCom);
            this.panel3.Controls.Add(this.commentlbl);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnReport);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.btnComment);
            this.panel3.Controls.Add(this.btnlike);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(129, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 452);
            this.panel3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "comment!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(49, 416);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(301, 23);
            this.txtCom.TabIndex = 3;
            this.txtCom.Text = "Leave a comment!";
            // 
            // commentlbl
            // 
            this.commentlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.commentlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.commentlbl.ForeColor = System.Drawing.Color.White;
            this.commentlbl.Location = new System.Drawing.Point(49, 374);
            this.commentlbl.Name = "commentlbl";
            this.commentlbl.Size = new System.Drawing.Size(301, 25);
            this.commentlbl.TabIndex = 2;
            this.commentlbl.TextChanged += new System.EventHandler(this.commentlbl_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(208, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "@yolo";
            // 
            // btnReport
            // 
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Image = global::Virality.Properties.Resources.icons8_flag_24;
            this.btnReport.Location = new System.Drawing.Point(221, 320);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(34, 23);
            this.btnReport.TabIndex = 1;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Virality.Properties.Resources.icons8_user_24;
            this.pictureBox3.Location = new System.Drawing.Point(210, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnComment
            // 
            this.btnComment.FlatAppearance.BorderSize = 0;
            this.btnComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComment.Image = global::Virality.Properties.Resources.icons8_speech_24;
            this.btnComment.Location = new System.Drawing.Point(388, 320);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(34, 23);
            this.btnComment.TabIndex = 1;
            this.btnComment.UseVisualStyleBackColor = true;
            // 
            // btnlike
            // 
            this.btnlike.FlatAppearance.BorderSize = 0;
            this.btnlike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlike.Image = global::Virality.Properties.Resources.icons8_heart_24;
            this.btnlike.Location = new System.Drawing.Point(49, 320);
            this.btnlike.Name = "btnlike";
            this.btnlike.Size = new System.Drawing.Size(34, 23);
            this.btnlike.TabIndex = 1;
            this.btnlike.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(373, 218);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // frmFeedNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFeedNew";
            this.Text = "frmFeedNew";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private TextBox commentlbl;
        private Label label2;
        private Button btnReport;
        private PictureBox pictureBox3;
        private Button btnComment;
        private Button btnlike;
        private PictureBox pictureBox2;
        private Button button1;
        private TextBox txtCom;
    }
}