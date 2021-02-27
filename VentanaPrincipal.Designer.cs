
namespace ClasesCap10
{
    partial class VentanaPrincipal
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
            this.Ejercicio2button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ejercicio2button
            // 
            this.Ejercicio2button.Location = new System.Drawing.Point(12, 34);
            this.Ejercicio2button.Name = "Ejercicio2button";
            this.Ejercicio2button.Size = new System.Drawing.Size(75, 23);
            this.Ejercicio2button.TabIndex = 0;
            this.Ejercicio2button.Text = "Ejercicio 2";
            this.Ejercicio2button.UseVisualStyleBackColor = true;
            this.Ejercicio2button.Click += new System.EventHandler(this.Ejercicio2button_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 305);
            this.Controls.Add(this.Ejercicio2button);
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ejercicio2button;
    }
}