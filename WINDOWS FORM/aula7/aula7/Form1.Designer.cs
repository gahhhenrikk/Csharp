namespace aula7
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
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSoma
            // 
            this.btnSoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.Location = new System.Drawing.Point(126, 112);
            this.btnSoma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(74, 68);
            this.btnSoma.TabIndex = 0;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnMult
            // 
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(126, 188);
            this.btnMult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(74, 68);
            this.btnMult.TabIndex = 1;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnSub
            // 
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(208, 112);
            this.btnSub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(74, 68);
            this.btnSub.TabIndex = 2;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(208, 188);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(74, 68);
            this.btnDiv.TabIndex = 3;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(126, 264);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(74, 68);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(208, 264);
            this.btnIgual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(74, 68);
            this.btnIgual.TabIndex = 5;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(126, 68);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(154, 24);
            this.txtResult.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "RESULTADO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSoma);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
    }
}

