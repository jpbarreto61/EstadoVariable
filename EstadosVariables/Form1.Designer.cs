namespace EstadosVariables
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(194, 143);
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(116, 71);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Location = new System.Drawing.Point(356, 164);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(86, 34);
            this.btnIncrementar.TabIndex = 1;
            this.btnIncrementar.Text = "Incrementar";
            this.btnIncrementar.UseVisualStyleBackColor = true;
            this.btnIncrementar.Click += new System.EventHandler(this.btnIncrementar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(242, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(165, 27);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Incrementar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(615, 325);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnIncrementar);
            this.Controls.Add(this.txtNumero);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnIncrementar;
        private System.Windows.Forms.Label lblTitulo;
    }
}

