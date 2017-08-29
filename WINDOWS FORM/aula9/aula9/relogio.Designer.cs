namespace aula9
{
    partial class relogio
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
            this.lblHora = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(10, 68);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(87, 63);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "00";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(92, 68);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(87, 63);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "00";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.Location = new System.Drawing.Point(176, 68);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(87, 63);
            this.lblS.TabIndex = 2;
            this.lblS.Text = "00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // relogio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblHora);
            this.Name = "relogio";
            this.Text = "relogio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Button button1;
    }
}