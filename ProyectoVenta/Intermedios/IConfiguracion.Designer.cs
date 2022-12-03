namespace ProyectoVenta.Intermedios
{
    partial class IConfiguracion
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
            this.btnusuarios = new FontAwesome.Sharp.IconButton();
            this.btnpermisos = new FontAwesome.Sharp.IconButton();
            this.btncerrar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnusuarios
            // 
            this.btnusuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnusuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnusuarios.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnusuarios.FlatAppearance.BorderSize = 2;
            this.btnusuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnusuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnusuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuarios.ForeColor = System.Drawing.Color.Black;
            this.btnusuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnusuarios.IconColor = System.Drawing.Color.Black;
            this.btnusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnusuarios.IconSize = 80;
            this.btnusuarios.Location = new System.Drawing.Point(29, 31);
            this.btnusuarios.Name = "btnusuarios";
            this.btnusuarios.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnusuarios.Size = new System.Drawing.Size(87, 92);
            this.btnusuarios.TabIndex = 122;
            this.btnusuarios.Text = "Usuarios";
            this.btnusuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnusuarios.UseVisualStyleBackColor = false;
            this.btnusuarios.Click += new System.EventHandler(this.btnusuarios_Click);
            // 
            // btnpermisos
            // 
            this.btnpermisos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnpermisos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpermisos.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnpermisos.FlatAppearance.BorderSize = 2;
            this.btnpermisos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnpermisos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnpermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpermisos.ForeColor = System.Drawing.Color.Black;
            this.btnpermisos.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            this.btnpermisos.IconColor = System.Drawing.Color.Black;
            this.btnpermisos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnpermisos.IconSize = 60;
            this.btnpermisos.Location = new System.Drawing.Point(156, 31);
            this.btnpermisos.Name = "btnpermisos";
            this.btnpermisos.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnpermisos.Size = new System.Drawing.Size(87, 92);
            this.btnpermisos.TabIndex = 124;
            this.btnpermisos.Text = "Permisos";
            this.btnpermisos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnpermisos.UseVisualStyleBackColor = false;
            this.btnpermisos.Click += new System.EventHandler(this.btnpermisos_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btncerrar.FlatAppearance.BorderSize = 2;
            this.btncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.Color.Black;
            this.btncerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btncerrar.IconColor = System.Drawing.Color.Black;
            this.btncerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncerrar.IconSize = 80;
            this.btncerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncerrar.Location = new System.Drawing.Point(284, 31);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(87, 92);
            this.btncerrar.TabIndex = 125;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // IConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 164);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnpermisos);
            this.Controls.Add(this.btnusuarios);
            this.Name = "IConfiguracion";
            this.Text = "IConfiguracion";
            this.Load += new System.EventHandler(this.IConfiguracion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnusuarios;
        private FontAwesome.Sharp.IconButton btnpermisos;
        private FontAwesome.Sharp.IconButton btncerrar;
    }
}