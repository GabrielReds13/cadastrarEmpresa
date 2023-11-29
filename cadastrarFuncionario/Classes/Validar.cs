using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastrarFuncionario.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CadastrarFuncionario
{
    public static class Validar
    {
        // - Metodos -
        public static bool Cpf(string cpf)
        {
            try
            {
                // Variaveis
                int num1 = 0, num2 = 0;

                // Formatar cpf
                cpf = cpf.Replace(".", "").Replace(",", "").Replace("-", "");
                char[] cpfChar = cpf.ToCharArray();

                // Validar tamanho
                if (cpfChar.Length != 11)
                {
                    MessageBox.Show($"CPF inválido.");
                    return false;
                }
                else
                {
                    // Calcular numeros
                    for (int i = 0, j = 10; i < (cpfChar.Length - 2); i++, j--) num1 += (Convert.ToInt32(cpfChar[i].ToString()) * j);
                    num1 = num1 % 11;

                    // Verificar num1
                    if (num1 >= 2) num1 = 11 - num1;
                    else if (num1 == 0) { }
                    else
                    {
                        MessageBox.Show($"CPF inválido.");
                        return false;
                    }

                    // Validar num1
                    if (num1 == Convert.ToInt32(cpfChar[9].ToString()))
                    {
                        // Calcular numeros
                        for (int i = 0, j = 11; i < (cpfChar.Length - 1); i++, j--) num2 += (Convert.ToInt32(cpfChar[i].ToString()) * j);
                        num2 = num2 % 11;

                        // Verificar num1
                        if (num2 >= 2) num2 = 11 - num2;
                        else if (num2 == 0) { }
                        else
                        {
                            MessageBox.Show($"CPF inválido.");
                            return false;
                        }

                        // Validar num2
                        if (num2 == Convert.ToInt32(cpfChar[10].ToString())) return true;
                        else
                        {
                            MessageBox.Show($"CPF inválido.");
                            return false;
                        }
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar CPF.");
                return false;
            }
        }

        public static bool Telefone(string telefone)
        {
            try
            {
                // Formatar telefone
                telefone = telefone.Replace("(", "").Replace(")", "").Replace("_", "").Replace("-", "").Replace(" ", "");
                char[] telChar = telefone.ToCharArray();

                // Verificar
                if (telChar.Length == 11) return true;
                else
                {
                    MessageBox.Show($"Telefone inválido.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar telefone.");
                return false;
            }
        }

        public static bool Cnpj(string cnpj)
        {
            try
            {
                // Formatar cnpj
                cnpj = cnpj.Replace(".", "").Replace(",", "").Replace("-", "").Replace("/", "");
                bool validarCnpj = Regex.IsMatch(cnpj, @"^[0-9]");

                return validarCnpj;
            }
            catch (Exception ex )
            {
                MessageBox.Show("Erro ao verificar cnpj.");
                return false;
            }
        }

        public static bool Data(string texto)
        {
            try
            {
                // Formatar texto
                texto = texto.Replace("-", "").Replace("/", "");
                bool validarTexto = Regex.IsMatch(texto, @"^[0-9]");

                return validarTexto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar data.");
                return false;
            }
        }

        public static bool Capital(string texto)
        {
            try
            {
                // Formatar texto
                texto = texto.Replace("-", "").Replace("/", "");
                bool validarTexto = Regex.IsMatch(texto, @"^[0-9]");

                return validarTexto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar capital.");
                return false;
            }
        }
    }
}
