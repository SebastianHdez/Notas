namespace VentasEscritorio
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
            this.btnRegistrarNotas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarNotas
            // 
            this.btnRegistrarNotas.Location = new System.Drawing.Point(45, 57);
            this.btnRegistrarNotas.Name = "btnRegistrarNotas";
            this.btnRegistrarNotas.Size = new System.Drawing.Size(114, 32);
            this.btnRegistrarNotas.TabIndex = 0;
            this.btnRegistrarNotas.Text = "Registrar notas";
            this.btnRegistrarNotas.UseVisualStyleBackColor = true;
            this.btnRegistrarNotas.Click += new System.EventHandler(this.btnRegistrarNotas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(215, 151);
            this.Controls.Add(this.btnRegistrarNotas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarNotas;
    }
}

