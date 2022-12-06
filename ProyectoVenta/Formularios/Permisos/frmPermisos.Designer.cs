namespace ProyectoVenta.Formularios.Permisos
{
    partial class frmPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermisos));
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnguardaradministrador = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.a_configuracion = new System.Windows.Forms.CheckBox();
            this.a_inventario = new System.Windows.Forms.CheckBox();
            this.a_productos = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnguardarempleados = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.e_configuracion = new System.Windows.Forms.CheckBox();
            this.e_inventario = new System.Windows.Forms.CheckBox();
            this.e_productos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 2);
            this.label3.MaximumSize = new System.Drawing.Size(416, 41);
            this.label3.MinimumSize = new System.Drawing.Size(416, 41);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(416, 41);
            this.label3.TabIndex = 160;
            this.label3.Text = "Permisos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(22, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 15);
            this.label6.TabIndex = 162;
            this.label6.Text = "Permisos Administrador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 166;
            this.pictureBox1.TabStop = false;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Red;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnsalir.IconColor = System.Drawing.Color.White;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnsalir.IconSize = 24;
            this.btnsalir.Location = new System.Drawing.Point(330, 8);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(77, 31);
            this.btnsalir.TabIndex = 167;
            this.btnsalir.Text = "Volver";
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(250, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 168;
            this.label1.Text = "Permisos Empleado";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnguardaradministrador);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.a_configuracion);
            this.groupBox1.Controls.Add(this.a_inventario);
            this.groupBox1.Controls.Add(this.a_productos);
            this.groupBox1.Location = new System.Drawing.Point(9, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 238);
            this.groupBox1.TabIndex = 169;
            this.groupBox1.TabStop = false;
            // 
            // btnguardaradministrador
            // 
            this.btnguardaradministrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardaradministrador.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnguardaradministrador.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardaradministrador.IconColor = System.Drawing.Color.Black;
            this.btnguardaradministrador.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnguardaradministrador.IconSize = 17;
            this.btnguardaradministrador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguardaradministrador.Location = new System.Drawing.Point(20, 156);
            this.btnguardaradministrador.Name = "btnguardaradministrador";
            this.btnguardaradministrador.Size = new System.Drawing.Size(142, 23);
            this.btnguardaradministrador.TabIndex = 146;
            this.btnguardaradministrador.Text = "Guardar Cambios";
            this.btnguardaradministrador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardaradministrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardaradministrador.UseVisualStyleBackColor = true;
            this.btnguardaradministrador.Click += new System.EventHandler(this.btnguardaradministrador_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 145;
            this.label5.Text = "Menú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 144;
            this.label2.Text = "Activar";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(16, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 10);
            this.groupBox2.TabIndex = 143;
            this.groupBox2.TabStop = false;
            // 
            // a_configuracion
            // 
            this.a_configuracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a_configuracion.Location = new System.Drawing.Point(20, 81);
            this.a_configuracion.Name = "a_configuracion";
            this.a_configuracion.Size = new System.Drawing.Size(146, 24);
            this.a_configuracion.TabIndex = 13;
            this.a_configuracion.Text = "Configuracion";
            this.a_configuracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.a_configuracion.UseVisualStyleBackColor = true;
            // 
            // a_inventario
            // 
            this.a_inventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a_inventario.Location = new System.Drawing.Point(20, 63);
            this.a_inventario.Name = "a_inventario";
            this.a_inventario.Size = new System.Drawing.Size(146, 24);
            this.a_inventario.TabIndex = 12;
            this.a_inventario.Text = "Inventario";
            this.a_inventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.a_inventario.UseVisualStyleBackColor = true;
            // 
            // a_productos
            // 
            this.a_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a_productos.Location = new System.Drawing.Point(20, 45);
            this.a_productos.Name = "a_productos";
            this.a_productos.Size = new System.Drawing.Size(146, 24);
            this.a_productos.TabIndex = 9;
            this.a_productos.Text = "Productos";
            this.a_productos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.a_productos.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnguardarempleados);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.e_configuracion);
            this.groupBox3.Controls.Add(this.e_inventario);
            this.groupBox3.Controls.Add(this.e_productos);
            this.groupBox3.Location = new System.Drawing.Point(225, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 238);
            this.groupBox3.TabIndex = 170;
            this.groupBox3.TabStop = false;
            // 
            // btnguardarempleados
            // 
            this.btnguardarempleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarempleados.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnguardarempleados.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardarempleados.IconColor = System.Drawing.Color.Black;
            this.btnguardarempleados.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnguardarempleados.IconSize = 17;
            this.btnguardarempleados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguardarempleados.Location = new System.Drawing.Point(15, 156);
            this.btnguardarempleados.Name = "btnguardarempleados";
            this.btnguardarempleados.Size = new System.Drawing.Size(146, 23);
            this.btnguardarempleados.TabIndex = 147;
            this.btnguardarempleados.Text = "Guardar Cambios";
            this.btnguardarempleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardarempleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardarempleados.UseVisualStyleBackColor = true;
            this.btnguardarempleados.Click += new System.EventHandler(this.btnguardarempleados_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 145;
            this.label7.Text = "Menú";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 144;
            this.label8.Text = "Activar";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(15, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(149, 10);
            this.groupBox4.TabIndex = 143;
            this.groupBox4.TabStop = false;
            // 
            // e_configuracion
            // 
            this.e_configuracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.e_configuracion.Location = new System.Drawing.Point(18, 81);
            this.e_configuracion.Name = "e_configuracion";
            this.e_configuracion.Size = new System.Drawing.Size(146, 24);
            this.e_configuracion.TabIndex = 13;
            this.e_configuracion.Text = "Configuracion";
            this.e_configuracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.e_configuracion.UseVisualStyleBackColor = true;
            // 
            // e_inventario
            // 
            this.e_inventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.e_inventario.Location = new System.Drawing.Point(18, 63);
            this.e_inventario.Name = "e_inventario";
            this.e_inventario.Size = new System.Drawing.Size(146, 24);
            this.e_inventario.TabIndex = 12;
            this.e_inventario.Text = "Inventario";
            this.e_inventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.e_inventario.UseVisualStyleBackColor = true;
            // 
            // e_productos
            // 
            this.e_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.e_productos.Location = new System.Drawing.Point(18, 45);
            this.e_productos.Name = "e_productos";
            this.e_productos.Size = new System.Drawing.Size(146, 24);
            this.e_productos.TabIndex = 9;
            this.e_productos.Text = "Productos";
            this.e_productos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.e_productos.UseVisualStyleBackColor = true;
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 300);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Name = "frmPermisos";
            this.Text = "frmPermisos";
            this.Load += new System.EventHandler(this.frmPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnsalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnguardaradministrador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox a_configuracion;
        private System.Windows.Forms.CheckBox a_inventario;
        private System.Windows.Forms.CheckBox a_productos;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btnguardarempleados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox e_configuracion;
        private System.Windows.Forms.CheckBox e_inventario;
        private System.Windows.Forms.CheckBox e_productos;
    }
}