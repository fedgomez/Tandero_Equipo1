﻿namespace Proyecto
{
    partial class CalificarUsuario
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
            this.btnCalificarUsuario = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalificarUsuario
            // 
            this.btnCalificarUsuario.Location = new System.Drawing.Point(93, 84);
            this.btnCalificarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalificarUsuario.Name = "btnCalificarUsuario";
            this.btnCalificarUsuario.Size = new System.Drawing.Size(100, 28);
            this.btnCalificarUsuario.TabIndex = 2;
            this.btnCalificarUsuario.Text = "Calificar";
            this.btnCalificarUsuario.UseVisualStyleBackColor = true;
            this.btnCalificarUsuario.Click += new System.EventHandler(this.btnCalificarUsuario_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Calificar usuario";
            // 
            // CalificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 144);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCalificarUsuario);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalificarUsuario";
            this.Text = "Calificar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalificarUsuario;
        private System.Windows.Forms.TextBox textBox1;
    }
}