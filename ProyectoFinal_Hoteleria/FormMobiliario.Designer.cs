
namespace ProyectoFinal_Hoteleria
{
    partial class FormMobiliario
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.lvHabitacionesTraslado = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cardCliente = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodHabitacion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodMobiliario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lblCodHabitacion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lvMobiliario = new MaterialSkin.Controls.MaterialListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.cardCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvHabitacionesTraslado
            // 
            this.lvHabitacionesTraslado.AutoSizeTable = false;
            this.lvHabitacionesTraslado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvHabitacionesTraslado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvHabitacionesTraslado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader9});
            this.lvHabitacionesTraslado.Depth = 0;
            this.lvHabitacionesTraslado.FullRowSelect = true;
            this.lvHabitacionesTraslado.HideSelection = false;
            listViewItem3.StateImageIndex = 0;
            this.lvHabitacionesTraslado.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.lvHabitacionesTraslado.Location = new System.Drawing.Point(4, 16);
            this.lvHabitacionesTraslado.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvHabitacionesTraslado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvHabitacionesTraslado.MouseState = MaterialSkin.MouseState.OUT;
            this.lvHabitacionesTraslado.MultiSelect = false;
            this.lvHabitacionesTraslado.Name = "lvHabitacionesTraslado";
            this.lvHabitacionesTraslado.OwnerDraw = true;
            this.lvHabitacionesTraslado.Size = new System.Drawing.Size(240, 268);
            this.lvHabitacionesTraslado.TabIndex = 23;
            this.lvHabitacionesTraslado.UseCompatibleStateImageBehavior = false;
            this.lvHabitacionesTraslado.View = System.Windows.Forms.View.Details;
            this.lvHabitacionesTraslado.SelectedIndexChanged += new System.EventHandler(this.lvHabitacionesTraslado_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Cod. Habitación";
            this.columnHeader7.Width = 135;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Cod. Hotel";
            this.columnHeader9.Width = 100;
            // 
            // cardCliente
            // 
            this.cardCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardCliente.Controls.Add(this.pictureBox8);
            this.cardCliente.Controls.Add(this.pictureBox4);
            this.cardCliente.Controls.Add(this.label16);
            this.cardCliente.Controls.Add(this.txtDescripcion);
            this.cardCliente.Controls.Add(this.txtCodHabitacion);
            this.cardCliente.Controls.Add(this.txtPrecio);
            this.cardCliente.Controls.Add(this.label7);
            this.cardCliente.Controls.Add(this.label6);
            this.cardCliente.Controls.Add(this.label5);
            this.cardCliente.Controls.Add(this.txtCodMobiliario);
            this.cardCliente.Controls.Add(this.label4);
            this.cardCliente.Controls.Add(this.label3);
            this.cardCliente.Controls.Add(this.txtCodigo);
            this.cardCliente.Depth = 0;
            this.cardCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardCliente.Location = new System.Drawing.Point(20, 412);
            this.cardCliente.Margin = new System.Windows.Forms.Padding(14);
            this.cardCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardCliente.Name = "cardCliente";
            this.cardCliente.Padding = new System.Windows.Forms.Padding(14);
            this.cardCliente.Size = new System.Drawing.Size(730, 313);
            this.cardCliente.TabIndex = 25;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::ProyectoFinal_Hoteleria.Properties.Resources.sofa;
            this.pictureBox8.Location = new System.Drawing.Point(675, 16);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(38, 36);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 31;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProyectoFinal_Hoteleria.Properties.Resources.circle;
            this.pictureBox4.Location = new System.Drawing.Point(951, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(25, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(199, 21);
            this.label16.TabIndex = 23;
            this.label16.Text = "Detalle del mobiliario";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDescripcion.Location = new System.Drawing.Point(26, 196);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(427, 55);
            this.txtDescripcion.TabIndex = 14;
            // 
            // txtCodHabitacion
            // 
            this.txtCodHabitacion.Enabled = false;
            this.txtCodHabitacion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCodHabitacion.Location = new System.Drawing.Point(251, 116);
            this.txtCodHabitacion.Name = "txtCodHabitacion";
            this.txtCodHabitacion.Size = new System.Drawing.Size(202, 20);
            this.txtCodHabitacion.TabIndex = 9;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(497, 231);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(202, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(494, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(248, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cód. Habitación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(26, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descripción";
            // 
            // txtCodMobiliario
            // 
            this.txtCodMobiliario.Enabled = false;
            this.txtCodMobiliario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCodMobiliario.Location = new System.Drawing.Point(497, 116);
            this.txtCodMobiliario.Name = "txtCodMobiliario";
            this.txtCodMobiliario.Size = new System.Drawing.Size(185, 20);
            this.txtCodMobiliario.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(494, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cód. Mobiliario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(26, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCodigo.Location = new System.Drawing.Point(29, 116);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(182, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.lblCodHabitacion);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lvMobiliario);
            this.panel1.Controls.Add(this.cardCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.materialCard1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 757);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::ProyectoFinal_Hoteleria.Properties.Resources.chair;
            this.pictureBox9.Location = new System.Drawing.Point(1060, 14);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(64, 64);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 41;
            this.pictureBox9.TabStop = false;
            // 
            // lblCodHabitacion
            // 
            this.lblCodHabitacion.AutoSize = true;
            this.lblCodHabitacion.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(164)))));
            this.lblCodHabitacion.Location = new System.Drawing.Point(1009, 50);
            this.lblCodHabitacion.Name = "lblCodHabitacion";
            this.lblCodHabitacion.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblCodHabitacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCodHabitacion.Size = new System.Drawing.Size(31, 28);
            this.lblCodHabitacion.TabIndex = 44;
            this.lblCodHabitacion.Text = "1";
            this.lblCodHabitacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCodHabitacion.Click += new System.EventHandler(this.lblCodHabitacion_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(928, 14);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 5, 5, 15);
            this.label8.Size = new System.Drawing.Size(124, 39);
            this.label8.TabIndex = 43;
            this.label8.Text = "Cod. Habitación";
            // 
            // lvMobiliario
            // 
            this.lvMobiliario.AutoSizeTable = false;
            this.lvMobiliario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvMobiliario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvMobiliario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.columnHeader21,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25});
            this.lvMobiliario.Depth = 0;
            this.lvMobiliario.FullRowSelect = true;
            this.lvMobiliario.HideSelection = false;
            listViewItem4.StateImageIndex = 0;
            this.lvMobiliario.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.lvMobiliario.Location = new System.Drawing.Point(20, 117);
            this.lvMobiliario.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvMobiliario.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvMobiliario.MouseState = MaterialSkin.MouseState.OUT;
            this.lvMobiliario.MultiSelect = false;
            this.lvMobiliario.Name = "lvMobiliario";
            this.lvMobiliario.OwnerDraw = true;
            this.lvMobiliario.Size = new System.Drawing.Size(1102, 237);
            this.lvMobiliario.TabIndex = 40;
            this.lvMobiliario.UseCompatibleStateImageBehavior = false;
            this.lvMobiliario.View = System.Windows.Forms.View.Details;
            this.lvMobiliario.SelectedIndexChanged += new System.EventHandler(this.lvMobiliario_SelectedIndexChanged);
            // 
            // codigo
            // 
            this.codigo.Text = "Código";
            this.codigo.Width = 130;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Cod. Habitación";
            this.columnHeader21.Width = 150;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Cod. Mobiliario";
            this.columnHeader23.Width = 150;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Descripción";
            this.columnHeader24.Width = 450;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Precio";
            this.columnHeader25.Width = 180;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(876, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Seleccione la nueva habitación";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal_Hoteleria.Properties.Resources.intercambio_alt;
            this.pictureBox1.Location = new System.Drawing.Point(785, 528);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(25, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Traslado de mobiliario por habitación";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lvHabitacionesTraslado);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(878, 412);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(246, 313);
            this.materialCard1.TabIndex = 36;
            // 
            // FormMobiliario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1148, 824);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "FormMobiliario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMobiliario_Load);
            this.cardCliente.ResumeLayout(false);
            this.cardCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView lvHabitacionesTraslado;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private MaterialSkin.Controls.MaterialCard cardCliente;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodHabitacion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodMobiliario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private MaterialSkin.Controls.MaterialListView lvMobiliario;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCodHabitacion;
    }
}