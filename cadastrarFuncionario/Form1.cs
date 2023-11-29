using CadastrarFuncionario.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CadastrarFuncionario
{
    public partial class Form1 : Form
    {
        // Atributos
        public string[] allEmpresas = Banco.Consultar();
        public string[] plch = {
            "Nome fantasia",
            "Razão social",
            "Situação cadastral",
            "Porte da empresa",
            "Regime tributário",
            "Tipo",
            "Natureza jurídica",
            "Capital social (R$)",
            "Endereço",
        };

        // Metodos
        public Form1()
        {
            InitializeComponent();

            

            // Formatar Lista
            lb_empresas.Items.Clear();
            allEmpresas = Banco.Consultar();
            lb_empresas.Items.AddRange(allEmpresas);
            lb_empresas.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if ( 
                txt_nome.Text          == null || txt_nome.Text          == plch[0] || txt_nome.Text          == plch[0] || 
                txt_razaoSocial.Text   == null || txt_razaoSocial.Text   == plch[1] || txt_razaoSocial.Text   == plch[1] || 
                cb_sitCadastral.Text   == null || cb_sitCadastral.Text   == plch[2] || cb_sitCadastral.Text   == plch[2] || 
                cb_porteEmpresa.Text   == null || cb_porteEmpresa.Text   == plch[3] || cb_porteEmpresa.Text   == plch[3] || 
                cb_regTributario.Text  == null || cb_regTributario.Text  == plch[4] || cb_regTributario.Text  == plch[4] || 
                cb_tipo.Text           == null || cb_tipo.Text           == plch[5] || cb_tipo.Text           == plch[5] || 
                cb_natJuridica.Text    == null || cb_natJuridica.Text    == plch[6] || cb_natJuridica.Text    == plch[6] || 
                txt_capitalSocial.Text == null || txt_capitalSocial.Text == plch[7] || txt_capitalSocial.Text == plch[7] || 
                txt_endereco.Text      == null || txt_endereco.Text      == plch[8] || txt_endereco.Text      == plch[8] ||

                txt_cpf.Text             == null || Validar.Cpf(txt_cpf.Text)              == false ||
                txt_cnpj.Text            == null || Validar.Cnpj(txt_cnpj.Text)            == false ||
                txt_telefone.Text        == null || Validar.Telefone(txt_telefone.Text)    == false ||
                txt_inicioAtividade.Text == null || Validar.Data(txt_inicioAtividade.Text) == false
            ) MessageBox.Show("Existem campos não preenchidos ou dados inválidos!");
            else 
            {
                // Realizar cadastro
                Empresa f = new Empresa(
                    txt_nome.Text,
                    txt_razaoSocial.Text,
                    cb_sitCadastral.Text,

                    txt_cpf.Text,
                    txt_cnpj.Text,
                    Convert.ToDateTime(txt_inicioAtividade.Text).Date,
                    txt_telefone.Text,

                    cb_porteEmpresa.Text,
                    cb_regTributario.Text,
                    cb_tipo.Text,
                    cb_natJuridica.Text,

                    Convert.ToDouble(txt_capitalSocial.Text),
                    txt_endereco.Text
                );
                Banco.Inserir(f);

                // Formatar Lista
                lb_empresas.Items.Clear();
                allEmpresas = Banco.Consultar();
                lb_empresas.Items.AddRange(allEmpresas);
                lb_empresas.Refresh();
            }

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            // Formatar Campos
            txt_nome.Text = plch[0];
            txt_razaoSocial.Text = plch[1];
            cb_sitCadastral.Text = plch[2];
            cb_porteEmpresa.Text = plch[3];
            cb_regTributario.Text = plch[4];
            cb_tipo.Text = plch[5];
            cb_natJuridica.Text = plch[6];
            txt_capitalSocial.Text = plch[7];
            txt_endereco.Text = plch[8];
            txt_cpf.Text = "";
            txt_cnpj.Text = "";
            txt_inicioAtividade.Text = "";
            txt_telefone.Text = "";
    }

    }
}
