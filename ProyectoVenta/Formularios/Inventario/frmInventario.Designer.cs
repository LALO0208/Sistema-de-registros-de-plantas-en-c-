namespace ProyectoVenta.Formularios.Inventario
{
    partial class frmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfechainicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfechafin = new System.Windows.Forms.DateTimePicker();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnexportar = new FontAwesome.Sharp.IconButton();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.btnborrar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtbuscarInventario = new System.Windows.Forms.TextBox();
            this.cbobuscarInventario = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, -2);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(1178, 41);
            this.label2.TabIndex = 146;
            this.label2.Text = "Inventario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 160;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 161;
            this.label4.Text = "Fecha Inicio:";
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.CustomFormat = "dd/MM/yyyy";
            this.txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechainicio.Location = new System.Drawing.Point(109, 42);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(97, 20);
            this.txtfechainicio.TabIndex = 162;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 163;
            this.label3.Text = "Fecha Fin:";
            // 
            // txtfechafin
            // 
            this.txtfechafin.CustomFormat = "dd/MM/yyyy";
            this.txtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechafin.Location = new System.Drawing.Point(304, 43);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(97, 20);
            this.txtfechafin.TabIndex = 164;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 17;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbuscar.Location = new System.Drawing.Point(424, 44);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(99, 21);
            this.btnbuscar.TabIndex = 165;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1113, 10);
            this.groupBox2.TabIndex = 166;
            this.groupBox2.TabStop = false;
            // 
            // btnexportar
            // 
            this.btnexportar.BackColor = System.Drawing.SystemColors.Control;
            this.btnexportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexportar.Font = new System.Drawing.Font("Inter", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnexportar.IconColor = System.Drawing.Color.LimeGreen;
            this.btnexportar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnexportar.IconSize = 17;
            this.btnexportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnexportar.Location = new System.Drawing.Point(43, 88);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(159, 30);
            this.btnexportar.TabIndex = 167;
            this.btnexportar.Text = "Descargar Excel";
            this.btnexportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportar.UseVisualStyleBackColor = false;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Location = new System.Drawing.Point(12, 124);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowTemplate.Height = 24;
            this.dgvdata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.Size = new System.Drawing.Size(964, 408);
            this.dgvdata.TabIndex = 173;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnsalir.IconColor = System.Drawing.Color.White;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnsalir.IconSize = 24;
            this.btnsalir.Location = new System.Drawing.Point(888, 4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(77, 31);
            this.btnsalir.TabIndex = 174;
            this.btnsalir.Text = "Volver";
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnborrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnborrar.IconColor = System.Drawing.Color.Black;
            this.btnborrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnborrar.IconSize = 20;
            this.btnborrar.Location = new System.Drawing.Point(921, 94);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnborrar.Size = new System.Drawing.Size(37, 21);
            this.btnborrar.TabIndex = 179;
            this.btnborrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnborrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnborrar.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 18;
            this.iconButton1.Location = new System.Drawing.Point(879, 94);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(37, 21);
            this.iconButton1.TabIndex = 178;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtbuscarInventario
            // 
            this.txtbuscarInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarInventario.Location = new System.Drawing.Point(739, 94);
            this.txtbuscarInventario.Name = "txtbuscarInventario";
            this.txtbuscarInventario.Size = new System.Drawing.Size(135, 21);
            this.txtbuscarInventario.TabIndex = 177;
            // 
            // cbobuscarInventario
            // 
            this.cbobuscarInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbobuscarInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobuscarInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobuscarInventario.FormattingEnabled = true;
            this.cbobuscarInventario.Location = new System.Drawing.Point(593, 94);
            this.cbobuscarInventario.Name = "cbobuscarInventario";
            this.cbobuscarInventario.Size = new System.Drawing.Size(140, 21);
            this.cbobuscarInventario.TabIndex = 176;
            this.cbobuscarInventario.SelectedIndexChanged += new System.EventHandler(this.cbobuscarInventario_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightCyan;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(518, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 15);
            this.label12.TabIndex = 175;
            this.label12.Text = "Buscar por:";
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 544);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txtbuscarInventario);
            this.Controls.Add(this.cbobuscarInventario);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtfechafin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfechainicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Name = "frmInventario";
            this.Text = "frmInventario";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtfechainicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtfechafin;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnexportar;
        private System.Windows.Forms.DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btnborrar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtbuscarInventario;
        private System.Windows.Forms.ComboBox cbobuscarInventario;
        private System.Windows.Forms.Label label12;
    }
}