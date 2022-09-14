namespace sistema_de_gestion_academica
{
    partial class frmEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudiantes));
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.ape,
            this.ape2,
            this.fecha,
            this.tele,
            this.direccion,
            this.npat,
            this.nmaterno,
            this.foto});
            this.dgvEstudiantes.Location = new System.Drawing.Point(12, 227);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.Size = new System.Drawing.Size(1077, 193);
            this.dgvEstudiantes.TabIndex = 0;
            this.dgvEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiantes_CellContentClick);
            this.dgvEstudiantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiantes_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "idEstudiante";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // ape
            // 
            this.ape.DataPropertyName = "apaterno";
            this.ape.HeaderText = "ape";
            this.ape.Name = "ape";
            // 
            // ape2
            // 
            this.ape2.DataPropertyName = "amaterno";
            this.ape2.HeaderText = "ape2";
            this.ape2.Name = "ape2";
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "fecha";
            this.fecha.Name = "fecha";
            // 
            // tele
            // 
            this.tele.DataPropertyName = "telefono";
            this.tele.HeaderText = "telefono";
            this.tele.Name = "tele";
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "direccion";
            this.direccion.Name = "direccion";
            // 
            // npat
            // 
            this.npat.DataPropertyName = "npaterno";
            this.npat.HeaderText = "nparteno";
            this.npat.Name = "npat";
            // 
            // nmaterno
            // 
            this.nmaterno.DataPropertyName = "nmaterno";
            this.nmaterno.HeaderText = "nmaterno";
            this.nmaterno.Name = "nmaterno";
            // 
            // foto
            // 
            this.foto.DataPropertyName = "foto";
            this.foto.HeaderText = "foto";
            this.foto.Name = "foto";
            // 
            // frmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvEstudiantes);
            this.Name = "frmEstudiantes";
            this.Text = "frmEstudiantes";
            this.Load += new System.EventHandler(this.frmEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn tele;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn npat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmaterno;
        private System.Windows.Forms.DataGridViewImageColumn foto;
    }
}