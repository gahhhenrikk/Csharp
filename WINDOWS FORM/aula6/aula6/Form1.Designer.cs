namespace aula6
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoma = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1";
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 2";
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 3";
            this.label3.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(53, 103);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(72, 20);
            this.txtNota3.TabIndex = 3;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(53, 76);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(72, 20);
            this.txtNota2.TabIndex = 4;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(53, 50);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(72, 20);
            this.txtNota1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Soma das notas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Média das notas";
            // 
            // txtSoma
            // 
            this.txtSoma.Location = new System.Drawing.Point(161, 179);
            this.txtSoma.Name = "txtSoma";
            this.txtSoma.ReadOnly = true;
            this.txtSoma.Size = new System.Drawing.Size(72, 20);
            this.txtSoma.TabIndex = 8;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(161, 210);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.ReadOnly = true;
            this.txtMedia.Size = new System.Drawing.Size(72, 20);
            this.txtMedia.TabIndex = 9;
            // 
            // btnCalc
            // 
            this.btnCalc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.ForeColor = System.Drawing.Color.Blue;
            this.btnCalc.Location = new System.Drawing.Point(50, 129);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtSoma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoma;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Button btnCalc;
    }
}

