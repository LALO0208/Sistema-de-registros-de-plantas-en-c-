namespace ProyectoVenta.Intermedios
{
    partial class IProductos
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
            this.btnagregarproductos = new FontAwesome.Sharp.IconButton();
            this.btnvolver = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnagregarproductos
            // 
            this.btnagregarproductos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnagregarproductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarproductos.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnagregarproductos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnagregarproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnagregarproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarproductos.ForeColor = System.Drawing.Color.Black;
            this.btnagregarproductos.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnagregarproductos.IconColor = System.Drawing.Color.Black;
            this.btnagregarproductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregarproductos.IconSize = 80;
            this.btnagregarproductos.Location = new System.Drawing.Point(67, 32);
            this.btnagregarproductos.Name = "btnagregarproductos";
            this.btnagregarproductos.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnagregarproductos.Size = new System.Drawing.Size(87, 92);
            this.btnagregarproductos.TabIndex = 4;
            this.btnagregarproductos.Text = "Nuevo";
            this.btnagregarproductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnagregarproductos.UseVisualStyleBackColor = false;
            this.btnagregarproductos.Click += new System.EventHandler(this.btnagregarproductos_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnvolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvolver.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnvolver.FlatAppearance.BorderSize = 2;
            this.btnvolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnvolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.ForeColor = System.Drawing.Color.Black;
            this.btnvolver.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnvolver.IconColor = System.Drawing.Color.Black;
            this.btnvolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnvolver.IconSize = 80;
            this.btnvolver.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnvolver.Location = new System.Drawing.Point(231, 32);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(87, 92);
            this.btnvolver.TabIndex = 5;
            this.btnvolver.Text = "Cerrar";
            this.btnvolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // IProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 163);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnagregarproductos);
            this.Name = "IProductos";
            this.Text = "IProductos";
            this.Load += new System.EventHandler(this.IProductos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnagregarproductos;
        private FontAwesome.Sharp.IconButton btnvolver;
    }
}