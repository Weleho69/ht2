
namespace HarjoitusTyo2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSivunav = new System.Windows.Forms.Panel();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNappiContainer = new System.Windows.Forms.Panel();
            this.btnSulje = new System.Windows.Forms.Button();
            this.btnLogInfo = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panelYlanav = new System.Windows.Forms.Panel();
            this.panelViiva = new System.Windows.Forms.Panel();
            this.panelViivaVasen = new System.Windows.Forms.Panel();
            this.panelFormContainer = new System.Windows.Forms.Panel();
            this.panelKortti = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.poistaBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelSivunav.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelNappiContainer.SuspendLayout();
            this.panelFormContainer.SuspendLayout();
            this.panelKortti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSivunav
            // 
            this.panelSivunav.BackColor = System.Drawing.Color.White;
            this.panelSivunav.Controls.Add(this.PanelLogo);
            this.panelSivunav.Controls.Add(this.panelNappiContainer);
            this.panelSivunav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSivunav.Location = new System.Drawing.Point(0, 0);
            this.panelSivunav.Name = "panelSivunav";
            this.panelSivunav.Size = new System.Drawing.Size(185, 636);
            this.panelSivunav.TabIndex = 0;
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.Transparent;
            this.PanelLogo.Controls.Add(this.pictureBox1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(185, 72);
            this.PanelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelNappiContainer
            // 
            this.panelNappiContainer.AutoScroll = true;
            this.panelNappiContainer.Controls.Add(this.btnSulje);
            this.panelNappiContainer.Controls.Add(this.btnLogInfo);
            this.panelNappiContainer.Controls.Add(this.btn1);
            this.panelNappiContainer.Controls.Add(this.btnAddUser);
            this.panelNappiContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNappiContainer.Location = new System.Drawing.Point(0, 0);
            this.panelNappiContainer.Name = "panelNappiContainer";
            this.panelNappiContainer.Size = new System.Drawing.Size(185, 636);
            this.panelNappiContainer.TabIndex = 1;
            // 
            // btnSulje
            // 
            this.btnSulje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSulje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSulje.Location = new System.Drawing.Point(0, 586);
            this.btnSulje.Name = "btnSulje";
            this.btnSulje.Size = new System.Drawing.Size(185, 50);
            this.btnSulje.TabIndex = 5;
            this.btnSulje.Text = "Sulje ohjelma";
            this.btnSulje.UseVisualStyleBackColor = true;
            this.btnSulje.Click += new System.EventHandler(this.btnSulje_Click);
            // 
            // btnLogInfo
            // 
            this.btnLogInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogInfo.Location = new System.Drawing.Point(22, 227);
            this.btnLogInfo.Name = "btnLogInfo";
            this.btnLogInfo.Size = new System.Drawing.Size(140, 50);
            this.btnLogInfo.TabIndex = 4;
            this.btnLogInfo.Text = "Lokitiedot";
            this.btnLogInfo.UseVisualStyleBackColor = true;
            this.btnLogInfo.Click += new System.EventHandler(this.btnLogInfo_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(22, 105);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(140, 50);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Etusivu";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.Location = new System.Drawing.Point(22, 165);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(140, 50);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Lisää käyttäjä";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // panelYlanav
            // 
            this.panelYlanav.BackColor = System.Drawing.Color.White;
            this.panelYlanav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelYlanav.Location = new System.Drawing.Point(185, 0);
            this.panelYlanav.Name = "panelYlanav";
            this.panelYlanav.Size = new System.Drawing.Size(1440, 72);
            this.panelYlanav.TabIndex = 1;
            // 
            // panelViiva
            // 
            this.panelViiva.BackColor = System.Drawing.Color.Transparent;
            this.panelViiva.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelViiva.Location = new System.Drawing.Point(185, 72);
            this.panelViiva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelViiva.Name = "panelViiva";
            this.panelViiva.Size = new System.Drawing.Size(1440, 8);
            this.panelViiva.TabIndex = 0;
            // 
            // panelViivaVasen
            // 
            this.panelViivaVasen.BackColor = System.Drawing.Color.Transparent;
            this.panelViivaVasen.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelViivaVasen.Location = new System.Drawing.Point(185, 80);
            this.panelViivaVasen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelViivaVasen.Name = "panelViivaVasen";
            this.panelViivaVasen.Size = new System.Drawing.Size(9, 556);
            this.panelViivaVasen.TabIndex = 3;
            // 
            // panelFormContainer
            // 
            this.panelFormContainer.Controls.Add(this.panelKortti);
            this.panelFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormContainer.Location = new System.Drawing.Point(194, 80);
            this.panelFormContainer.Name = "panelFormContainer";
            this.panelFormContainer.Size = new System.Drawing.Size(1431, 556);
            this.panelFormContainer.TabIndex = 4;
            // 
            // panelKortti
            // 
            this.panelKortti.Controls.Add(this.button2);
            this.panelKortti.Controls.Add(this.poistaBtn);
            this.panelKortti.Controls.Add(this.dataGridView1);
            this.panelKortti.Location = new System.Drawing.Point(22, 25);
            this.panelKortti.Name = "panelKortti";
            this.panelKortti.Size = new System.Drawing.Size(1381, 519);
            this.panelKortti.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(14, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "Tallenna";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // poistaBtn
            // 
            this.poistaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poistaBtn.Location = new System.Drawing.Point(191, 21);
            this.poistaBtn.Name = "poistaBtn";
            this.poistaBtn.Size = new System.Drawing.Size(124, 26);
            this.poistaBtn.TabIndex = 1;
            this.poistaBtn.Text = "Poista Käyttäjä";
            this.poistaBtn.UseVisualStyleBackColor = true;
            this.poistaBtn.Click += new System.EventHandler(this.poistaBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1347, 442);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGV_Keypress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 636);
            this.Controls.Add(this.panelFormContainer);
            this.Controls.Add(this.panelViivaVasen);
            this.Controls.Add(this.panelViiva);
            this.Controls.Add(this.panelYlanav);
            this.Controls.Add(this.panelSivunav);
            this.Name = "Form1";
            this.Text = "Savonia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSivunav.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelNappiContainer.ResumeLayout(false);
            this.panelFormContainer.ResumeLayout(false);
            this.panelKortti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSivunav;
        private System.Windows.Forms.Panel panelYlanav;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Panel panelNappiContainer;
        private System.Windows.Forms.Button btnLogInfo;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelViiva;
        private System.Windows.Forms.Panel panelViivaVasen;
        private System.Windows.Forms.Panel panelFormContainer;
        private System.Windows.Forms.Panel panelKortti;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button poistaBtn;
        private System.Windows.Forms.Button btnSulje;
    }
}

