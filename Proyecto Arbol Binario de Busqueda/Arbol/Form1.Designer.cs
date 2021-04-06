namespace ArbolesB
{
    partial class Form1
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
            this.btnAnadir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.txtProgramador = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(327, 104);
            this.btnAnadir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(101, 38);
            this.btnAnadir.TabIndex = 0;
            this.btnAnadir.Text = "Añadir ";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre tarea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Duracion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Porcentaje de avance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Programador Asignado";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(152, 66);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 32);
            this.txtNombre.TabIndex = 5;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(152, 181);
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPorcentaje.Multiline = true;
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(147, 32);
            this.txtPorcentaje.TabIndex = 6;
            // 
            // txtProgramador
            // 
            this.txtProgramador.Location = new System.Drawing.Point(152, 242);
            this.txtProgramador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProgramador.Multiline = true;
            this.txtProgramador.Name = "txtProgramador";
            this.txtProgramador.Size = new System.Drawing.Size(147, 34);
            this.txtProgramador.TabIndex = 7;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(152, 118);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDuracion.Multiline = true;
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(147, 32);
            this.txtDuracion.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(327, 179);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 39);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(131, 314);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(191, 37);
            this.btnListar.TabIndex = 10;
            this.btnListar.Text = "Listar Inorden";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(44, 378);
            this.lstDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(386, 147);
            this.lstDatos.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(497, 558);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtProgramador);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnadir);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Arbol Binario de Busqueda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.TextBox txtProgramador;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ListBox lstDatos;
    }
}

