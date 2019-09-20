namespace Tarea_1
{
    partial class Clase_Math
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.txtResultado1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btnElevar = new System.Windows.Forms.Button();
            this.txtResultado2 = new System.Windows.Forms.TextBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(122, 64);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 1;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(276, 64);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Logaritmo";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // txtResultado1
            // 
            this.txtResultado1.Location = new System.Drawing.Point(406, 64);
            this.txtResultado1.Name = "txtResultado1";
            this.txtResultado1.Size = new System.Drawing.Size(100, 20);
            this.txtResultado1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero 2";
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(122, 199);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 5;
            // 
            // btnElevar
            // 
            this.btnElevar.Location = new System.Drawing.Point(276, 199);
            this.btnElevar.Name = "btnElevar";
            this.btnElevar.Size = new System.Drawing.Size(75, 23);
            this.btnElevar.TabIndex = 6;
            this.btnElevar.Text = "Elevar";
            this.btnElevar.UseVisualStyleBackColor = true;
            this.btnElevar.Click += new System.EventHandler(this.btnElevar_Click);
            // 
            // txtResultado2
            // 
            this.txtResultado2.Location = new System.Drawing.Point(406, 202);
            this.txtResultado2.Name = "txtResultado2";
            this.txtResultado2.Size = new System.Drawing.Size(100, 20);
            this.txtResultado2.TabIndex = 7;
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(122, 240);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(100, 20);
            this.txtPotencia.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Potencia";
            // 
            // Clase_Math
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 333);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.txtResultado2);
            this.Controls.Add(this.btnElevar);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResultado1);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.label1);
            this.Name = "Clase_Math";
            this.Text = "Clase_Math";
            this.Load += new System.EventHandler(this.Clase_Math_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.TextBox txtResultado1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnElevar;
        private System.Windows.Forms.TextBox txtResultado2;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Label label3;
    }
}