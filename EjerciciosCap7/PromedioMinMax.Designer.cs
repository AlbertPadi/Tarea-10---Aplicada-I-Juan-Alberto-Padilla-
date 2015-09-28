namespace EjerciciosCap7
{
    partial class PromedioMinMax
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPromedio = new System.Windows.Forms.TextBox();
            this.textBoxMaxima = new System.Windows.Forms.TextBox();
            this.textBoxMinima = new System.Windows.Forms.TextBox();
            this.textBoxCalificaciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Promedio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Maxima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Minima";
            // 
            // textBoxPromedio
            // 
            this.textBoxPromedio.Location = new System.Drawing.Point(305, 217);
            this.textBoxPromedio.Name = "textBoxPromedio";
            this.textBoxPromedio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPromedio.TabIndex = 18;
            // 
            // textBoxMaxima
            // 
            this.textBoxMaxima.Location = new System.Drawing.Point(171, 217);
            this.textBoxMaxima.Name = "textBoxMaxima";
            this.textBoxMaxima.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxima.TabIndex = 17;
            // 
            // textBoxMinima
            // 
            this.textBoxMinima.Location = new System.Drawing.Point(38, 217);
            this.textBoxMinima.Name = "textBoxMinima";
            this.textBoxMinima.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinima.TabIndex = 16;
            // 
            // textBoxCalificaciones
            // 
            this.textBoxCalificaciones.Location = new System.Drawing.Point(203, 30);
            this.textBoxCalificaciones.Name = "textBoxCalificaciones";
            this.textBoxCalificaciones.Size = new System.Drawing.Size(100, 20);
            this.textBoxCalificaciones.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Calificaciones";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(69, 80);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(100, 36);
            this.buttonAgregar.TabIndex = 11;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(198, 80);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(105, 36);
            this.buttonCalcular.TabIndex = 22;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // PromedioMinMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 262);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPromedio);
            this.Controls.Add(this.textBoxMaxima);
            this.Controls.Add(this.textBoxMinima);
            this.Controls.Add(this.textBoxCalificaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAgregar);
            this.Name = "PromedioMinMax";
            this.Text = "PromedioMinMax";
            this.Load += new System.EventHandler(this.PromedioMinMax_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPromedio;
        private System.Windows.Forms.TextBox textBoxMaxima;
        private System.Windows.Forms.TextBox textBoxMinima;
        private System.Windows.Forms.TextBox textBoxCalificaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonCalcular;
    }
}