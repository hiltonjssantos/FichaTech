using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;

public class AtualizadorFichaTech
{
    public string versaoAtual = Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." + Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString() + "." + Assembly.GetExecutingAssembly().GetName().Version.Build.ToString(); //"1.0.0"; // sua versão atual do sistema
    string urlVersao = "https://raw.githubusercontent.com/hiltonjssantos/FichaTech/refs/heads/master/versao.txt";
    string urlZip = "https://github.com/hiltonjssantos/FichaTech/releases/download/v1.0.0/FichaTech.zip";

    string pastaTemporaria;
    string zipPath;
    string pastaExtracao;
    string caminhoBat;

    public void VerificarAtualizacao()
    {
        try
        {
            using (WebClient client = new WebClient())
            {
                string versaoOnline = client.DownloadString(urlVersao).Trim();
                if (versaoOnline != versaoAtual)
                {
                    DialogResult resposta = MessageBox.Show(
                        $"Uma nova versão ({versaoOnline}) está disponível.\nDeseja atualizar agora?",
                        "Atualização disponível",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (resposta == DialogResult.Yes)
                    {
                        IniciarAtualizacao();
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao verificar versão: " + ex.Message);
        }
    }

    private void IniciarAtualizacao()
    {
        try
        {
            // Criar pasta temporária única
            pastaTemporaria = Path.Combine(Path.GetTempPath(), "atualizacao_" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(pastaTemporaria);

            zipPath = Path.Combine(pastaTemporaria, "atualizacao.zip");
            pastaExtracao = Path.Combine(pastaTemporaria, "extraido");
            Directory.CreateDirectory(pastaExtracao);

            using (WebClient client = new WebClient())
            {
                client.DownloadFile(urlZip, zipPath);
            }

            ZipFile.ExtractToDirectory(zipPath, pastaExtracao, true);
            CriarEScriptDeAtualizacao();
            Application.Exit();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro durante a atualização:\n" + ex.Message);
        }
    }

    private void CriarEScriptDeAtualizacao()
    {
        string appPath = Application.ExecutablePath;
        string pastaDestino = Path.GetDirectoryName(appPath);
        string nomeExe = Path.GetFileName(appPath);

        caminhoBat = Path.Combine(pastaTemporaria, "atualizar.bat");

        using (StreamWriter sw = new StreamWriter(caminhoBat))
        {
            sw.WriteLine("@echo off");
            sw.WriteLine("timeout /t 2 >nul");
            sw.WriteLine(":loop");
            sw.WriteLine($"tasklist | find /i \"{nomeExe}\" >nul");
            sw.WriteLine("if not errorlevel 1 (");
            sw.WriteLine("    timeout /t 1 >nul");
            sw.WriteLine("    goto loop");
            sw.WriteLine(")");
            sw.WriteLine($"xcopy /E /Y \"{pastaExtracao}\\*.*\" \"{pastaDestino}\\\" >nul");
            sw.WriteLine($"start \"\" \"{Path.Combine(pastaDestino, nomeExe)}\"");
            sw.WriteLine("timeout /t 2 >nul");
            sw.WriteLine($"rmdir /s /q \"{pastaTemporaria}\"");
            sw.WriteLine("exit");
        }

        Process.Start(new ProcessStartInfo()
        {
            FileName = caminhoBat,
            CreateNoWindow = true,
            UseShellExecute = false,
            WindowStyle = ProcessWindowStyle.Hidden
        });
    }
}
