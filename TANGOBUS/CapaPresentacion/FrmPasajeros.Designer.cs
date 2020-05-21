namespace CapaPresentacion
{
    partial class FrmPasajeros
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPasajeros));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PbCerrar = new System.Windows.Forms.PictureBox();
            this.LblNacionalidad = new System.Windows.Forms.Label();
            this.LblMayor = new System.Windows.Forms.Label();
            this.LblAscenso = new System.Windows.Forms.Label();
            this.LblTelefonos = new System.Windows.Forms.Label();
            this.LblGrupo = new System.Windows.Forms.Label();
            this.LblDni = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtAscenso = new System.Windows.Forms.TextBox();
            this.txtMayor = new System.Windows.Forms.TextBox();
            this.txtTelefonos = new System.Windows.Forms.TextBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblDestino = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(605, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "..:: MANTENIMIENTO PASAJEROS ::..";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PbCerrar
            // 
            this.PbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.PbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("PbCerrar.Image")));
            this.PbCerrar.Location = new System.Drawing.Point(578, 4);
            this.PbCerrar.Name = "PbCerrar";
            this.PbCerrar.Size = new System.Drawing.Size(20, 20);
            this.PbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCerrar.TabIndex = 2;
            this.PbCerrar.TabStop = false;
            this.PbCerrar.Click += new System.EventHandler(this.PbCerrar_Click_1);
            // 
            // LblNacionalidad
            // 
            this.LblNacionalidad.AutoSize = true;
            this.LblNacionalidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNacionalidad.Location = new System.Drawing.Point(16, 161);
            this.LblNacionalidad.Name = "LblNacionalidad";
            this.LblNacionalidad.Size = new System.Drawing.Size(89, 17);
            this.LblNacionalidad.TabIndex = 18;
            this.LblNacionalidad.Text = "Nacionalidad";
            // 
            // LblMayor
            // 
            this.LblMayor.AutoSize = true;
            this.LblMayor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMayor.Location = new System.Drawing.Point(16, 239);
            this.LblMayor.Name = "LblMayor";
            this.LblMayor.Size = new System.Drawing.Size(45, 17);
            this.LblMayor.TabIndex = 17;
            this.LblMayor.Text = "Mayor";
            // 
            // LblAscenso
            // 
            this.LblAscenso.AutoSize = true;
            this.LblAscenso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAscenso.Location = new System.Drawing.Point(16, 187);
            this.LblAscenso.Name = "LblAscenso";
            this.LblAscenso.Size = new System.Drawing.Size(58, 17);
            this.LblAscenso.TabIndex = 16;
            this.LblAscenso.Text = "Ascenso";
            // 
            // LblTelefonos
            // 
            this.LblTelefonos.AutoSize = true;
            this.LblTelefonos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefonos.Location = new System.Drawing.Point(16, 213);
            this.LblTelefonos.Name = "LblTelefonos";
            this.LblTelefonos.Size = new System.Drawing.Size(64, 17);
            this.LblTelefonos.TabIndex = 15;
            this.LblTelefonos.Text = "Telefonos";
            // 
            // LblGrupo
            // 
            this.LblGrupo.AutoSize = true;
            this.LblGrupo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGrupo.Location = new System.Drawing.Point(16, 317);
            this.LblGrupo.Name = "LblGrupo";
            this.LblGrupo.Size = new System.Drawing.Size(45, 17);
            this.LblGrupo.TabIndex = 14;
            this.LblGrupo.Text = "Grupo";
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDni.Location = new System.Drawing.Point(16, 135);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(27, 17);
            this.LblDni.TabIndex = 13;
            this.LblDni.Text = "Dni";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombres.Location = new System.Drawing.Point(16, 109);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(61, 17);
            this.LblNombres.TabIndex = 12;
            this.LblNombres.Text = "Nombres";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidos.Location = new System.Drawing.Point(16, 83);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(63, 17);
            this.LblApellidos.TabIndex = 11;
            this.LblApellidos.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(111, 82);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(251, 20);
            this.txtApellidos.TabIndex = 19;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(111, 108);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(251, 20);
            this.txtNombres.TabIndex = 20;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(111, 134);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(251, 20);
            this.txtDni.TabIndex = 21;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(111, 160);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(251, 20);
            this.txtNacionalidad.TabIndex = 22;
            // 
            // txtAscenso
            // 
            this.txtAscenso.Location = new System.Drawing.Point(111, 186);
            this.txtAscenso.Name = "txtAscenso";
            this.txtAscenso.Size = new System.Drawing.Size(251, 20);
            this.txtAscenso.TabIndex = 23;
            // 
            // txtMayor
            // 
            this.txtMayor.Location = new System.Drawing.Point(111, 238);
            this.txtMayor.Name = "txtMayor";
            this.txtMayor.Size = new System.Drawing.Size(70, 20);
            this.txtMayor.TabIndex = 24;
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.Location = new System.Drawing.Point(111, 212);
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.Size = new System.Drawing.Size(251, 20);
            this.txtTelefonos.TabIndex = 25;
           
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(111, 316);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(70, 20);
            this.txtGrupo.TabIndex = 26;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardar.BorderRadius = 7;
            this.BtnGuardar.ButtonText = "GUARDAR";
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGuardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Iconimage")));
            this.BtnGuardar.Iconimage_right = null;
            this.BtnGuardar.Iconimage_right_Selected = null;
            this.BtnGuardar.Iconimage_Selected = null;
            this.BtnGuardar.IconMarginLeft = 0;
            this.BtnGuardar.IconMarginRight = 0;
            this.BtnGuardar.IconRightVisible = true;
            this.BtnGuardar.IconRightZoom = 0D;
            this.BtnGuardar.IconVisible = true;
            this.BtnGuardar.IconZoom = 50D;
            this.BtnGuardar.IsTab = false;
            this.BtnGuardar.Location = new System.Drawing.Point(182, 376);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.BtnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnGuardar.selected = false;
            this.BtnGuardar.Size = new System.Drawing.Size(200, 48);
            this.BtnGuardar.TabIndex = 20;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnGuardar.Textcolor = System.Drawing.Color.White;
            this.BtnGuardar.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelar.BorderRadius = 7;
            this.BtnCancelar.ButtonText = "CANCELAR";
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnCancelar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Iconimage")));
            this.BtnCancelar.Iconimage_right = null;
            this.BtnCancelar.Iconimage_right_Selected = null;
            this.BtnCancelar.Iconimage_Selected = null;
            this.BtnCancelar.IconMarginLeft = 0;
            this.BtnCancelar.IconMarginRight = 0;
            this.BtnCancelar.IconRightVisible = true;
            this.BtnCancelar.IconRightZoom = 0D;
            this.BtnCancelar.IconVisible = true;
            this.BtnCancelar.IconZoom = 50D;
            this.BtnCancelar.IsTab = false;
            this.BtnCancelar.Location = new System.Drawing.Point(388, 376);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.BtnCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.BtnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnCancelar.selected = false;
            this.BtnCancelar.Size = new System.Drawing.Size(200, 48);
            this.BtnCancelar.TabIndex = 27;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCancelar.Textcolor = System.Drawing.Color.White;
            this.BtnCancelar.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(111, 56);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(70, 20);
            this.txtCodigo.TabIndex = 28;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(16, 59);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(52, 17);
            this.LblCodigo.TabIndex = 29;
            this.LblCodigo.Text = "Codigo";
            this.LblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.lblTitulo;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(111, 264);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(120, 20);
            this.txtFecha.TabIndex = 31;
            
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(16, 265);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(79, 17);
            this.LblFecha.TabIndex = 30;
            this.LblFecha.Text = "Fecha Viaje";
            
            // 
            // LblDestino
            // 
            this.LblDestino.AutoSize = true;
            this.LblDestino.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDestino.Location = new System.Drawing.Point(16, 291);
            this.LblDestino.Name = "LblDestino";
            this.LblDestino.Size = new System.Drawing.Size(53, 17);
            this.LblDestino.TabIndex = 32;
            this.LblDestino.Text = "Destino";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(111, 290);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(251, 20);
            this.txtDestino.TabIndex = 33;
            // 
            // FrmPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 436);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.LblDestino);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.txtTelefonos);
            this.Controls.Add(this.txtMayor);
            this.Controls.Add(this.txtAscenso);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.LblNacionalidad);
            this.Controls.Add(this.LblMayor);
            this.Controls.Add(this.LblAscenso);
            this.Controls.Add(this.LblTelefonos);
            this.Controls.Add(this.LblGrupo);
            this.Controls.Add(this.LblDni);
            this.Controls.Add(this.LblNombres);
            this.Controls.Add(this.LblApellidos);
            this.Controls.Add(this.PbCerrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPasajeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPasajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PbCerrar;
        private System.Windows.Forms.Label LblNacionalidad;
        private System.Windows.Forms.Label LblMayor;
        private System.Windows.Forms.Label LblAscenso;
        private System.Windows.Forms.Label LblTelefonos;
        private System.Windows.Forms.Label LblGrupo;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Label LblApellidos;
        private Bunifu.Framework.UI.BunifuFlatButton BtnCancelar;
        public System.Windows.Forms.TextBox txtApellidos;
        public System.Windows.Forms.TextBox txtNombres;
        public System.Windows.Forms.TextBox txtDni;
        public System.Windows.Forms.TextBox txtNacionalidad;
        public System.Windows.Forms.TextBox txtAscenso;
        public System.Windows.Forms.TextBox txtMayor;
        public System.Windows.Forms.TextBox txtTelefonos;
        public System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label LblCodigo;
        public System.Windows.Forms.TextBox txtCodigo;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGuardar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label LblFecha;
        public System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label LblDestino;
    }
}

