namespace EjerciciosCap7
{
    partial class AgendaTelefonica
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
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxNoTelefono = new System.Windows.Forms.TextBox();
            this.richTextBoxDatos = new System.Windows.Forms.RichTextBox();
            this.buttonListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(209, 95);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(98, 47);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numaro telefonicao";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(170, 26);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(173, 20);
            this.textBoxNombre.TabIndex = 0;
            // 
            // textBoxNoTelefono
            // 
            this.textBoxNoTelefono.Location = new System.Drawing.Point(170, 69);
            this.textBoxNoTelefono.Name = "textBoxNoTelefono";
            this.textBoxNoTelefono.Size = new System.Drawing.Size(173, 20);
            this.textBoxNoTelefono.TabIndex = 1;
            // 
            // richTextBoxDatos
            // 
            this.richTextBoxDatos.Location = new System.Drawing.Point(52, 148);
            this.richTextBoxDatos.Name = "richTextBoxDatos";
            this.richTextBoxDatos.Size = new System.Drawing.Size(291, 86);
            this.richTextBoxDatos.TabIndex = 5;
            this.richTextBoxDatos.Text = "";
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(209, 254);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(98, 47);
            this.buttonListar.TabIndex = 3;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // AgendaTelefonica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 313);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.richTextBoxDatos);
            this.Controls.Add(this.textBoxNoTelefono);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAgregar);
            this.Name = "AgendaTelefonica";
            this.Text = "AgendaTelefonica";
            this.Load += new System.EventHandler(this.AgendaTelefonica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxNoTelefono;
        private System.Windows.Forms.RichTextBox richTextBoxDatos;
        private System.Windows.Forms.Button buttonListar;
    }
}