namespace aula8
{
    partial class FolhaPag
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbPlano = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalariofolha = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtImposto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalLiqui = new System.Windows.Forms.TextBox();
            this.cbClube = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(29, 208);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 41);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(29, 89);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salario";
            // 
            // ckbPlano
            // 
            this.ckbPlano.AutoSize = true;
            this.ckbPlano.Location = new System.Drawing.Point(29, 115);
            this.ckbPlano.Name = "ckbPlano";
            this.ckbPlano.Size = new System.Drawing.Size(100, 17);
            this.ckbPlano.TabIndex = 3;
            this.ckbPlano.Text = "Plano de saúde";
            this.ckbPlano.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Salario folha";
            // 
            // txtSalariofolha
            // 
            this.txtSalariofolha.Location = new System.Drawing.Point(252, 60);
            this.txtSalariofolha.Name = "txtSalariofolha";
            this.txtSalariofolha.Size = new System.Drawing.Size(100, 20);
            this.txtSalariofolha.TabIndex = 5;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(29, 31);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(87, 20);
            this.dtpData.TabIndex = 6;
            // 
            // txtImposto
            // 
            this.txtImposto.Location = new System.Drawing.Point(252, 89);
            this.txtImposto.Name = "txtImposto";
            this.txtImposto.Size = new System.Drawing.Size(100, 20);
            this.txtImposto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Imposto de renda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data folha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salário líquido";
            // 
            // txtSalLiqui
            // 
            this.txtSalLiqui.Location = new System.Drawing.Point(252, 119);
            this.txtSalLiqui.Name = "txtSalLiqui";
            this.txtSalLiqui.Size = new System.Drawing.Size(100, 20);
            this.txtSalLiqui.TabIndex = 11;
            // 
            // cbClube
            // 
            this.cbClube.FormattingEnabled = true;
            this.cbClube.Items.AddRange(new object[] {
            "Clube A",
            "Clube B",
            "Clube C"});
            this.cbClube.Location = new System.Drawing.Point(29, 171);
            this.cbClube.Name = "cbClube";
            this.cbClube.Size = new System.Drawing.Size(100, 21);
            this.cbClube.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Clube de lazer";
            // 
            // FolhaPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 261);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbClube);
            this.Controls.Add(this.txtSalLiqui);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtImposto);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.txtSalariofolha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckbPlano);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.btnCalcular);
            this.Name = "FolhaPag";
            this.Text = "Folha de Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbPlano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalariofolha;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtImposto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalLiqui;
        private System.Windows.Forms.ComboBox cbClube;
        private System.Windows.Forms.Label label6;
    }
}

