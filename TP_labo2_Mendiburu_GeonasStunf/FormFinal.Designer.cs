
namespace TP_labo2_Mendiburu_GeonasStunf
{
    partial class FormFinal
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
            this.lbl1_Final = new System.Windows.Forms.Label();
            this.txtB1_Final = new System.Windows.Forms.TextBox();
            this.btn_Anterior_Final = new System.Windows.Forms.Button();
            this.btn_Finalizar_Final = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1_Final
            // 
            this.lbl1_Final.AutoSize = true;
            this.lbl1_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl1_Final.Location = new System.Drawing.Point(44, 27);
            this.lbl1_Final.Name = "lbl1_Final";
            this.lbl1_Final.Size = new System.Drawing.Size(75, 18);
            this.lbl1_Final.TabIndex = 0;
            this.lbl1_Final.Text = "Tablero nº";
            // 
            // txtB1_Final
            // 
            this.txtB1_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB1_Final.Location = new System.Drawing.Point(126, 24);
            this.txtB1_Final.Name = "txtB1_Final";
            this.txtB1_Final.ReadOnly = true;
            this.txtB1_Final.Size = new System.Drawing.Size(39, 24);
            this.txtB1_Final.TabIndex = 1;
            // 
            // btn_Anterior_Final
            // 
            this.btn_Anterior_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Anterior_Final.Location = new System.Drawing.Point(499, 369);
            this.btn_Anterior_Final.Name = "btn_Anterior_Final";
            this.btn_Anterior_Final.Size = new System.Drawing.Size(154, 42);
            this.btn_Anterior_Final.TabIndex = 2;
            this.btn_Anterior_Final.Text = "Tablero Anterior";
            this.btn_Anterior_Final.UseVisualStyleBackColor = true;
            // 
            // btn_Finalizar_Final
            // 
            this.btn_Finalizar_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Finalizar_Final.Location = new System.Drawing.Point(668, 369);
            this.btn_Finalizar_Final.Name = "btn_Finalizar_Final";
            this.btn_Finalizar_Final.Size = new System.Drawing.Size(83, 42);
            this.btn_Finalizar_Final.TabIndex = 3;
            this.btn_Finalizar_Final.Text = "Finalizar";
            this.btn_Finalizar_Final.UseVisualStyleBackColor = true;
            // 
            // FormFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Finalizar_Final);
            this.Controls.Add(this.btn_Anterior_Final);
            this.Controls.Add(this.txtB1_Final);
            this.Controls.Add(this.lbl1_Final);
            this.Name = "FormFinal";
            this.Text = "FormFinal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1_Final;
        private System.Windows.Forms.TextBox txtB1_Final;
        private System.Windows.Forms.Button btn_Anterior_Final;
        private System.Windows.Forms.Button btn_Finalizar_Final;
    }
}