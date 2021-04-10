
namespace Arreglos
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
            this.buttonArreglo = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonNames = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonArreglo
            // 
            this.buttonArreglo.BackColor = System.Drawing.Color.Yellow;
            this.buttonArreglo.Location = new System.Drawing.Point(168, 64);
            this.buttonArreglo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonArreglo.Name = "buttonArreglo";
            this.buttonArreglo.Size = new System.Drawing.Size(147, 58);
            this.buttonArreglo.TabIndex = 0;
            this.buttonArreglo.Text = "ARREGLO";
            this.buttonArreglo.UseVisualStyleBackColor = false;
            this.buttonArreglo.Click += new System.EventHandler(this.buttonArreglo_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 20;
            this.listBoxResultado.Location = new System.Drawing.Point(57, 132);
            this.listBoxResultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(364, 384);
            this.listBoxResultado.TabIndex = 1;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(504, 132);
            this.textBoxResultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResultado.Size = new System.Drawing.Size(398, 384);
            this.textBoxResultado.TabIndex = 2;
            // 
            // buttonCargar
            // 
            this.buttonCargar.BackColor = System.Drawing.Color.Cyan;
            this.buttonCargar.Location = new System.Drawing.Point(644, 64);
            this.buttonCargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(142, 58);
            this.buttonCargar.TabIndex = 3;
            this.buttonCargar.Text = "CARGAR ARCHIVO";
            this.buttonCargar.UseVisualStyleBackColor = false;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // buttonNames
            // 
            this.buttonNames.BackColor = System.Drawing.Color.Thistle;
            this.buttonNames.Location = new System.Drawing.Point(644, 526);
            this.buttonNames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNames.Name = "buttonNames";
            this.buttonNames.Size = new System.Drawing.Size(142, 65);
            this.buttonNames.TabIndex = 4;
            this.buttonNames.Text = "CARGAR LISTA DE NOMBRES";
            this.buttonNames.UseVisualStyleBackColor = false;
            this.buttonNames.Click += new System.EventHandler(this.buttonNames_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonNames);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.buttonArreglo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArreglo;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonNames;
        private System.Windows.Forms.Button button1;
    }
}

