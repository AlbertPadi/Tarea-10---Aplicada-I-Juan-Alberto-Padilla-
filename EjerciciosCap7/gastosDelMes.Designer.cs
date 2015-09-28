namespace EjerciciosCap7
{
    partial class gastosDelMes
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
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxGastos = new System.Windows.Forms.RichTextBox();
            this.textBoxGastos = new System.Windows.Forms.TextBox();
            this.richTextBoxTotales = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(137, 222);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(87, 36);
            this.buttonCalcular.TabIndex = 0;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar gastos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gastos";
            // 
            // richTextBoxGastos
            // 
            this.richTextBoxGastos.Location = new System.Drawing.Point(14, 115);
            this.richTextBoxGastos.Name = "richTextBoxGastos";
            this.richTextBoxGastos.Size = new System.Drawing.Size(100, 101);
            this.richTextBoxGastos.TabIndex = 3;
            this.richTextBoxGastos.Text = "";
            // 
            // textBoxGastos
            // 
            this.textBoxGastos.Location = new System.Drawing.Point(123, 23);
            this.textBoxGastos.Name = "textBoxGastos";
            this.textBoxGastos.Size = new System.Drawing.Size(124, 20);
            this.textBoxGastos.TabIndex = 4;
            // 
            // richTextBoxTotales
            // 
            this.richTextBoxTotales.Location = new System.Drawing.Point(123, 115);
            this.richTextBoxTotales.Name = "richTextBoxTotales";
            this.richTextBoxTotales.Size = new System.Drawing.Size(124, 101);
            this.richTextBoxTotales.TabIndex = 5;
            this.richTextBoxTotales.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Totales";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(149, 50);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(75, 34);
            this.buttonIngresar.TabIndex = 7;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(14, 222);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(87, 36);
            this.buttonMostrar.TabIndex = 8;
            this.buttonMostrar.Text = "Mostrar Gastos";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // gastosDelMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxTotales);
            this.Controls.Add(this.textBoxGastos);
            this.Controls.Add(this.richTextBoxGastos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalcular);
            this.Name = "gastosDelMes";
            this.Text = "gastosDelMes";
            this.Load += new System.EventHandler(this.gastosDelMes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxGastos;
        private System.Windows.Forms.TextBox textBoxGastos;
        private System.Windows.Forms.RichTextBox richTextBoxTotales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonMostrar;
    }
}