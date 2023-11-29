using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarFuncionario.Classes
{
    public class Empresa
    {
        // - Atributos -
        public int Id { get; set; }

        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string SituacaoCadastral { get; set; }

        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public DateTime InicioAtividade { get; set; }
        public string Telefone { get; set; }

        public string PorteEmpresa { get; set; }
        public string RegimeTributario { get; set; }
        public string Tipo { get; set; }
        public string NaturezaJuridica { get; set; }

        public double CapitalSocial { get; set; }
        public string Endereco { get; set; }

        // - Metodo Construtor -
        public Empresa
        (
            string nomeFantasia,
            string razaoSocial,
            string situacaoCadastral,
            string cpf,
            string cnpj,
            DateTime inicioAtividade,
            string telefone,
            string porteEmpresa,
            string regimeTributario,
            string tipo,
            string naturezaJuridica,
            double capitalSocial,
            string endereco
        ) 
        {
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            SituacaoCadastral = situacaoCadastral;
            Cpf = cpf;
            Cnpj = cnpj;
            InicioAtividade = inicioAtividade;
            Telefone = telefone;
            PorteEmpresa = porteEmpresa;
            RegimeTributario = regimeTributario;
            Tipo = tipo;
            NaturezaJuridica = naturezaJuridica;
            CapitalSocial = capitalSocial;
            Endereco = endereco;
        }
    }
}