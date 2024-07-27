namespace Virality
{
    partial class frmProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfile));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user_namelbl = new System.Windows.Forms.Label();
            this.biolbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnEditpf = new System.Windows.Forms.Button();
            this.btnDeleteposts = new System.Windows.Forms.Button();
            this.btnAddp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Virality.Properties.Resources.icons8_user_24;
            this.pictureBox1.Location = new System.Drawing.Point(331, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // user_namelbl
            // 
            this.user_namelbl.AutoSize = true;
            this.user_namelbl.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.user_namelbl.ForeColor = System.Drawing.Color.White;
            this.user_namelbl.Location = new System.Drawing.Point(340, 80);
            this.user_namelbl.Name = "user_namelbl";
            this.user_namelbl.Size = new System.Drawing.Size(47, 15);
            this.user_namelbl.TabIndex = 2;
            this.user_namelbl.Text = "@yolo";
            this.user_namelbl.Click += new System.EventHandler(this.user_namelbl_Click);
            // 
            // biolbl
            // 
            this.biolbl.AutoSize = true;
            this.biolbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.biolbl.ForeColor = System.Drawing.Color.White;
            this.biolbl.Location = new System.Drawing.Point(316, 112);
            this.biolbl.Name = "biolbl";
            this.biolbl.Size = new System.Drawing.Size(92, 13);
            this.biolbl.TabIndex = 3;
            this.biolbl.Text = "Just having fun!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(112, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 349);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Virality.Properties.Resources.Phone_Holder;
            this.pictureBox4.InitialImage = global::Virality.Properties.Resources.Bed_Clip;
            this.pictureBox4.Location = new System.Drawing.Point(18, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(246, 158);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pictureBox3.Image = global::Virality.Properties.Resources.torsion_coil_holder;
            this.pictureBox3.InitialImage = global::Virality.Properties.Resources.Bed_Clip;
            this.pictureBox3.Location = new System.Drawing.Point(270, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(231, 158);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = global::Virality.Properties.Resources.Bed_Clip;
            this.pictureBox5.Location = new System.Drawing.Point(270, 181);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(231, 156);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Virality.Properties.Resources.Bed_Clip;
            this.pictureBox2.InitialImage = global::Virality.Properties.Resources.Bed_Clip;
            this.pictureBox2.Location = new System.Drawing.Point(18, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnEditpf
            // 
            this.btnEditpf.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEditpf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditpf.Location = new System.Drawing.Point(408, 37);
            this.btnEditpf.Name = "btnEditpf";
            this.btnEditpf.Size = new System.Drawing.Size(87, 24);
            this.btnEditpf.TabIndex = 5;
            this.btnEditpf.Text = "Edit Profile";
            this.btnEditpf.UseVisualStyleBackColor = false;
            this.btnEditpf.Click += new System.EventHandler(this.btnEditpf_Click);
            // 
            // btnDeleteposts
            // 
            this.btnDeleteposts.BackColor = System.Drawing.Color.Red;
            this.btnDeleteposts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteposts.Location = new System.Drawing.Point(207, 37);
            this.btnDeleteposts.Name = "btnDeleteposts";
            this.btnDeleteposts.Size = new System.Drawing.Size(99, 24);
            this.btnDeleteposts.TabIndex = 5;
            this.btnDeleteposts.Text = "Delete Posts";
            this.btnDeleteposts.UseVisualStyleBackColor = false;
            this.btnDeleteposts.Click += new System.EventHandler(this.btnDeleteposts_Click);
            // 
            // btnAddp
            // 
            this.btnAddp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddp.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddp.Location = new System.Drawing.Point(408, 80);
            this.btnAddp.Name = "btnAddp";
            this.btnAddp.Size = new System.Drawing.Size(87, 29);
            this.btnAddp.TabIndex = 6;
            this.btnAddp.Text = "Add Posts";
            this.btnAddp.UseVisualStyleBackColor = false;
            this.btnAddp.Click += new System.EventHandler(this.btnAddp_Click);
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.btnAddp);
            this.Controls.Add(this.btnDeleteposts);
            this.Controls.Add(this.btnEditpf);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.biolbl);
            this.Controls.Add(this.user_namelbl);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfile";
            this.Text = "frmProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label user_namelbl;
        private Label biolbl;
        private Panel panel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private Button btnEditpf;
        private Button btnDeleteposts;
        private Button btnAddp;
    }
}