
namespace TP_labo2_Mendiburu_GeonasStunf
{
    partial class FormMedio
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
            this.lbl1_Medio = new System.Windows.Forms.Label();
            this.txtB1_Medio = new System.Windows.Forms.TextBox();
            this.btn_Anterior_Medio = new System.Windows.Forms.Button();
            this.btn_Siguiente_Medio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1_Medio
            // 
            this.lbl1_Medio.AutoSize = true;
            this.lbl1_Medio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl1_Medio.Location = new System.Drawing.Point(47, 35);
            this.lbl1_Medio.Name = "lbl1_Medio";
            this.lbl1_Medio.Size = new System.Drawing.Size(75, 18);
            this.lbl1_Medio.TabIndex = 0;
            this.lbl1_Medio.Text = "Tablero nº";
            // 
            // txtB1_Medio
            // 
            this.txtB1_Medio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB1_Medio.Location = new System.Drawing.Point(129, 32);
            this.txtB1_Medio.Name = "txtB1_Medio";
            this.txtB1_Medio.ReadOnly = true;
            this.txtB1_Medio.Size = new System.Drawing.Size(45, 24);
            this.txtB1_Medio.TabIndex = 1;
            // 
            // btn_Anterior_Medio
            // 
            this.btn_Anterior_Medio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Anterior_Medio.Location = new System.Drawing.Point(490, 367);
            this.btn_Anterior_Medio.Name = "btn_Anterior_Medio";
            this.btn_Anterior_Medio.Size = new System.Drawing.Size(138, 51);
            this.btn_Anterior_Medio.TabIndex = 2;
            this.btn_Anterior_Medio.Text = "Tablero anterior";
            this.btn_Anterior_Medio.UseVisualStyleBackColor = true;
            // 
            // btn_Siguiente_Medio
            // 
            this.btn_Siguiente_Medio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Siguiente_Medio.Location = new System.Drawing.Point(634, 367);
            this.btn_Siguiente_Medio.Name = "btn_Siguiente_Medio";
            this.btn_Siguiente_Medio.Size = new System.Drawing.Size(137, 51);
            this.btn_Siguiente_Medio.TabIndex = 3;
            this.btn_Siguiente_Medio.Text = "Tablero siguiente";
            this.btn_Siguiente_Medio.UseVisualStyleBackColor = true;
            // 
            // FormMedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Siguiente_Medio);
            this.Controls.Add(this.btn_Anterior_Medio);
            this.Controls.Add(this.txtB1_Medio);
            this.Controls.Add(this.lbl1_Medio);
            this.Name = "FormMedio";
            this.Text = "FormMedio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1_Medio;
        private System.Windows.Forms.TextBox txtB1_Medio;
        private System.Windows.Forms.Button btn_Anterior_Medio;
        private System.Windows.Forms.Button btn_Siguiente_Medio;
    }
}