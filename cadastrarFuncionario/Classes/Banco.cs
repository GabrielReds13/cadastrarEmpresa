using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastrarFuncionario.Classes
{
    public static class Banco
    {
        // - Metodos -
        public static void Inserir(Empresa f)
        {

            try
            {
                Conexao sql = new Conexao();
                var insert = sql.Comando("insert into Empresa (" +
                    // Atributos
                    "nome_fantasia_emp, " +
                    "razao_social_emp, " +
                    "situacao_cadastral_emp, " +
                    "cpf_emp, " +
                    "cnpj_emp, " +
                    "inicio_ativ_emp, " +
                    "telefone_emp, " +
                    "porte_empresa_emp, " +
                    "regime_trib_emp" +
                    "tipo_emp" +
                    "natureza_juri_emp" +
                    "capital_social_emp" +
                    "endereco_emp) " +
                    
                    // Valores
                    "values (" +
                    "@nome_fantasia, " +
                    "@razao_social, " +
                    "@situacao_cadastral, " +
                    "@cpf, " +
                    "@cnpj, " +
                    "@inicio_ativ, " +
                    "@telefone, " +
                    "@porte_empresa, " +
                    "@regime_trib" +
                    "@tipo" +
                    "@natureza_juri" +
                    "@capital_social" +
                    "@endereco);");

                // Definir valores
                insert.Parameters.AddWithValue("@nome_fantasia", f.NomeFantasia);
                insert.Parameters.AddWithValue("@razao_social", f.RazaoSocial);
                insert.Parameters.AddWithValue("@situacao_cadastral", f.SituacaoCadastral);
                insert.Parameters.AddWithValue("@cpf", f.Cpf);
                insert.Parameters.AddWithValue("@cnpj", f.Cnpj);
                insert.Parameters.AddWithValue("@inicio_ativ", f.InicioAtividade);
                insert.Parameters.AddWithValue("@telefone", f.Telefone);
                insert.Parameters.AddWithValue("@porte_empresa", f.PorteEmpresa);
                insert.Parameters.AddWithValue("@regime_trib", f.RegimeTributario);
                insert.Parameters.AddWithValue("@tipo", f.Tipo);
                insert.Parameters.AddWithValue("@natureza_juri", f.NaturezaJuridica);
                insert.Parameters.AddWithValue("@capital_social", f.CapitalSocial);
                insert.Parameters.AddWithValue("@endereco", f.Endereco);

                // Adicionar no banco
                var resultado = insert.ExecuteNonQuery();

                if (resultado > 0) MessageBox.Show("Empresa cadastrada com êxito.");
                else MessageBox.Show("Erro ao cadastrar empresa.");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar empresa.");
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }

        public static string[] Consultar()
        {
            try
            {
                Conexao sql = new Conexao();
                var select = sql.Comando("select * from Empresa");
                var leitor = select.ExecuteReader();

                List<string> lista = new List<string>();

                while(leitor.Read()) lista.Add(
                    $"NOME: {leitor.GetString("nome_fantasia_emp")}; " +
                    $"CNPJ: {leitor.GetString("cnpj_emp")}; " +

                    // Data de nascimento
                    $"DATA INIC: {leitor.GetDateTime("inicio_ativ_emp").Day}-" +
                    $"{leitor.GetDateTime("inicio_ativ_emp").Month}-" +
                    $"{leitor.GetDateTime("inicio_ativ_emp").Year}; " +

                    // Contato
                    $"TELEFONE: {leitor.GetString("telefone_emp")}; " +

                    $"CAPITAL: {leitor.GetString("capital_social_emp")}");

                return lista.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
