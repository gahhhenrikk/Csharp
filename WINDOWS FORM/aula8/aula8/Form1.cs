using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula8
{
    public partial class FolhaPag : Form
    {
        public FolhaPag()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //------------------DECLARAÇÃO DAS VARIAVEIS DO SALARIO E IMPOSTO DE RENDA)------------------

            decimal vSalario;
            decimal vPerIR;


            /*(Convert.ToDecimal(txtSalario.Text) >= 900M) , inves de toda hora converter o campo,
            fica mais facil criar uma variavel e atribuir ela ao textBox, fazendo isso nao precisa
            toda hora converter*/

            //==================CALCULO PRINCIPAL==================

            //==================CONFIGURAÇÃO DO CAMPO DE SALARIO==================
            if (txtSalario.Text == "")
            {
                MessageBox.Show("O valor do salario deve ser fornecido", "Erro no campo de salario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                vSalario = Convert.ToDecimal(txtSalario.Text);
                if (vSalario >= 900M)
                {
                    MessageBox.Show("O salario atinge o mínimo requisitado", "Valor do salario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            else
                {
                    MessageBox.Show("O salario não pode ser um salario minimo", "Valor do salario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //depois da primeira virgula a mensagem em seguida é o titulo da janela que irá abrir 
                    //depois as opções de botao q ira aparecer para o usuario 
                    //depois o icone ao lado do texto
                }

                //==================CALCULO DO SALARIO COM O PLANO DE SAUDE MARCADO==================

                if (vSalario > 900 && ckbPlano.Checked) //verifica se o checkbox esta marcado e o salario for maior q 900
                {
                    vSalario -= 100;
                }

                //==================ACRESCIMO DO DOBRO DO SALARIO (13ºSALARIO) (DATE TIME PICKER)==================

                if (dtpData.Value.Month == 12) //se o mes do datetimepicker for dezembro (12)
                {
                    vSalario *= 2;
                }

                //==================CALCULO DO CLUBE (COMBO BOX)==================
                switch (cbClube.Text)
                {
                    case "Clube A":
                        vSalario -= 100;
                        break;
                    case "Clube B":
                        vSalario -= 50;
                        break;
                    case "Clube C":
                        vSalario -= 25;
                        break;
                    default:
                        break;
                }

               

                //==================CALCULO DO IMPOSTO DE RENDA==================

                vPerIR = 0;
            if (vSalario > 0 && vSalario <= 1500)
                {
                    vPerIR = 0;
                }

            else if (vSalario > 1500 && vSalario <= 2500)
                {
                    vPerIR = 5;
                }
            else if (vSalario > 2500 && vSalario <=5000)
                {
                    vPerIR = 10;
                }

            else if (vSalario > 5000)
                {
                    vPerIR = 20;
                }

                

                //essa parte ele calcula o valor e manda para o textBox do salario folha
                txtSalariofolha.Text = Convert.ToString(vSalario);
                txtImposto.Text = Convert.ToString(vSalario * vPerIR / 100M);
                txtSalLiqui.Text = Convert.ToString(vSalario - vSalario * vPerIR / 100M);

                

            }

            
           
        }
    }
}
