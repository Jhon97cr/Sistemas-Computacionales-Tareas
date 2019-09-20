namespace Tarea_1
{
    partial class Clase_string
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
            this.txtPalabra1 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnConcat = new System.Windows.Forms.Button();
            this.txtPalabra2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPalabra3 = new System.Windows.Forms.TextBox();
            this.btnUpper = new System.Windows.Forms.Button();
            this.txtResultado2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPalabra4 = new System.Windows.Forms.TextBox();
            this.btnTrim = new System.Windows.Forms.Button();
            this.txtResultado3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPalabra1
            // 
            this.txtPalabra1.Location = new System.Drawing.Point(169, 36);
            this.txtPalabra1.Name = "txtPalabra1";
            this.txtPalabra1.Size = new System.Drawing.Size(197, 20);
            this.txtPalabra1.TabIndex = 1;
            this.txtPalabra1.TextChanged += new System.EventHandler(this.txtPalabra_TextChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(522, 58);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(197, 20);
            this.txtResultado.TabIndex = 5;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // btnConcat
            // 
            this.btnConcat.Location = new System.Drawing.Point(401, 58);
            this.btnConcat.Name = "btnConcat";
            this.btnConcat.Size = new System.Drawing.Size(75, 23);
            this.btnConcat.TabIndex = 7;
            this.btnConcat.Text = "Concat";
            this.btnConcat.UseVisualStyleBackColor = true;
            this.btnConcat.Click += new System.EventHandler(this.btnConcat_Click);
            // 
            // txtPalabra2
            // 
            this.txtPalabra2.Location = new System.Drawing.Point(169, 79);
            this.txtPalabra2.Name = "txtPalabra2";
            this.txtPalabra2.Size = new System.Drawing.Size(197, 20);
            this.txtPalabra2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Palabra 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Palabra 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Palabra 3";
            // 
            // txtPalabra3
            // 
            this.txtPalabra3.Location = new System.Drawing.Point(169, 166);
            this.txtPalabra3.Name = "txtPalabra3";
            this.txtPalabra3.Size = new System.Drawing.Size(197, 20);
            this.txtPalabra3.TabIndex = 11;
            // 
            // btnUpper
            // 
            this.btnUpper.Location = new System.Drawing.Point(401, 166);
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Size = new System.Drawing.Size(75, 23);
            this.btnUpper.TabIndex = 15;
            this.btnUpper.Text = "Upper";
            this.btnUpper.UseVisualStyleBackColor = true;
            this.btnUpper.Click += new System.EventHandler(this.btnUpper_Click);
            // 
            // txtResultado2
            // 
            this.txtResultado2.Location = new System.Drawing.Point(522, 166);
            this.txtResultado2.Name = "txtResultado2";
            this.txtResultado2.Size = new System.Drawing.Size(197, 20);
            this.txtResultado2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Palabra 4";
            // 
            // txtPalabra4
            // 
            this.txtPalabra4.Location = new System.Drawing.Point(169, 272);
            this.txtPalabra4.Name = "txtPalabra4";
            this.txtPalabra4.Size = new System.Drawing.Size(197, 20);
            this.txtPalabra4.TabIndex = 18;
            // 
            // btnTrim
            // 
            this.btnTrim.Location = new System.Drawing.Point(401, 272);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(75, 23);
            this.btnTrim.TabIndex = 19;
            this.btnTrim.Text = "Trim";
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // txtResultado3
            // 
            this.txtResultado3.Location = new System.Drawing.Point(522, 275);
            this.txtResultado3.Name = "txtResultado3";
            this.txtResultado3.Size = new System.Drawing.Size(197, 20);
            this.txtResultado3.TabIndex = 20;
            // 
            // Clase_string
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 330);
            this.Controls.Add(this.txtResultado3);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.txtPalabra4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResultado2);
            this.Controls.Add(this.btnUpper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPalabra3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPalabra2);
            this.Controls.Add(this.btnConcat);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtPalabra1);
            this.Name = "Clase_string";
            this.Text = "Clase_string";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPalabra1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnConcat;
        private System.Windows.Forms.TextBox txtPalabra2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPalabra3;
        private System.Windows.Forms.Button btnUpper;
        private System.Windows.Forms.TextBox txtResultado2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPalabra4;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.TextBox txtResultado3;
    }
}