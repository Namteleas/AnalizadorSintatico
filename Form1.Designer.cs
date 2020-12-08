namespace AnalizadorSintatico
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonArchivo = new System.Windows.Forms.Button();
            this.buttonAnalisis = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewLexico = new System.Windows.Forms.DataGridView();
            this.labelResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLexico)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(550, 382);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonArchivo
            // 
            this.buttonArchivo.Location = new System.Drawing.Point(638, 360);
            this.buttonArchivo.Name = "buttonArchivo";
            this.buttonArchivo.Size = new System.Drawing.Size(75, 23);
            this.buttonArchivo.TabIndex = 1;
            this.buttonArchivo.Text = "Archivo";
            this.buttonArchivo.UseVisualStyleBackColor = true;
            this.buttonArchivo.Click += new System.EventHandler(this.buttonArchivo_Click);
            // 
            // buttonAnalisis
            // 
            this.buttonAnalisis.Location = new System.Drawing.Point(811, 360);
            this.buttonAnalisis.Name = "buttonAnalisis";
            this.buttonAnalisis.Size = new System.Drawing.Size(75, 23);
            this.buttonAnalisis.TabIndex = 2;
            this.buttonAnalisis.Text = "Analisis";
            this.buttonAnalisis.UseVisualStyleBackColor = true;
            this.buttonAnalisis.Click += new System.EventHandler(this.buttonAnalisis_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridViewLexico
            // 
            this.dataGridViewLexico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLexico.Location = new System.Drawing.Point(578, 63);
            this.dataGridViewLexico.Name = "dataGridViewLexico";
            this.dataGridViewLexico.Size = new System.Drawing.Size(348, 272);
            this.dataGridViewLexico.TabIndex = 3;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(573, 12);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 25);
            this.labelResultado.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 410);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.dataGridViewLexico);
            this.Controls.Add(this.buttonAnalisis);
            this.Controls.Add(this.buttonArchivo);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLexico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonArchivo;
        private System.Windows.Forms.Button buttonAnalisis;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridViewLexico;
        private System.Windows.Forms.Label labelResultado;
    }
}

