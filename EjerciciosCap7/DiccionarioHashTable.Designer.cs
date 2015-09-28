namespace EjerciciosCap7
{
    partial class DiccionarioHashTable
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPalabras = new System.Windows.Forms.ComboBox();
            this.textBoxPalabra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxSignificado = new System.Windows.Forms.RichTextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.tabControlSignificado = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxSignificado = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControlSignificado.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar palabras existentes";
            // 
            // comboBoxPalabras
            // 
            this.comboBoxPalabras.CausesValidation = false;
            this.comboBoxPalabras.FormattingEnabled = true;
            this.comboBoxPalabras.Items.AddRange(new object[] {
            "Accidente",
            "Administrador",
            "Animal",
            "Buscar",
            "Blanco",
            "Programador"});
            this.comboBoxPalabras.Location = new System.Drawing.Point(6, 55);
            this.comboBoxPalabras.Name = "comboBoxPalabras";
            this.comboBoxPalabras.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPalabras.TabIndex = 0;
            this.comboBoxPalabras.SelectedIndexChanged += new System.EventHandler(this.comboBoxPalabras_SelectedIndexChanged);
            // 
            // textBoxPalabra
            // 
            this.textBoxPalabra.Location = new System.Drawing.Point(11, 45);
            this.textBoxPalabra.Name = "textBoxPalabra";
            this.textBoxPalabra.Size = new System.Drawing.Size(121, 20);
            this.textBoxPalabra.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresar nuevas palabras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingresar significado";
            // 
            // richTextBoxSignificado
            // 
            this.richTextBoxSignificado.Location = new System.Drawing.Point(180, 45);
            this.richTextBoxSignificado.Name = "richTextBoxSignificado";
            this.richTextBoxSignificado.Size = new System.Drawing.Size(267, 96);
            this.richTextBoxSignificado.TabIndex = 5;
            this.richTextBoxSignificado.Text = "";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(180, 161);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(86, 32);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(366, 161);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(81, 32);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(278, 167);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(130, 32);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "Buscar significado";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // tabControlSignificado
            // 
            this.tabControlSignificado.Controls.Add(this.tabPage1);
            this.tabControlSignificado.Controls.Add(this.tabPage2);
            this.tabControlSignificado.Location = new System.Drawing.Point(2, 1);
            this.tabControlSignificado.Name = "tabControlSignificado";
            this.tabControlSignificado.SelectedIndex = 0;
            this.tabControlSignificado.Size = new System.Drawing.Size(576, 249);
            this.tabControlSignificado.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonCancelar);
            this.tabPage1.Controls.Add(this.textBoxPalabra);
            this.tabPage1.Controls.Add(this.richTextBoxSignificado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(568, 223);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresar palabras";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.listBoxSignificado);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.comboBoxPalabras);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(568, 223);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar significados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxSignificado
            // 
            this.listBoxSignificado.FormattingEnabled = true;
            this.listBoxSignificado.Location = new System.Drawing.Point(145, 27);
            this.listBoxSignificado.Name = "listBoxSignificado";
            this.listBoxSignificado.Size = new System.Drawing.Size(401, 134);
            this.listBoxSignificado.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Significado";
            // 
            // DiccionarioHashTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 262);
            this.Controls.Add(this.tabControlSignificado);
            this.Name = "DiccionarioHashTable";
            this.Text = "DiccionarioHashTable";
            this.Load += new System.EventHandler(this.DiccionarioHashTable_Load);
            this.tabControlSignificado.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPalabras;
        private System.Windows.Forms.TextBox textBoxPalabra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxSignificado;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TabControl tabControlSignificado;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxSignificado;
    }
}