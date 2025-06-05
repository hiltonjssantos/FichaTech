using System;
using System.Diagnostics.Contracts;
using System.Management;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;

namespace FichaTech
{
    public partial class FrmFichaTech : Form
    {
        AtualizadorFichaTech atualizador = new AtualizadorFichaTech(); // Instancia o atualizador
        string versaoAtual = Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." + Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString() + "." + Assembly.GetExecutingAssembly().GetName().Version.Build.ToString(); //"1.0.0"; // sua versão atual do sistema
        private int linhaEmEdicao = -1; // -1 significa que não está em modo de edição

        public FrmFichaTech()
        {
            InitializeComponent();
            CriarMenu(); // Chama o método para criar o menu
            atualizador.VerificarAtualizacao(); // Verifica se há atualizações disponíveis ao iniciar o formulário

        }

        private void frmFichaTech_Load(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false; // Desabilita o botão Cancelar inicialmente
            ConfigurarColunasGrid();
            lblInfoSistema.Text = "Sistema FichaTech | Versão: " + versaoAtual + " | Desenvolvido por Hilton Santos | Contato: hsinfoetec@gmail.com | © 2025 Todos os direitos reservados | Data: " + ($"{DateTime.Now.ToShortDateString()}");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbSetor.Text) || string.IsNullOrWhiteSpace(cmbAndar.Text) || string.IsNullOrWhiteSpace(txtTecnicoResp.Text))
            {
                MessageBox.Show("Preencha os campos obrigatórios: Nome do Setor, Andar e Técnico Responsável.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (linhaEmEdicao >= 0) // Modo de edição
            {
                var linha = dgvFichaTech.Rows[linhaEmEdicao];
                linha.Cells["NomeSetor"].Value = cmbSetor.Text;
                linha.Cells["Andar"].Value = cmbAndar.Text;
                linha.Cells["Nomenclatura"].Value = txtNomenclatura.Text;
                linha.Cells["MarcaComputador"].Value = cmbMarcaComp.Text;
                linha.Cells["ModeloComputador"].Value = cmbModeloComp.Text;
                linha.Cells["Sistema"].Value = txtSistema.Text;
                linha.Cells["Processador"].Value = txtProcessador.Text;
                linha.Cells["Memoria"].Value = txtMemoria.Text;
                linha.Cells["HDSSD"].Value = txtHdSsd.Text;
                linha.Cells["NumeroSerieComputador"].Value = txtNumeroSerie.Text;
                linha.Cells["MarcaMonitor1"].Value = txtMarcaMon1.Text;
                linha.Cells["ModeloMonitor1"].Value = txtModeloMon1.Text;
                linha.Cells["NumeroSerieMonitor1"].Value = txtNumSerieMon1.Text;
                linha.Cells["MarcaMonitor2"].Value = txtMarcaMon2.Text;
                linha.Cells["ModeloMonitor2"].Value = txtModeloMon2.Text;
                linha.Cells["NumeroSerieMonitor2"].Value = txtNumSerieMon2.Text;
                linha.Cells["TecnicoResponsavel"].Value = txtTecnicoResp.Text;

                linhaEmEdicao = -1;
                MessageBox.Show("Dados atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SairDaEdicao(); // Chama o método para sair do modo de edição
            }

            else // Nova adição
            {
                // Gerar o próximo número sequencial
                int proximoNumero = dgvFichaTech.Rows.Count + 1;

                // Adicionar nova linha ao DataGridView
                dgvFichaTech.Rows.Add(
                    proximoNumero.ToString(),       // Nº
                    cmbSetor.Text,                  // Nome do Setor
                    cmbAndar.Text,                  // Andar
                    txtNomenclatura.Text,           // Nomenclatura
                    cmbMarcaComp.Text,              // Marca (Computador)
                    cmbModeloComp.Text,             // Modelo (Computador)
                    txtSistema.Text,                // Sistema
                    txtProcessador.Text,            // Processador
                    txtMemoria.Text,                // Memória
                    txtHdSsd.Text,                  // HD/SSD
                    txtNumeroSerie.Text,            // Nº Série (Comp)
                    txtMarcaMon1.Text,              // Marca Monitor 1
                    txtModeloMon1.Text,             // Modelo Monitor 1
                    txtNumSerieMon1.Text,           // Nº Série Monitor 1
                    txtMarcaMon2.Text,              // Marca Monitor 2
                    txtModeloMon2.Text,             // Modelo Monitor 2
                    txtNumSerieMon2.Text,           // Nº Série Monitor 2
                    txtTecnicoResp.Text             // Técnico Responsável
                );
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (linhaEmEdicao != -1)
            {
                MessageBox.Show("Saia do modo de edição para poder prosseguir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se há dados no DataGridView antes de exportar
            if (dgvFichaTech.Rows.Count == 0)
            {
                MessageBox.Show("Não há dados para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog salvar = new SaveFileDialog())
            {
                salvar.Filter = "Arquivo Excel (*.xlsx)|*.xlsx";
                salvar.Title = "Exportar para Excel";
                salvar.FileName = "FichaTechExport.xlsx";

                if (salvar.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var planilha = workbook.Worksheets.Add("Ficha Técnica");

                        // Cabeçalhos
                        for (int i = 0; i < dgvFichaTech.Columns.Count; i++)
                        {
                            planilha.Cell(1, i + 1).Value = dgvFichaTech.Columns[i].HeaderText;
                            planilha.Cell(1, i + 1).Style.Font.Bold = true;
                            planilha.Cell(1, i + 1).Style.Font.FontSize = 12;
                            planilha.Column(i + 1).AdjustToContents(); // Ajuste automático da largura
                        }

                        // Linhas
                        for (int i = 0; i < dgvFichaTech.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvFichaTech.Columns.Count; j++)
                            {
                                planilha.Cell(i + 2, j + 1).Value = dgvFichaTech.Rows[i].Cells[j].Value?.ToString();
                                planilha.Cell(i + 2, j + 1).Style.Font.FontSize = 12;
                            }
                        }

                        try
                        {
                            workbook.SaveAs(salvar.FileName);
                            MessageBox.Show("Exportação concluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (IOException)
                        {
                            MessageBox.Show("Não foi possível salvar o arquivo. Ele pode estar aberto em outro programa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            cmbSetor.Text = string.Empty;
            cmbAndar.Text = string.Empty;
            txtNomenclatura.Text = string.Empty;
            cmbMarcaComp.Text = string.Empty;
            cmbModeloComp.Text = string.Empty;
            txtSistema.Text = string.Empty;
            txtProcessador.Text = string.Empty;
            txtMemoria.Text = string.Empty;
            txtHdSsd.Text = string.Empty;
            txtNumeroSerie.Text = string.Empty;
            txtMarcaMon1.Text = string.Empty;
            txtModeloMon1.Text = string.Empty;
            txtNumSerieMon1.Text = string.Empty;
            txtMarcaMon2.Text = string.Empty;
            txtModeloMon2.Text = string.Empty;
            txtNumSerieMon2.Text = string.Empty;
            txtTecnicoResp.Text = string.Empty;
            cmbSetor.Focus();
        }

        private void btnColetar_Click(object sender, EventArgs e)
        {
            PreencherCamposFichaTech();
        }

        private void PreencherCamposFichaTech()
        {
            txtNomenclatura.Text = Environment.MachineName;
            txtSistema.Text = GetOperatingSystem();
            txtProcessador.Text = GetProcessor();
            txtMemoria.Text = GetMemoryInfo();
            txtHdSsd.Text = GetDiskDrivesInfo();
            txtNumeroSerie.Text = GetComputerSerialNumber();
            GetMonitorInfo();
        }

        private string GetOperatingSystem()
        {
            try
            {
                using (ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem"))
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        return obj["Caption"]?.ToString() ?? "Não encontrado";
                    }
                }
            }
            catch { }
            return "Erro ao obter SO";
        }

        private string GetProcessor()
        {
            try
            {
                using (ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("SELECT Name FROM Win32_Processor"))
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        return obj["Name"]?.ToString() ?? "Não encontrado";
                    }
                }
            }
            catch { }
            return "Erro ao obter Processador";
        }

        private string GetMemoryInfo()
        {
            StringBuilder memoryInfo = new StringBuilder();

            int slotsUsados = 0;
            int totalSlots = 0;
            double totalMemoryGB = 0;
            string memoryType = "DDR ";

            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory"))
            {
                foreach (var mem in searcher.Get())
                {
                    slotsUsados++;

                    memoryType = GetMemoryType(mem["MemoryType"]?.ToString());

                    string typeDetail = GetMemoryType(mem["MemoryType"]?.ToString());
                    double capacityGB = Math.Round(Convert.ToDouble(mem["Capacity"]) / (1024 * 1024 * 1024), 2);
                    string speed = mem["Speed"]?.ToString() ?? "Velocidade desconhecida";

                    totalMemoryGB += capacityGB;

                    memoryInfo.AppendLine($" - {typeDetail} {capacityGB}GB {speed}MHz");
                }
            }

            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemoryArray"))
            {
                foreach (var item in searcher.Get())
                {
                    totalSlots += Convert.ToInt32(item["MemoryDevices"]);
                }
            }

            memoryInfo.Insert(0, $" Slot(s) disponível(is): {totalSlots - slotsUsados}\n");
            memoryInfo.Insert(0, $" Slot(s) utilizado(s): {slotsUsados}\n");
            memoryInfo.Insert(0, $" Total de Memória: {totalMemoryGB}GB\n");

            //return memoryInfo.ToString();
            return totalMemoryGB.ToString() + "GB " + memoryType.ToString();
        }

        private string GetMemoryType(string type)
        {
            return type switch
            {
                "20" => "DDR",
                "21" => "DDR2",
                "24" => "DDR3",
                "26" => "DDR4",
                _ => "DDR"
            };
        }

        private string GetDiskDrivesInfo()
        {
            StringBuilder disksInfo = new StringBuilder();

            int count = 1;
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive"))
            {
                foreach (var drive in searcher.Get())
                {
                    string interfaceType = drive["InterfaceType"]?.ToString()?.ToUpper();
                    string mediaType = drive["MediaType"]?.ToString()?.ToUpper() ?? "";

                    if (interfaceType == "USB")
                        disksInfo.Append("USB ");
                    else if (mediaType.Contains("SSD") || drive["Model"]?.ToString().ToUpper().Contains("SSD") == true)
                        disksInfo.Append("SSD ");
                    else
                        disksInfo.Append("HD ");

                    ulong size = (ulong)(drive["Size"] ?? 0);
                    disksInfo.Append($"{Math.Round(size / Math.Pow(1024, 3), 2)} GB");

                    disksInfo.Append(" / ");
                }
            }

            return disksInfo.ToString().Substring(0, disksInfo.Length - 3); // Remove o último " / "
        }

        private string GetComputerSerialNumber()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BIOS"))
            {
                foreach (var bios in searcher.Get())
                {
                    string serial = bios["SerialNumber"]?.ToString()?.Trim() ?? "Número de Série não encontrado";
                    if (string.IsNullOrEmpty(serial) || serial.ToLower().Contains("system serial number"))
                    {
                        return "Número de Série não encontrado";
                    }
                    return serial;
                }
            }
            return "Número de Série não encontrado";
        }

        private void GetMonitorInfo()
        {
            StringBuilder monitorInfo = new StringBuilder();
            int monitorCount = 1;

            using (var searcher = new ManagementObjectSearcher(@"root\wmi", "SELECT * FROM WmiMonitorID"))
            {
                foreach (var monitor in searcher.Get())
                {
                    string manufacturer = DecodeWmiString((ushort[])monitor["ManufacturerName"]);
                    string modelCode = DecodeWmiString((ushort[])monitor["ProductCodeID"]);
                    string model = TraduzirModeloMonitor(modelCode);
                    string serial = DecodeWmiString((ushort[])monitor["SerialNumberID"]);

                    monitorInfo.Append($"Monitor {monitorCount++}:");
                    if (monitorCount == 2)
                    {
                        txtMarcaMon1.Text = $"{TraduzirFabricanteMonitor(manufacturer)} ({manufacturer})";
                        txtModeloMon1.Text = $"{model}";
                        txtNumSerieMon1.Text = $"{serial}";
                    }

                    if (monitorCount == 3)
                    {
                        txtMarcaMon2.Text = $"{TraduzirFabricanteMonitor(manufacturer)} ({manufacturer})";
                        txtModeloMon2.Text = $"{model}";
                        txtNumSerieMon2.Text = $"{serial}";
                    }
                }
            }

            if (monitorCount == 1)
            {
                monitorInfo.Append("Nenhum monitor encontrado.");
                txtMarcaMon1.Text = monitorInfo.ToString();
                txtModeloMon1.Text = monitorInfo.ToString();
                txtNumSerieMon1.Text = monitorInfo.ToString();
                txtMarcaMon2.Text = monitorInfo.ToString();
                txtModeloMon2.Text = monitorInfo.ToString();
                txtNumSerieMon2.Text = monitorInfo.ToString();
            }
        }

        private string DecodeWmiString(ushort[] encodedString)
        {
            if (encodedString == null) return "Não disponível";

            var decoded = new StringBuilder();
            foreach (ushort c in encodedString)
            {
                if (c == 0)
                    break;
                decoded.Append(Convert.ToChar(c));
            }
            return decoded.ToString();
        }

        private string TraduzirFabricanteMonitor(string codigo)
        {
            Dictionary<string, string> fabricantes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { "GSM", "LG" },
        { "HWP", "HP" },
        { "DEL", "DELL" },
        { "POS", "Positivo" },
        { "SAM", "Samsung" },
        { "ACR", "Acer" },
        { "AOC", "AOC" },
        { "PHL", "Philips" },
        { "LEN", "Lenovo" },
        { "ASU", "ASUS" },
        { "VSC", "ViewSonic" },
        { "SNY", "Sony" },
        { "APP", "Apple" }
        // Pode adicionar mais conforme surgirem outros códigos
    };

            return fabricantes.TryGetValue(codigo, out string nomeTraduzido) ? nomeTraduzido : codigo;
        }

        private string TraduzirModeloMonitor(string codigo)
        {
            var dicionarioModelos = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {

         // LG (GSM = GoldStar Manufacturer)
        { "5B71", "LG 27GL650F-B" },
        { "5BA2", "LG 22BN550Y-B" },
        { "581A", "LG E2241" },
        { "5E0F", "LG 22M37" },
        { "5E11", "LG 24M38" },
        { "5E0D", "LG 19M38A" },
        { "5E0C", "LG 20M37" },
        { "5819", "LG E2241VX" },

        // HP (HWP = Hewlett-Packard)
        { "HWP26A9", "HP EliteDisplay E243" },
        { "HWP27C3", "HP Compaq LA2205wg" },
        { "HWP30D9", "HP Z24n G2" },
        { "2943"   , "HP COMPAQ LA2006" },
        { "2944"   , "HP COMPAQ LA2006X" },
        { "2945"   , "HP COMPAQ LA2006" },

        // DELL
        { "DEL404C", "Dell P2219H" },
        { "DEL4097", "Dell U2412M" },
        { "DEL40A9", "Dell E1916H" },
        { "423D"   , "Dell P2425HC" },

        // AOC
        { "AOC2703", "AOC 27B1H" },
        { "AOC2365", "AOC E2270SWN" },
        { "AOC2481", "AOC 24B1XHS" },
        { "2470"   , "AOC M2470PWH" },
        { "2201"   , "AOC 22P1E" },

        // Samsung
        { "SAM0F9B", "Samsung S22F350" },
        { "SAM0FCB", "Samsung S24D300" },
        { "SAM1234", "Samsung SyncMaster Genérico" },

        // Philips
        { "PHL0832", "Philips 223V5L" },
        { "PHL0C33", "Philips 243V7QDSB" },

        // Genéricos
        { "GSM1234", "LG (código genérico)" },
        { "HWP1234", "HP (código genérico)" },
        { "DEL1234", "Dell (código genérico)" },
        { "AOC1234", "AOC (código genérico)" },
        { "PHL1234", "Philips (código genérico)" },
        
        // Adicione mais códigos conforme identificar
    };

            if (dicionarioModelos.TryGetValue(codigo, out string modeloTraduzido))
            {
                return modeloTraduzido;
            }

            return $"Desconhecido (Código: {codigo})";
        }

        private void ConfigurarColunasGrid()
        {
            dgvFichaTech.Columns.Clear();
            dgvFichaTech.AutoGenerateColumns = false;
            dgvFichaTech.ColumnHeadersHeight = 40; // aumenta a altura para caber o texto


            // LOCALIZAÇÃO
            dgvFichaTech.Columns.Add("Numero", "Nº");
            dgvFichaTech.Columns["Numero"].Width = 40;

            dgvFichaTech.Columns.Add("NomeSetor", "Nome do Setor");
            dgvFichaTech.Columns["NomeSetor"].Width = 160;

            dgvFichaTech.Columns.Add("Andar", "Andar");
            dgvFichaTech.Columns["Andar"].Width = 80;

            // COMPUTADOR
            dgvFichaTech.Columns.Add("Nomenclatura", "Nomenclatura");
            dgvFichaTech.Columns["Nomenclatura"].Width = 130;

            dgvFichaTech.Columns.Add("MarcaComputador", "Marca");
            dgvFichaTech.Columns["MarcaComputador"].Width = 100;

            dgvFichaTech.Columns.Add("ModeloComputador", "Modelo");
            dgvFichaTech.Columns["ModeloComputador"].Width = 120;

            dgvFichaTech.Columns.Add("Sistema", "Sistema");
            dgvFichaTech.Columns["Sistema"].Width = 100;

            dgvFichaTech.Columns.Add("Processador", "Processador");
            dgvFichaTech.Columns["Processador"].Width = 160;

            dgvFichaTech.Columns.Add("Memoria", "Memória");
            dgvFichaTech.Columns["Memoria"].Width = 90;

            dgvFichaTech.Columns.Add("HDSSD", "HD/SSD");
            dgvFichaTech.Columns["HDSSD"].Width = 90;

            dgvFichaTech.Columns.Add("NumeroSerieComputador", "Nº Série Computador");
            dgvFichaTech.Columns["NumeroSerieComputador"].Width = 160;

            // MONITOR 1
            dgvFichaTech.Columns.Add("MarcaMonitor1", "Marca Monitor 1");
            dgvFichaTech.Columns["MarcaMonitor1"].Width = 100;

            dgvFichaTech.Columns.Add("ModeloMonitor1", "Modelo Monitor 1");
            dgvFichaTech.Columns["ModeloMonitor1"].Width = 120;

            dgvFichaTech.Columns.Add("NumeroSerieMonitor1", "Nº Série Monitor 1");
            dgvFichaTech.Columns["NumeroSerieMonitor1"].Width = 160;

            // MONITOR 2
            dgvFichaTech.Columns.Add("MarcaMonitor2", "Marca Monitor 2");
            dgvFichaTech.Columns["MarcaMonitor2"].Width = 100;

            dgvFichaTech.Columns.Add("ModeloMonitor2", "Modelo Monitor 2");
            dgvFichaTech.Columns["ModeloMonitor2"].Width = 120;

            dgvFichaTech.Columns.Add("NumeroSerieMonitor2", "Nº Série Monitor 2");
            dgvFichaTech.Columns["NumeroSerieMonitor2"].Width = 160;

            // TÉCNICO
            dgvFichaTech.Columns.Add("TecnicoResponsavel", "Técnico Responsável");
            dgvFichaTech.Columns["TecnicoResponsavel"].Width = 160;

            // AJUSTES VISUAIS
            dgvFichaTech.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            dgvFichaTech.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dgvFichaTech.AllowUserToAddRows = false;
        }

        private void btnImportarPlanilha_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos Excel (*.xlsx)|*.xlsx";
            openFileDialog.Title = "Selecione o arquivo Excel para importar";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var wb = new XLWorkbook(openFileDialog.FileName);
                    var ws = wb.Worksheet(1); // Pega a primeira planilha

                    dgvFichaTech.Rows.Clear();

                    // Começa a ler da linha 3 (pois linha 1 é grupos, linha 2 é cabeçalho real)
                    int linha = 2;
                    while (!ws.Cell(linha, 1).IsEmpty())
                    {
                        dgvFichaTech.Rows.Add(
                            ws.Cell(linha, 1).GetString(),   // Nº
                            ws.Cell(linha, 2).GetString(),   // Nome do Setor
                            ws.Cell(linha, 3).GetString(),   // Andar

                            ws.Cell(linha, 4).GetString(),   // Nomenclatura
                            ws.Cell(linha, 5).GetString(),   // Marca Computador
                            ws.Cell(linha, 6).GetString(),   // Modelo Computador
                            ws.Cell(linha, 7).GetString(),   // Sistema
                            ws.Cell(linha, 8).GetString(),   // Processador
                            ws.Cell(linha, 9).GetString(),   // Memória
                            ws.Cell(linha, 10).GetString(),  // HD/SSD
                            ws.Cell(linha, 11).GetString(),  // Nº Série Computador

                            ws.Cell(linha, 12).GetString(),  // Marca Monitor 1
                            ws.Cell(linha, 13).GetString(),  // Modelo Monitor 1
                            ws.Cell(linha, 14).GetString(),  // Nº Série Monitor 1

                            ws.Cell(linha, 15).GetString(),  // Marca Monitor 2
                            ws.Cell(linha, 16).GetString(),  // Modelo Monitor 2
                            ws.Cell(linha, 17).GetString(),  // Nº Série Monitor 2

                            ws.Cell(linha, 18).GetString()   // Técnico Responsável
                        );

                        linha++;
                    }

                    MessageBox.Show("Importação concluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao importar o arquivo:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (linhaEmEdicao != -1)
            {
                MessageBox.Show("Termine a edição anterior para poder prosseguir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvFichaTech.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (dgvFichaTech.SelectedRows.Count >= 2)
            {
                MessageBox.Show("Selecione apenas uma linha para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Exemplo: mudar cor do botão e do fundo para indicar modo de edição
            btnSalvar.BackColor = Color.Orange;
            btnSalvar.Text = "Salvar Edição";

            // Também pode mudar a cor do painel ou grupo de campos, se desejar
            this.BackColor = Color.Moccasin;

            // Habilita o botão Cancelar e desabilita outros botões
            btnCancelar.Enabled = true; // Habilita o botão Cancelar
            btnImportarPlanilha.Enabled = false; // Desabilita o botão de Importar Planilha
            btnExportarExcel.Enabled = false; // Desabilita o botão de Exportar para Excel
            btnDeletar.Enabled = false; // Desabilita o botão Deletar
            btnEditar.Enabled = false; // Desabilita o botão Editar

            // Seleciona a linha para edição
            var linha = dgvFichaTech.SelectedRows[0];
            linhaEmEdicao = linha.Index;

            cmbSetor.Text = linha.Cells["NomeSetor"].Value?.ToString();
            cmbAndar.Text = linha.Cells["Andar"].Value?.ToString();
            txtNomenclatura.Text = linha.Cells["Nomenclatura"].Value?.ToString();
            cmbMarcaComp.Text = linha.Cells["MarcaComputador"].Value?.ToString();
            cmbModeloComp.Text = linha.Cells["ModeloComputador"].Value?.ToString();
            txtSistema.Text = linha.Cells["Sistema"].Value?.ToString();
            txtProcessador.Text = linha.Cells["Processador"].Value?.ToString();
            txtMemoria.Text = linha.Cells["Memoria"].Value?.ToString();
            txtHdSsd.Text = linha.Cells["HDSSD"].Value?.ToString();
            txtNumeroSerie.Text = linha.Cells["NumeroSerieComputador"].Value?.ToString();

            txtMarcaMon1.Text = linha.Cells["MarcaMonitor1"].Value?.ToString();
            txtModeloMon1.Text = linha.Cells["ModeloMonitor1"].Value?.ToString();
            txtNumSerieMon1.Text = linha.Cells["NumeroSerieMonitor1"].Value?.ToString();

            txtMarcaMon2.Text = linha.Cells["MarcaMonitor2"].Value?.ToString();
            txtModeloMon2.Text = linha.Cells["ModeloMonitor2"].Value?.ToString();
            txtNumSerieMon2.Text = linha.Cells["NumeroSerieMonitor2"].Value?.ToString();

            txtTecnicoResp.Text = linha.Cells["TecnicoResponsavel"].Value?.ToString();

            MessageBox.Show("Edite os campos desejados e clique em 'Salvar Alterações'.", "Modo de Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (linhaEmEdicao != -1)
            {
                MessageBox.Show("Saia do modo de edição para poder prosseguir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (dgvFichaTech.SelectedRows.Count > 0)
                {
                    DialogResult resultado = MessageBox.Show(
                        "Tem certeza que deseja excluir as linhas selecionadas?",
                        "Confirmar Exclusão",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (resultado == DialogResult.Yes)
                    {
                        // Lista temporária para armazenar as linhas a serem removidas
                        List<DataGridViewRow> linhasParaRemover = new List<DataGridViewRow>();

                        foreach (DataGridViewRow linha in dgvFichaTech.SelectedRows)
                        {
                            if (!linha.IsNewRow)
                            {
                                linhasParaRemover.Add(linha);
                            }
                        }

                        // Remove as linhas selecionadas
                        foreach (DataGridViewRow linha in linhasParaRemover)
                        {
                            dgvFichaTech.Rows.Remove(linha);
                        }

                        // 🔢 Renumera a coluna "Nº"
                        for (int i = 0; i < dgvFichaTech.Rows.Count; i++)
                        {
                            dgvFichaTech.Rows[i].Cells["Numero"].Value = (i + 1).ToString();
                        }

                        MessageBox.Show("Linha(s) excluída(s) e numeração atualizada.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma ou mais linhas para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir linha(s): " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termoPesquisa = txtPesquisar.Text.Trim().ToLower();

            dgvFichaTech.ClearSelection();

            if (string.IsNullOrEmpty(termoPesquisa))
            {
                MessageBox.Show("Digite um termo para pesquisa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool encontrou = false;
            int primeiraLinhaEncontrada = -1;

            for (int i = 0; i < dgvFichaTech.Rows.Count; i++)
            {
                DataGridViewRow row = dgvFichaTech.Rows[i];

                if (row.IsNewRow) continue;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(termoPesquisa))
                    {
                        row.Selected = true;

                        if (!encontrou)
                        {
                            primeiraLinhaEncontrada = i; // Salva o índice da primeira linha encontrada
                            encontrou = true;
                        }

                        break;
                    }
                }
            }

            if (!encontrou)
            {
                MessageBox.Show("Nenhum resultado encontrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (primeiraLinhaEncontrada >= 0)
            {
                dgvFichaTech.FirstDisplayedScrollingRowIndex = primeiraLinhaEncontrada;
            }
        }

        // Método para criar o menu
        private void CriarMenu()
        {
            MenuStrip menu = new MenuStrip();

            // ARQUIVO
            ToolStripMenuItem menuArquivo = new ToolStripMenuItem("Arquivo");

            ToolStripMenuItem itemNovo = new ToolStripMenuItem("Novo Registro", null, (s, e) => LimparCampos());
            ToolStripMenuItem itemImportar = new ToolStripMenuItem("Importar Planilha", null, (s, e) => btnImportarPlanilha_Click(null, null));
            ToolStripMenuItem itemExportarExcel = new ToolStripMenuItem("Exportar para Excel", null, (s, e) => MessageBox.Show("Função ainda será implementada."));
            ToolStripMenuItem itemSair = new ToolStripMenuItem("Sair", null, (s, e) => this.Close());

            menuArquivo.DropDownItems.Add(itemNovo);
            menuArquivo.DropDownItems.Add(itemImportar);
            menuArquivo.DropDownItems.Add(itemExportarExcel);
            menuArquivo.DropDownItems.Add(new ToolStripSeparator());
            menuArquivo.DropDownItems.Add(itemSair);

            // EDITAR
            ToolStripMenuItem menuEditar = new ToolStripMenuItem("Editar");

            ToolStripMenuItem itemEditar = new ToolStripMenuItem("Editar Selecionado", null, (s, e) => btnEditar_Click(null, null));
            ToolStripMenuItem itemExcluir = new ToolStripMenuItem("Excluir Selecionado", null, (s, e) => btnDeletar_Click(null, null));

            menuEditar.DropDownItems.Add(itemEditar);
            menuEditar.DropDownItems.Add(itemExcluir);

            // EXIBIR
            ToolStripMenuItem menuExibir = new ToolStripMenuItem("Exibir");

            ToolStripMenuItem itemPesquisar = new ToolStripMenuItem("Pesquisar", null, (s, e) => txtPesquisar.Focus());
            ToolStripMenuItem itemRecarregar = new ToolStripMenuItem("Recarregar Campos", null, (s, e) => LimparCampos());

            menuExibir.DropDownItems.Add(itemPesquisar);
            menuExibir.DropDownItems.Add(itemRecarregar);

            // AJUDA
            ToolStripMenuItem menuAjuda = new ToolStripMenuItem("Ajuda");

            ToolStripMenuItem itemSobre = new ToolStripMenuItem("Sobre o FichaTech", null, (s, e) =>
            {
                MessageBox.Show("Sistema FichaTech\nDesenvolvido por Hilton Santos\nVersão 1.0.0\nContato: hsinfoetec@gmail.com", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });

            menuAjuda.DropDownItems.Add(itemSobre);

            // Adiciona menus à barra
            menu.Items.Add(menuArquivo);
            menu.Items.Add(menuEditar);
            menu.Items.Add(menuExibir);
            menu.Items.Add(menuAjuda);
            ToolStripMenuItem itemManual = new ToolStripMenuItem("Manual do Usuário", null, (s, e) => MostrarManual());
            menuAjuda.DropDownItems.Add(itemManual);

            // Adiciona ao formulário
            this.MainMenuStrip = menu;
            this.Controls.Add(menu);
        }

        private void MostrarManual()
        {
            string manualTexto = @"Manual do FichaTech

1. Novo Registro: limpa os campos para adicionar um novo computador.
2. Importar Planilha: importa dados de uma planilha Excel para a tabela.
3. Exportar para Excel: exporta os dados atuais para uma planilha Excel.
4. Editar Selecionado: permite editar a linha selecionada.
5. Excluir Selecionado: exclui as linhas selecionadas.
6. Pesquisar: digite no campo para localizar registros.
7. Sobre: informações do sistema.";

            MessageBox.Show(manualTexto, "Manual do Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja cancelar a edição da linha selecionada?",
                "Cancelar Edição",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                SairDaEdicao();
            }
        }

        private void SairDaEdicao()
        {
            linhaEmEdicao = -1;
            // Desabilita o botão Cancelar e reabilita outros botões
            btnCancelar.Enabled = false; // Desabilita o botão Cancelar                
            btnImportarPlanilha.Enabled = true; // Habilita o botão de Importar Planilha
            btnExportarExcel.Enabled = true; // Habilita o botão de Exportar para Excel
            btnDeletar.Enabled = true; // Habilita o botão Deletar
            btnEditar.Enabled = true; // Habilita o botão Editar

            // Voltar ao estado normal visual
            btnSalvar.BackColor = SystemColors.Control;
            btnSalvar.Text = "Salvar Alterações";
            this.BackColor = SystemColors.Control;
            LimparCampos();
        }
    }
}