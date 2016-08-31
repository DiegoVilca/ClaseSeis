namespace FerreteFacturacion
{
    partial class Form1
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
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnPrecioFinal = new System.Windows.Forms.Button();
            this.txtPrecio2 = new System.Windows.Forms.TextBox();
            this.txtPrecio3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio1 = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(75, 236);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(75, 23);
            this.btnPromedio.TabIndex = 1;
            this.btnPromedio.Text = "&Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnPrecioFinal
            // 
            this.btnPrecioFinal.Location = new System.Drawing.Point(75, 265);
            this.btnPrecioFinal.Name = "btnPrecioFinal";
            this.btnPrecioFinal.Size = new System.Drawing.Size(75, 23);
            this.btnPrecioFinal.TabIndex = 2;
            this.btnPrecioFinal.Text = "&PrecioFinal";
            this.btnPrecioFinal.UseVisualStyleBackColor = true;
            this.btnPrecioFinal.Click += new System.EventHandler(this.btnPrecioFinal_Click);
            // 
            // txtPrecio2
            // 
            this.txtPrecio2.Location = new System.Drawing.Point(65, 113);
            this.txtPrecio2.Name = "txtPrecio2";
            this.txtPrecio2.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio2.TabIndex = 4;
            // 
            // txtPrecio3
            // 
            this.txtPrecio3.Location = new System.Drawing.Point(65, 166);
            this.txtPrecio3.Name = "txtPrecio3";
            this.txtPrecio3.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Primer Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Segundo Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tercer Numero";
            // 
            // txtPrecio1
            // 
            this.txtPrecio1.Location = new System.Drawing.Point(67, 59);
            this.txtPrecio1.Name = "txtPrecio1";
            this.txtPrecio1.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio1.TabIndex = 3;
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(75, 207);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 6;
            this.btnSuma.Text = "&Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 325);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtPrecio3);
            this.Controls.Add(this.txtPrecio2);
            this.Controls.Add(this.txtPrecio1);
            this.Controls.Add(this.btnPrecioFinal);
            this.Controls.Add(this.btnPromedio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnPrecioFinal;
        private System.Windows.Forms.TextBox txtPrecio2;
        private System.Windows.Forms.TextBox txtPrecio3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio1;
        private System.Windows.Forms.Button btnSuma;
    }
}

