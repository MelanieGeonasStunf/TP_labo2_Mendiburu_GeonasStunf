
namespace TP_labo2_Mendiburu_GeonasStunf.Properties
{
    partial class FormInicio
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
            this.lbl1_Inicio = new System.Windows.Forms.Label();
            this.txtB1_Inicio = new System.Windows.Forms.TextBox();
            this.btn1_Siguiente_Inicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1_Inicio
            // 
            this.lbl1_Inicio.AutoSize = true;
            this.lbl1_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl1_Inicio.Location = new System.Drawing.Point(41, 34);
            this.lbl1_Inicio.Name = "lbl1_Inicio";
            this.lbl1_Inicio.Size = new System.Drawing.Size(75, 18);
            this.lbl1_Inicio.TabIndex = 0;
            this.lbl1_Inicio.Text = "Tablero nº";
            this.lbl1_Inicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtB1_Inicio
            // 
            this.txtB1_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtB1_Inicio.Location = new System.Drawing.Point(122, 32);
            this.txtB1_Inicio.Name = "txtB1_Inicio";
            this.txtB1_Inicio.ReadOnly = true;
            this.txtB1_Inicio.Size = new System.Drawing.Size(38, 24);
            this.txtB1_Inicio.TabIndex = 1;
            this.txtB1_Inicio.Text = "1";
            this.txtB1_Inicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn1_Siguiente_Inicio
            // 
            this.btn1_Siguiente_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn1_Siguiente_Inicio.Location = new System.Drawing.Point(616, 383);
            this.btn1_Siguiente_Inicio.Name = "btn1_Siguiente_Inicio";
            this.btn1_Siguiente_Inicio.Size = new System.Drawing.Size(143, 38);
            this.btn1_Siguiente_Inicio.TabIndex = 2;
            this.btn1_Siguiente_Inicio.Text = "Siguiente tablero";
            this.btn1_Siguiente_Inicio.UseVisualStyleBackColor = true;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1_Siguiente_Inicio);
            this.Controls.Add(this.txtB1_Inicio);
            this.Controls.Add(this.lbl1_Inicio);
            this.Name = "FormInicio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1_Inicio;
        private System.Windows.Forms.TextBox txtB1_Inicio;
        private System.Windows.Forms.Button btn1_Siguiente_Inicio;
    }
}