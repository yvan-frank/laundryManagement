namespace View
{
    partial class Connexion_in
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion_in));
            this.panAdmin = new Guna.UI.WinForms.GunaPanel();
            this.panGerant = new System.Windows.Forms.Panel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.chkMdp = new Guna.UI.WinForms.GunaCheckBox();
            this.btnConn = new Guna.UI.WinForms.GunaButton();
            this.lblId = new Guna.UI.WinForms.GunaLabel();
            this.lblMdp = new Guna.UI.WinForms.GunaLabel();
            this.btnQuit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnGerant = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btnAdmin = new Guna.UI.WinForms.GunaGradientTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMdp = new Guna.UI.WinForms.GunaTextBox();
            this.txtId = new Guna.UI.WinForms.GunaTextBox();
            this.picGerant = new System.Windows.Forms.PictureBox();
            this.panAdmin.SuspendLayout();
            this.panGerant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGerant)).BeginInit();
            this.SuspendLayout();
            // 
            // panAdmin
            // 
            this.panAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(44)))));
            this.panAdmin.Controls.Add(this.picGerant);
            this.panAdmin.Controls.Add(this.txtMdp);
            this.panAdmin.Controls.Add(this.txtId);
            this.panAdmin.Controls.Add(this.gunaPictureBox1);
            this.panAdmin.Controls.Add(this.chkMdp);
            this.panAdmin.Controls.Add(this.btnConn);
            this.panAdmin.Controls.Add(this.lblId);
            this.panAdmin.Controls.Add(this.lblMdp);
            this.panAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panAdmin.Location = new System.Drawing.Point(0, 0);
            this.panAdmin.Name = "panAdmin";
            this.panAdmin.Size = new System.Drawing.Size(473, 509);
            this.panAdmin.TabIndex = 4;
            this.panAdmin.Visible = false;
            // 
            // panGerant
            // 
            this.panGerant.Controls.Add(this.btnQuit);
            this.panGerant.Controls.Add(this.btnGerant);
            this.panGerant.Controls.Add(this.btnAdmin);
            this.panGerant.Dock = System.Windows.Forms.DockStyle.Right;
            this.panGerant.Location = new System.Drawing.Point(469, 0);
            this.panGerant.Name = "panGerant";
            this.panGerant.Size = new System.Drawing.Size(446, 509);
            this.panGerant.TabIndex = 5;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(204, 43);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Radius = 20;
            this.gunaPictureBox1.Size = new System.Drawing.Size(120, 76);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 14;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Visible = false;
            // 
            // chkMdp
            // 
            this.chkMdp.BaseColor = System.Drawing.Color.White;
            this.chkMdp.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkMdp.CheckedOnColor = System.Drawing.Color.Teal;
            this.chkMdp.FillColor = System.Drawing.Color.White;
            this.chkMdp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMdp.ForeColor = System.Drawing.Color.White;
            this.chkMdp.Location = new System.Drawing.Point(204, 318);
            this.chkMdp.Name = "chkMdp";
            this.chkMdp.Size = new System.Drawing.Size(156, 21);
            this.chkMdp.TabIndex = 13;
            this.chkMdp.Text = "Mot de passe oublié?";
            this.chkMdp.CheckedChanged += new System.EventHandler(this.chkMdp_CheckedChanged);
            // 
            // btnConn
            // 
            this.btnConn.AnimationHoverSpeed = 0.07F;
            this.btnConn.AnimationSpeed = 0.03F;
            this.btnConn.BackColor = System.Drawing.Color.Transparent;
            this.btnConn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(11)))), ((int)(((byte)(74)))));
            this.btnConn.BorderColor = System.Drawing.Color.Black;
            this.btnConn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConn.FocusedColor = System.Drawing.Color.Empty;
            this.btnConn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConn.ForeColor = System.Drawing.Color.White;
            this.btnConn.Image = null;
            this.btnConn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConn.Location = new System.Drawing.Point(204, 389);
            this.btnConn.Name = "btnConn";
            this.btnConn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.btnConn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConn.OnHoverImage = null;
            this.btnConn.OnPressedColor = System.Drawing.Color.Black;
            this.btnConn.Radius = 20;
            this.btnConn.Size = new System.Drawing.Size(233, 42);
            this.btnConn.TabIndex = 12;
            this.btnConn.Text = "Connexion";
            this.btnConn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(15, 185);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(107, 25);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "Identifiant:";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.ForeColor = System.Drawing.Color.White;
            this.lblMdp.Location = new System.Drawing.Point(15, 240);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(131, 25);
            this.lblMdp.TabIndex = 8;
            this.lblMdp.Text = "Mot de passe:";
            // 
            // btnQuit
            // 
            this.btnQuit.AnimationHoverSpeed = 0.07F;
            this.btnQuit.AnimationSpeed = 0.03F;
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQuit.BorderColor = System.Drawing.Color.Black;
            this.btnQuit.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnQuit.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnQuit.CheckedForeColor = System.Drawing.Color.White;
            this.btnQuit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnQuit.CheckedImage")));
            this.btnQuit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnQuit.FocusedColor = System.Drawing.Color.Empty;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnQuit.LineBottom = 25;
            this.btnQuit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnQuit.LineLeft = 6;
            this.btnQuit.LineRight = 6;
            this.btnQuit.LineTop = 25;
            this.btnQuit.Location = new System.Drawing.Point(95, 455);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnQuit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnQuit.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnQuit.OnHoverImage = null;
            this.btnQuit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQuit.OnPressedColor = System.Drawing.Color.Black;
            this.btnQuit.Radius = 25;
            this.btnQuit.Size = new System.Drawing.Size(253, 42);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click_1);
            // 
            // btnGerant
            // 
            this.btnGerant.AnimationHoverSpeed = 0.07F;
            this.btnGerant.AnimationSpeed = 0.03F;
            this.btnGerant.BackColor = System.Drawing.Color.Transparent;
            this.btnGerant.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGerant.BaseColor2 = System.Drawing.Color.Teal;
            this.btnGerant.BorderColor = System.Drawing.Color.Black;
            this.btnGerant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerant.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGerant.FocusedColor = System.Drawing.Color.Empty;
            this.btnGerant.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerant.ForeColor = System.Drawing.Color.White;
            this.btnGerant.Image = ((System.Drawing.Image)(resources.GetObject("btnGerant.Image")));
            this.btnGerant.ImageSize = new System.Drawing.Size(52, 52);
            this.btnGerant.Location = new System.Drawing.Point(95, 202);
            this.btnGerant.Name = "btnGerant";
            this.btnGerant.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGerant.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGerant.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGerant.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGerant.OnHoverImage = null;
            this.btnGerant.OnPressedColor = System.Drawing.Color.Black;
            this.btnGerant.Radius = 25;
            this.btnGerant.Size = new System.Drawing.Size(253, 160);
            this.btnGerant.TabIndex = 5;
            this.btnGerant.Text = "Gérant";
            this.btnGerant.Click += new System.EventHandler(this.btnGerant_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.AnimationHoverSpeed = 0.07F;
            this.btnAdmin.AnimationSpeed = 0.03F;
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdmin.BaseColor2 = System.Drawing.Color.Green;
            this.btnAdmin.BorderColor = System.Drawing.Color.Black;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdmin.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageSize = new System.Drawing.Size(52, 52);
            this.btnAdmin.Location = new System.Drawing.Point(95, 12);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdmin.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdmin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdmin.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAdmin.OnHoverImage = null;
            this.btnAdmin.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdmin.Radius = 25;
            this.btnAdmin.Size = new System.Drawing.Size(253, 160);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Administrateur";
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palace Script MT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "Authentifiez vous!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMdp
            // 
            this.txtMdp.BaseColor = System.Drawing.Color.White;
            this.txtMdp.BorderColor = System.Drawing.Color.Silver;
            this.txtMdp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMdp.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMdp.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMdp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMdp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMdp.Location = new System.Drawing.Point(204, 240);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '\0';
            this.txtMdp.SelectedText = "";
            this.txtMdp.Size = new System.Drawing.Size(233, 30);
            this.txtMdp.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.BaseColor = System.Drawing.Color.White;
            this.txtId.BorderColor = System.Drawing.Color.Silver;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.FocusedBaseColor = System.Drawing.Color.White;
            this.txtId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(204, 185);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(233, 30);
            this.txtId.TabIndex = 15;
            // 
            // picGerant
            // 
            this.picGerant.Image = ((System.Drawing.Image)(resources.GetObject("picGerant.Image")));
            this.picGerant.Location = new System.Drawing.Point(179, 47);
            this.picGerant.Name = "picGerant";
            this.picGerant.Size = new System.Drawing.Size(181, 72);
            this.picGerant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGerant.TabIndex = 17;
            this.picGerant.TabStop = false;
            this.picGerant.Visible = false;
            // 
            // Connexion_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(915, 509);
            this.Controls.Add(this.panGerant);
            this.Controls.Add(this.panAdmin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Connexion_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pressing";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.panAdmin.ResumeLayout(false);
            this.panAdmin.PerformLayout();
            this.panGerant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGerant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel panAdmin;
        private System.Windows.Forms.Panel panGerant;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaCheckBox chkMdp;
        private Guna.UI.WinForms.GunaButton btnConn;
        private Guna.UI.WinForms.GunaLabel lblId;
        private Guna.UI.WinForms.GunaLabel lblMdp;
        private Guna.UI.WinForms.GunaAdvenceButton btnQuit;
        private Guna.UI.WinForms.GunaGradientTileButton btnGerant;
        private Guna.UI.WinForms.GunaGradientTileButton btnAdmin;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtMdp;
        private Guna.UI.WinForms.GunaTextBox txtId;
        private System.Windows.Forms.PictureBox picGerant;
    }
}

