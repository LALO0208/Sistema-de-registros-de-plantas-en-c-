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
            this.label2 = new System.Windows.Forms.Label();
            this.btnagregarproductos = new FontAwesome.Sharp.IconButton();
            this.btnvolver = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 192);
            this.label2.TabIndex = 130;
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
            this.btnagregarproductos.Location = new System.Drawing.Point(98, 56);
            this.btnagregarproductos.Name = "btnagregarproductos";
            this.btnagregarproductos.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnagregarproductos.Size = new System.Drawing.Size(87, 92);
            this.btnagregarproductos.TabIndex = 131;
            this.btnagregarproductos.Text = "Nuevo";
            this.btnagregarproductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnagregarproductos.UseVisualStyleBackColor = false;
            this.btnagregarproductos.Click += new System.EventHandler(this.btnagregarproductos_Click_1);
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
            this.btnvolver.Location = new System.Drawing.Point(279, 56);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(87, 92);
            this.btnvolver.TabIndex = 132;
            this.btnvolver.Text = "Cerrar";
            this.btnvolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 133;
            this.label7.Text = "PLANTAS";
            // 
            // IProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(442, 205);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnagregarproductos);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IProductos";
            this.Load += new System.EventHandler(this.IProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnagregarproductos;
        private FontAwesome.Sharp.IconButton btnvolver;
        private System.Windows.Forms.Label label7;
    }
}