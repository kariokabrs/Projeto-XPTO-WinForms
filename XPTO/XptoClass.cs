using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace XPTO
{
    class XptoClass : XptoInterface
    {
        #region Variaveis

        string linha;
        string comparar;
        string verificacao;
        int[] num = new int[4];
        const Int32 bufferSize = 128;

        // Localização do arquivo txt para geração de DV.
        string lerArquivoSemDV = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Arquivos\matriculasSemDV.txt");
        string criarArquivoComDV = @"c:\Temp\matriculasComDV.txt";

        // Localização do arquivo txt para verificação de DV.
        string lerArquivoVerificarDV = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Arquivos\matriculasParaVerificar.txt");
        string criarArquivoVerificadasDV = @"c:\Temp\matriculasVerificadas.txt";

        #endregion

        #region Metodos
        // Método que lê as matrículas no arquivo matriculasSemDV.txt
        public async void GerarDV()
        {
            try
            {
                using (StreamWriter sw = File.CreateText(criarArquivoComDV))
                {
                    using (var fileStream = File.OpenRead(lerArquivoSemDV))
                    {
                        using (StreamReader sr = new StreamReader(fileStream, Encoding.UTF8, true, bufferSize))
                        {
                            while ((linha = await sr.ReadLineAsync()) != null)
                            {
                                num = DividirDigitos(Convert.ToInt32(linha));

                                int somaDosDigitos = ((num[0] * 5) + (num[1] * 4) + num[2] * 3 + num[3] * 2);
                                int restoDivisaoDosDigitos = somaDosDigitos % 16;
                                string hexaDigito = restoDivisaoDosDigitos.ToString("X");

                                sw.WriteLine(String.Format("{0}-{1}", linha, hexaDigito.ToString()));
                            }
                        }
                    }
                }
                DialogResult dialogResult = MessageBox.Show("Foi adicionado os dígitos verificadores e gerado um arquivo com os mesmo. Deseja Abrir o arquivo gerado?", "XPTO", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Process.Start("notepad.exe", criarArquivoComDV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Problemas para ler ou criar o arquivo.");
            }
        }

        public async void VerificarDV()
        {
            try
            {
                using (StreamWriter sw = File.CreateText(criarArquivoVerificadasDV))
                {
                    using (var fileStream = File.OpenRead(lerArquivoVerificarDV))
                    {
                        using (StreamReader sr = new StreamReader(fileStream, Encoding.UTF8, true, bufferSize))
                        {
                            while ((linha = await sr.ReadLineAsync()) != null)
                            {
                                num = DividirDigitos(Convert.ToInt32(linha.Substring(0, 4)));

                                int somaDosDigitos = ((num[0] * 5) + (num[1] * 4) + num[2] * 3 + num[3] * 2);
                                int restoDivisaoDosDigitos = somaDosDigitos % 16;
                                string hexaDigito = restoDivisaoDosDigitos.ToString("X");

                                comparar = String.Format("{0}-{1}", linha.Substring(0, 4), hexaDigito.ToString());

                                if (comparar == linha)
                                {
                                    verificacao = "verdadeiro";
                                }
                                else
                                {
                                    verificacao = "falso";
                                }

                                sw.WriteLine(String.Format("{0} {1}", linha, verificacao));
                            }
                        }
                    }
                }
                DialogResult dialogResult = MessageBox.Show("Foi verificado os dígitos verificadores e gerado um arquivo com informação procedente. Deseja Abrir o arquivo gerado?", "XPTO", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Process.Start("notepad.exe", criarArquivoVerificadasDV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Problemas para ler ou criar o arquivo.");
            }
        }

        public static int[] DividirDigitos(int numero)
        {
            string temp = numero.ToString();
            temp = temp.PadLeft(4, '0');
            int[] rtn = new int[temp.Length];
            for (int i = 0; i < rtn.Length; i++)
            {
                rtn[i] = int.Parse(temp[i].ToString());
            }
            return rtn;
        }
        #endregion
    }
}

