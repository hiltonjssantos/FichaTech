namespace FichaTech
{
    partial class FrmFichaTech
    {
        private System.ComponentModel.IContainer components = null;
       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFichaTech));
            grpLocalizacao = new GroupBox();
            cmbSetor = new ComboBox();
            cmbAndar = new ComboBox();
            lblSetor = new Label();
            lblAndar = new Label();
            grpComputador = new GroupBox();
            cmbModeloComp = new ComboBox();
            cmbMarcaComp = new ComboBox();
            lblNumSerie = new Label();
            txtNumeroSerie = new TextBox();
            lblNomenclatura = new Label();
            txtNomenclatura = new TextBox();
            lblMarcaComp = new Label();
            lblModeloComp = new Label();
            lblSistema = new Label();
            txtSistema = new TextBox();
            lblProcessador = new Label();
            txtProcessador = new TextBox();
            lblMemoria = new Label();
            txtMemoria = new TextBox();
            lblHdSsd = new Label();
            txtHdSsd = new TextBox();
            grpMonitor1 = new GroupBox();
            lblMarcaMon1 = new Label();
            txtMarcaMon1 = new TextBox();
            lblModeloMon1 = new Label();
            txtModeloMon1 = new TextBox();
            lblNumSerieMon1 = new Label();
            txtNumSerieMon1 = new TextBox();
            grpMonitor2 = new GroupBox();
            lblMarcaMon2 = new Label();
            txtMarcaMon2 = new TextBox();
            lblModeloMon2 = new Label();
            txtModeloMon2 = new TextBox();
            lblNumSerieMon2 = new Label();
            txtNumSerieMon2 = new TextBox();
            lblTecnicoResp = new Label();
            txtTecnicoResp = new TextBox();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnDeletar = new Button();
            btnColetar = new Button();
            btnExportarExcel = new Button();
            dgvFichaTech = new DataGridView();
            panelRodape = new Panel();
            lblInfoSistema = new Label();
            lblPesquisar = new Label();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            btnLimpar = new Button();
            btnImportarPlanilha = new Button();
            btnCancelar = new Button();
            grpLocalizacao.SuspendLayout();
            grpComputador.SuspendLayout();
            grpMonitor1.SuspendLayout();
            grpMonitor2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFichaTech).BeginInit();
            panelRodape.SuspendLayout();
            SuspendLayout();
            // 
            // grpLocalizacao
            // 
            grpLocalizacao.BackColor = Color.FromArgb(240, 240, 240);
            grpLocalizacao.Controls.Add(cmbSetor);
            grpLocalizacao.Controls.Add(cmbAndar);
            grpLocalizacao.Controls.Add(lblSetor);
            grpLocalizacao.Controls.Add(lblAndar);
            grpLocalizacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpLocalizacao.Location = new Point(10, 31);
            grpLocalizacao.Name = "grpLocalizacao";
            grpLocalizacao.Size = new Size(480, 110);
            grpLocalizacao.TabIndex = 0;
            grpLocalizacao.TabStop = false;
            grpLocalizacao.Text = "Localização:";
            // 
            // cmbSetor
            // 
            cmbSetor.DisplayMember = "0";
            cmbSetor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSetor.FormattingEnabled = true;
            cmbSetor.Items.AddRange(new object[] { "Acolhimento  ", "Acolhimento Familiar  ", "Almoxarifado  ", "Ambulatório de Ortopedia  ", "Anestesiologia  ", "Anestesista  ", "Avaliação  ", "Buco  ", "Cartório  ", "Centro Cirúrgico - Administração  ", "Centro Cirúrgico - Coordenação de Enfermagem  ", "Centro Cirúrgico - CME  ", "Centro Cirúrgico - Depósito Ortopedia OPME  ", "Centro de Estudos  ", "Cepen  ", "CGA  ", "Chefe de Equipe Médicos Emergência Frente NIR  ", "Chefia Coronária  ", "Chefia Neuro  ", "Chefia Radiologia  ", "Chefia Coloproctologia  ", "Cirurgia Geral  ", "Cirurgia Plástica / Dermatologia  ", "Cirurgia Vascular  ", "Classificação de Risco  ", "Clínica Médica  ", "Clínica Médica - Posto de Enfermagem  ", "Clínica Médica - Quarto Médico  ", "Coordenação de Enfermagem Cardio  ", "CTI Adulto  ", "CTI Pediátrico  ", "Departamento de Enfermagem  ", "Direção  ", "Endoscopia  ", "Enfermaria 210 Vascular  ", "Enfermaria Neuro  ", "Epidemiologia  ", "Estar Médico Trauma  ", "Esterilização  ", "Farmácia  ", "Faturamento  ", "Fonoaudiologia  ", "Hemoterapia  ", "Laboratório  ", "Laboratório - Chefia  ", "Maternidade  ", "Maternidade - Chefia  ", "Neurocirurgia  ", "NIR  ", "Numoc  ", "Nutrição  ", "Oftalmologia  ", "Ortopedia Emergência  ", "Otorrino  ", "Ouvidoria  ", "Patologia  ", "Pediatria  ", "Posto de Enfermagem Cirurgia Geral  ", "Posto de Enfermagem Cardio  ", "Posto de Enfermagem Ortopedia 1  ", "Posto de Enfermagem Ortopedia 2  ", "Proctologia  ", "Protocolo  ", "Recepção Ambulatório  ", "Recepção Emergência  ", "Recepção Mário Ribeiro  ", "Recepção Raio-X  ", "Registro Geral  ", "Regulação  ", "Retaguarda Trauma  ", "RH Estatutário  ", "RH Rio Saúde  ", "Sala Amarela  ", "Sala Buco Maxilo  ", "Sala da Retaguarda Cirúrgica Box  ", "Sala da TI  ", "Sala de Diálise  ", "Sala dos Médicos Cardio  ", "Sala dos Médicos CTI Adulto  ", "Sala dos Médicos Enfermaria Pediatria  ", "Sala dos Médicos Unidade Coronária  ", "Sala de Medicação  ", "Sala dos Médicos Ortopedia  ", "Sala Médicos Vermelha - Lado NIR  ", "Sala Vermelha  ", "Sala Vermelha - Médicos  ", "Sala Médicos Neuro  ", "Saúde Mental  ", "Serviço Social  ", "Trauma  ", "UI Cirurgia Geral  ", "UI da Neuro  ", "Ultrassonografia - Radiologia  ", "Unidade Coronária" });
            cmbSetor.Location = new Point(90, 30);
            cmbSetor.Name = "cmbSetor";
            cmbSetor.Size = new Size(370, 29);
            cmbSetor.TabIndex = 0;
            // 
            // cmbAndar
            // 
            cmbAndar.DisplayMember = "0";
            cmbAndar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAndar.FormattingEnabled = true;
            cmbAndar.Items.AddRange(new object[] { "Térreo", "1º Andar", "2º Andar", "3º Andar", "4º Andar", "5º Andar", "6º Andar", "7º Andar", "Anexo" });
            cmbAndar.Location = new Point(90, 70);
            cmbAndar.Name = "cmbAndar";
            cmbAndar.Size = new Size(121, 29);
            cmbAndar.TabIndex = 1;
            // 
            // lblSetor
            // 
            lblSetor.AutoSize = true;
            lblSetor.Font = new Font("Segoe UI", 12F);
            lblSetor.Location = new Point(15, 35);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(50, 21);
            lblSetor.TabIndex = 0;
            lblSetor.Text = "Setor:";
            // 
            // lblAndar
            // 
            lblAndar.AutoSize = true;
            lblAndar.Font = new Font("Segoe UI", 12F);
            lblAndar.Location = new Point(15, 75);
            lblAndar.Name = "lblAndar";
            lblAndar.Size = new Size(55, 21);
            lblAndar.TabIndex = 2;
            lblAndar.Text = "Andar:";
            // 
            // grpComputador
            // 
            grpComputador.BackColor = Color.FromArgb(240, 240, 240);
            grpComputador.Controls.Add(cmbModeloComp);
            grpComputador.Controls.Add(cmbMarcaComp);
            grpComputador.Controls.Add(lblNumSerie);
            grpComputador.Controls.Add(txtNumeroSerie);
            grpComputador.Controls.Add(lblNomenclatura);
            grpComputador.Controls.Add(txtNomenclatura);
            grpComputador.Controls.Add(lblMarcaComp);
            grpComputador.Controls.Add(lblModeloComp);
            grpComputador.Controls.Add(lblSistema);
            grpComputador.Controls.Add(txtSistema);
            grpComputador.Controls.Add(lblProcessador);
            grpComputador.Controls.Add(txtProcessador);
            grpComputador.Controls.Add(lblMemoria);
            grpComputador.Controls.Add(txtMemoria);
            grpComputador.Controls.Add(lblHdSsd);
            grpComputador.Controls.Add(txtHdSsd);
            grpComputador.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpComputador.Location = new Point(10, 151);
            grpComputador.Name = "grpComputador";
            grpComputador.Size = new Size(480, 354);
            grpComputador.TabIndex = 1;
            grpComputador.TabStop = false;
            grpComputador.Text = "Computador:";
            // 
            // cmbModeloComp
            // 
            cmbModeloComp.DisplayMember = "0";
            cmbModeloComp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbModeloComp.FormattingEnabled = true;
            cmbModeloComp.Items.AddRange(new object[] { "C610", "C610 Minipro", "COMPAQ 6005 PRO", "D17S", "D330", "D3400", "DC2D-S", "DC3A-U", "FQC-01263", "FQC-01265", "H510", "H55H-CM", "Montado", "MS-7E05", "MSI - 7592", "OPTIPLEX 390", "PIQ77CL", "POS-PIQ77CL" });
            cmbModeloComp.Location = new Point(140, 110);
            cmbModeloComp.Name = "cmbModeloComp";
            cmbModeloComp.Size = new Size(320, 29);
            cmbModeloComp.TabIndex = 4;
            // 
            // cmbMarcaComp
            // 
            cmbMarcaComp.DisplayMember = "0";
            cmbMarcaComp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMarcaComp.FormattingEnabled = true;
            cmbMarcaComp.Items.AddRange(new object[] { "Daten", "Dell", "HP", "Montado", "Positivo", "Positivo Master", "Positivo Master Mini Pro" });
            cmbMarcaComp.Location = new Point(140, 70);
            cmbMarcaComp.Name = "cmbMarcaComp";
            cmbMarcaComp.Size = new Size(320, 29);
            cmbMarcaComp.TabIndex = 3;
            // 
            // lblNumSerie
            // 
            lblNumSerie.AutoSize = true;
            lblNumSerie.Font = new Font("Segoe UI", 12F);
            lblNumSerie.Location = new Point(15, 315);
            lblNumSerie.Name = "lblNumSerie";
            lblNumSerie.Size = new Size(92, 21);
            lblNumSerie.TabIndex = 14;
            lblNumSerie.Text = "Nº de Série:";
            // 
            // txtNumeroSerie
            // 
            txtNumeroSerie.Font = new Font("Segoe UI", 12F);
            txtNumeroSerie.Location = new Point(140, 310);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new Size(320, 29);
            txtNumeroSerie.TabIndex = 9;
            // 
            // lblNomenclatura
            // 
            lblNomenclatura.AutoSize = true;
            lblNomenclatura.Font = new Font("Segoe UI", 12F);
            lblNomenclatura.Location = new Point(15, 35);
            lblNomenclatura.Name = "lblNomenclatura";
            lblNomenclatura.Size = new Size(112, 21);
            lblNomenclatura.TabIndex = 0;
            lblNomenclatura.Text = "Nomenclatura:";
            // 
            // txtNomenclatura
            // 
            txtNomenclatura.Font = new Font("Segoe UI", 12F);
            txtNomenclatura.Location = new Point(140, 30);
            txtNomenclatura.Name = "txtNomenclatura";
            txtNomenclatura.Size = new Size(320, 29);
            txtNomenclatura.TabIndex = 2;
            // 
            // lblMarcaComp
            // 
            lblMarcaComp.AutoSize = true;
            lblMarcaComp.Font = new Font("Segoe UI", 12F);
            lblMarcaComp.Location = new Point(15, 75);
            lblMarcaComp.Name = "lblMarcaComp";
            lblMarcaComp.Size = new Size(56, 21);
            lblMarcaComp.TabIndex = 2;
            lblMarcaComp.Text = "Marca:";
            // 
            // lblModeloComp
            // 
            lblModeloComp.AutoSize = true;
            lblModeloComp.Font = new Font("Segoe UI", 12F);
            lblModeloComp.Location = new Point(15, 115);
            lblModeloComp.Name = "lblModeloComp";
            lblModeloComp.Size = new Size(66, 21);
            lblModeloComp.TabIndex = 4;
            lblModeloComp.Text = "Modelo:";
            // 
            // lblSistema
            // 
            lblSistema.AutoSize = true;
            lblSistema.Font = new Font("Segoe UI", 12F);
            lblSistema.Location = new Point(15, 155);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(68, 21);
            lblSistema.TabIndex = 6;
            lblSistema.Text = "Sistema:";
            // 
            // txtSistema
            // 
            txtSistema.Font = new Font("Segoe UI", 12F);
            txtSistema.Location = new Point(140, 150);
            txtSistema.Name = "txtSistema";
            txtSistema.Size = new Size(320, 29);
            txtSistema.TabIndex = 5;
            // 
            // lblProcessador
            // 
            lblProcessador.AutoSize = true;
            lblProcessador.Font = new Font("Segoe UI", 12F);
            lblProcessador.Location = new Point(15, 195);
            lblProcessador.Name = "lblProcessador";
            lblProcessador.Size = new Size(98, 21);
            lblProcessador.TabIndex = 8;
            lblProcessador.Text = "Processador:";
            // 
            // txtProcessador
            // 
            txtProcessador.Font = new Font("Segoe UI", 12F);
            txtProcessador.Location = new Point(140, 190);
            txtProcessador.Name = "txtProcessador";
            txtProcessador.Size = new Size(320, 29);
            txtProcessador.TabIndex = 6;
            // 
            // lblMemoria
            // 
            lblMemoria.AutoSize = true;
            lblMemoria.Font = new Font("Segoe UI", 12F);
            lblMemoria.Location = new Point(15, 235);
            lblMemoria.Name = "lblMemoria";
            lblMemoria.Size = new Size(76, 21);
            lblMemoria.TabIndex = 10;
            lblMemoria.Text = "Memória:";
            // 
            // txtMemoria
            // 
            txtMemoria.Font = new Font("Segoe UI", 12F);
            txtMemoria.Location = new Point(140, 230);
            txtMemoria.Name = "txtMemoria";
            txtMemoria.Size = new Size(320, 29);
            txtMemoria.TabIndex = 7;
            // 
            // lblHdSsd
            // 
            lblHdSsd.AutoSize = true;
            lblHdSsd.Font = new Font("Segoe UI", 12F);
            lblHdSsd.Location = new Point(15, 275);
            lblHdSsd.Name = "lblHdSsd";
            lblHdSsd.Size = new Size(70, 21);
            lblHdSsd.TabIndex = 12;
            lblHdSsd.Text = "HD/SSD:";
            // 
            // txtHdSsd
            // 
            txtHdSsd.Font = new Font("Segoe UI", 12F);
            txtHdSsd.Location = new Point(140, 270);
            txtHdSsd.Name = "txtHdSsd";
            txtHdSsd.Size = new Size(320, 29);
            txtHdSsd.TabIndex = 8;
            // 
            // grpMonitor1
            // 
            grpMonitor1.BackColor = Color.FromArgb(240, 240, 240);
            grpMonitor1.Controls.Add(lblMarcaMon1);
            grpMonitor1.Controls.Add(txtMarcaMon1);
            grpMonitor1.Controls.Add(lblModeloMon1);
            grpMonitor1.Controls.Add(txtModeloMon1);
            grpMonitor1.Controls.Add(lblNumSerieMon1);
            grpMonitor1.Controls.Add(txtNumSerieMon1);
            grpMonitor1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpMonitor1.Location = new Point(500, 31);
            grpMonitor1.Name = "grpMonitor1";
            grpMonitor1.Size = new Size(510, 150);
            grpMonitor1.TabIndex = 2;
            grpMonitor1.TabStop = false;
            grpMonitor1.Text = "Monitor 1:";
            // 
            // lblMarcaMon1
            // 
            lblMarcaMon1.AutoSize = true;
            lblMarcaMon1.Font = new Font("Segoe UI", 12F);
            lblMarcaMon1.Location = new Point(15, 35);
            lblMarcaMon1.Name = "lblMarcaMon1";
            lblMarcaMon1.Size = new Size(56, 21);
            lblMarcaMon1.TabIndex = 0;
            lblMarcaMon1.Text = "Marca:";
            // 
            // txtMarcaMon1
            // 
            txtMarcaMon1.Font = new Font("Segoe UI", 12F);
            txtMarcaMon1.Location = new Point(110, 30);
            txtMarcaMon1.Name = "txtMarcaMon1";
            txtMarcaMon1.Size = new Size(380, 29);
            txtMarcaMon1.TabIndex = 10;
            // 
            // lblModeloMon1
            // 
            lblModeloMon1.AutoSize = true;
            lblModeloMon1.Font = new Font("Segoe UI", 12F);
            lblModeloMon1.Location = new Point(15, 75);
            lblModeloMon1.Name = "lblModeloMon1";
            lblModeloMon1.Size = new Size(66, 21);
            lblModeloMon1.TabIndex = 2;
            lblModeloMon1.Text = "Modelo:";
            // 
            // txtModeloMon1
            // 
            txtModeloMon1.Font = new Font("Segoe UI", 12F);
            txtModeloMon1.Location = new Point(110, 70);
            txtModeloMon1.Name = "txtModeloMon1";
            txtModeloMon1.Size = new Size(380, 29);
            txtModeloMon1.TabIndex = 11;
            // 
            // lblNumSerieMon1
            // 
            lblNumSerieMon1.AutoSize = true;
            lblNumSerieMon1.Font = new Font("Segoe UI", 12F);
            lblNumSerieMon1.Location = new Point(15, 115);
            lblNumSerieMon1.Name = "lblNumSerieMon1";
            lblNumSerieMon1.Size = new Size(92, 21);
            lblNumSerieMon1.TabIndex = 4;
            lblNumSerieMon1.Text = "Nº de Série:";
            // 
            // txtNumSerieMon1
            // 
            txtNumSerieMon1.Font = new Font("Segoe UI", 12F);
            txtNumSerieMon1.Location = new Point(110, 110);
            txtNumSerieMon1.Name = "txtNumSerieMon1";
            txtNumSerieMon1.Size = new Size(380, 29);
            txtNumSerieMon1.TabIndex = 12;
            // 
            // grpMonitor2
            // 
            grpMonitor2.BackColor = Color.FromArgb(240, 240, 240);
            grpMonitor2.Controls.Add(lblMarcaMon2);
            grpMonitor2.Controls.Add(txtMarcaMon2);
            grpMonitor2.Controls.Add(lblModeloMon2);
            grpMonitor2.Controls.Add(txtModeloMon2);
            grpMonitor2.Controls.Add(lblNumSerieMon2);
            grpMonitor2.Controls.Add(txtNumSerieMon2);
            grpMonitor2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpMonitor2.Location = new Point(500, 191);
            grpMonitor2.Name = "grpMonitor2";
            grpMonitor2.Size = new Size(510, 150);
            grpMonitor2.TabIndex = 3;
            grpMonitor2.TabStop = false;
            grpMonitor2.Text = "Monitor 2:";
            // 
            // lblMarcaMon2
            // 
            lblMarcaMon2.AutoSize = true;
            lblMarcaMon2.Font = new Font("Segoe UI", 12F);
            lblMarcaMon2.Location = new Point(15, 35);
            lblMarcaMon2.Name = "lblMarcaMon2";
            lblMarcaMon2.Size = new Size(56, 21);
            lblMarcaMon2.TabIndex = 0;
            lblMarcaMon2.Text = "Marca:";
            // 
            // txtMarcaMon2
            // 
            txtMarcaMon2.Font = new Font("Segoe UI", 12F);
            txtMarcaMon2.Location = new Point(110, 30);
            txtMarcaMon2.Name = "txtMarcaMon2";
            txtMarcaMon2.Size = new Size(380, 29);
            txtMarcaMon2.TabIndex = 13;
            // 
            // lblModeloMon2
            // 
            lblModeloMon2.AutoSize = true;
            lblModeloMon2.Font = new Font("Segoe UI", 12F);
            lblModeloMon2.Location = new Point(15, 75);
            lblModeloMon2.Name = "lblModeloMon2";
            lblModeloMon2.Size = new Size(66, 21);
            lblModeloMon2.TabIndex = 2;
            lblModeloMon2.Text = "Modelo:";
            // 
            // txtModeloMon2
            // 
            txtModeloMon2.Font = new Font("Segoe UI", 12F);
            txtModeloMon2.Location = new Point(110, 70);
            txtModeloMon2.Name = "txtModeloMon2";
            txtModeloMon2.Size = new Size(380, 29);
            txtModeloMon2.TabIndex = 14;
            // 
            // lblNumSerieMon2
            // 
            lblNumSerieMon2.AutoSize = true;
            lblNumSerieMon2.Font = new Font("Segoe UI", 12F);
            lblNumSerieMon2.Location = new Point(15, 115);
            lblNumSerieMon2.Name = "lblNumSerieMon2";
            lblNumSerieMon2.Size = new Size(92, 21);
            lblNumSerieMon2.TabIndex = 4;
            lblNumSerieMon2.Text = "Nº de Série:";
            // 
            // txtNumSerieMon2
            // 
            txtNumSerieMon2.Font = new Font("Segoe UI", 12F);
            txtNumSerieMon2.Location = new Point(110, 110);
            txtNumSerieMon2.Name = "txtNumSerieMon2";
            txtNumSerieMon2.Size = new Size(380, 29);
            txtNumSerieMon2.TabIndex = 15;
            // 
            // lblTecnicoResp
            // 
            lblTecnicoResp.AutoSize = true;
            lblTecnicoResp.Font = new Font("Segoe UI", 12F);
            lblTecnicoResp.Location = new Point(515, 363);
            lblTecnicoResp.Name = "lblTecnicoResp";
            lblTecnicoResp.Size = new Size(154, 21);
            lblTecnicoResp.TabIndex = 4;
            lblTecnicoResp.Text = "Técnico Responsável:";
            // 
            // txtTecnicoResp
            // 
            txtTecnicoResp.Font = new Font("Segoe UI", 12F);
            txtTecnicoResp.Location = new Point(690, 360);
            txtTecnicoResp.Name = "txtTecnicoResp";
            txtTecnicoResp.Size = new Size(300, 29);
            txtTecnicoResp.TabIndex = 16;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEditar.Font = new Font("Segoe UI", 12F);
            btnEditar.Location = new Point(220, 573);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(180, 40);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar Selecionado";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSalvar.Font = new Font("Segoe UI", 12F);
            btnSalvar.Location = new Point(420, 573);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(180, 40);
            btnSalvar.TabIndex = 20;
            btnSalvar.Text = "Salvar Alterações";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeletar.Font = new Font("Segoe UI", 12F);
            btnDeletar.Location = new Point(620, 573);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(180, 40);
            btnDeletar.TabIndex = 21;
            btnDeletar.Text = "Excluir Selecionado";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnColetar
            // 
            btnColetar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnColetar.Font = new Font("Segoe UI", 12F);
            btnColetar.Location = new Point(20, 573);
            btnColetar.Name = "btnColetar";
            btnColetar.Size = new Size(180, 40);
            btnColetar.TabIndex = 18;
            btnColetar.Text = "Coletar Informações";
            btnColetar.UseVisualStyleBackColor = true;
            btnColetar.Click += btnColetar_Click;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnExportarExcel.Font = new Font("Segoe UI", 12F);
            btnExportarExcel.Location = new Point(820, 573);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(180, 40);
            btnExportarExcel.TabIndex = 22;
            btnExportarExcel.Text = "Exportar para Excel";
            btnExportarExcel.UseVisualStyleBackColor = true;
            btnExportarExcel.Click += btnExportarExcel_Click;
            // 
            // dgvFichaTech
            // 
            dgvFichaTech.AllowUserToAddRows = false;
            dgvFichaTech.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFichaTech.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvFichaTech.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvFichaTech.Font = new Font("Segoe UI", 12F);
            dgvFichaTech.Location = new Point(10, 625);
            dgvFichaTech.Name = "dgvFichaTech";
            dgvFichaTech.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFichaTech.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFichaTech.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFichaTech.Size = new Size(1000, 304);
            dgvFichaTech.TabIndex = 26;
            // 
            // panelRodape
            // 
            panelRodape.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRodape.BackColor = Color.FromArgb(240, 240, 240);
            panelRodape.Controls.Add(lblInfoSistema);
            panelRodape.Location = new Point(0, 931);
            panelRodape.Name = "panelRodape";
            panelRodape.Padding = new Padding(10, 5, 10, 5);
            panelRodape.Size = new Size(1024, 30);
            panelRodape.TabIndex = 0;
            // 
            // lblInfoSistema
            // 
            lblInfoSistema.AutoSize = true;
            lblInfoSistema.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoSistema.ForeColor = Color.Black;
            lblInfoSistema.Location = new Point(10, 5);
            lblInfoSistema.Name = "lblInfoSistema";
            lblInfoSistema.Size = new Size(849, 17);
            lblInfoSistema.TabIndex = 0;
            lblInfoSistema.Text = "Sistema FichaTech | Versão: v1.0.0 | Desenvolvido por Hilton Santos | Contato: hsinfoetec@gmail.com | © 2025 Todos os direitos reservados";
            // 
            // lblPesquisar
            // 
            lblPesquisar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPesquisar.AutoSize = true;
            lblPesquisar.Font = new Font("Segoe UI", 12F);
            lblPesquisar.Location = new Point(20, 526);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(79, 21);
            lblPesquisar.TabIndex = 4;
            lblPesquisar.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisar.Font = new Font("Segoe UI", 12F);
            txtPesquisar.Location = new Point(105, 522);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(180, 29);
            txtPesquisar.TabIndex = 23;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPesquisar.Font = new Font("Segoe UI", 12F);
            btnPesquisar.Location = new Point(291, 522);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(109, 29);
            btnPesquisar.TabIndex = 24;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 12F);
            btnLimpar.Location = new Point(896, 395);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnImportarPlanilha
            // 
            btnImportarPlanilha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnImportarPlanilha.Font = new Font("Segoe UI", 12F);
            btnImportarPlanilha.Location = new Point(820, 522);
            btnImportarPlanilha.Name = "btnImportarPlanilha";
            btnImportarPlanilha.Size = new Size(180, 40);
            btnImportarPlanilha.TabIndex = 25;
            btnImportarPlanilha.Text = "Importar Planilha";
            btnImportarPlanilha.UseVisualStyleBackColor = true;
            btnImportarPlanilha.Click += btnImportarPlanilha_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(420, 522);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 40);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Calcelar Edição";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmFichaTech
            // 
            ClientSize = new Size(1024, 961);
            Controls.Add(btnCancelar);
            Controls.Add(btnImportarPlanilha);
            Controls.Add(btnLimpar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(panelRodape);
            Controls.Add(grpLocalizacao);
            Controls.Add(grpComputador);
            Controls.Add(grpMonitor1);
            Controls.Add(grpMonitor2);
            Controls.Add(lblTecnicoResp);
            Controls.Add(txtTecnicoResp);
            Controls.Add(btnColetar);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnDeletar);
            Controls.Add(btnExportarExcel);
            Controls.Add(dgvFichaTech);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmFichaTech";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FichaTech";
            Load += frmFichaTech_Load;
            grpLocalizacao.ResumeLayout(false);
            grpLocalizacao.PerformLayout();
            grpComputador.ResumeLayout(false);
            grpComputador.PerformLayout();
            grpMonitor1.ResumeLayout(false);
            grpMonitor1.PerformLayout();
            grpMonitor2.ResumeLayout(false);
            grpMonitor2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFichaTech).EndInit();
            panelRodape.ResumeLayout(false);
            panelRodape.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpLocalizacao;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.Label lblAndar;
        private System.Windows.Forms.ComboBox cmbAndar;

        private System.Windows.Forms.GroupBox grpComputador;
        private System.Windows.Forms.Label lblNomenclatura;
        private System.Windows.Forms.TextBox txtNomenclatura;
        private System.Windows.Forms.Label lblMarcaComp;
        private System.Windows.Forms.Label lblModeloComp;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.TextBox txtSistema;
        private System.Windows.Forms.Label lblProcessador;
        private System.Windows.Forms.TextBox txtProcessador;
        private System.Windows.Forms.Label lblMemoria;
        private System.Windows.Forms.TextBox txtMemoria;
        private System.Windows.Forms.Label lblHdSsd;
        private System.Windows.Forms.TextBox txtHdSsd;

        private System.Windows.Forms.GroupBox grpMonitor1;
        private System.Windows.Forms.Label lblMarcaMon1;
        private System.Windows.Forms.TextBox txtMarcaMon1;
        private System.Windows.Forms.Label lblModeloMon1;
        private System.Windows.Forms.TextBox txtModeloMon1;
        private System.Windows.Forms.Label lblNumSerieMon1;
        private System.Windows.Forms.TextBox txtNumSerieMon1;

        private System.Windows.Forms.GroupBox grpMonitor2;
        private System.Windows.Forms.Label lblMarcaMon2;
        private System.Windows.Forms.TextBox txtMarcaMon2;
        private System.Windows.Forms.Label lblModeloMon2;
        private System.Windows.Forms.TextBox txtModeloMon2;
        private System.Windows.Forms.Label lblNumSerieMon2;
        private System.Windows.Forms.TextBox txtNumSerieMon2;

        private System.Windows.Forms.Label lblTecnicoResp;
        private System.Windows.Forms.TextBox txtTecnicoResp;

        private System.Windows.Forms.Button btnColetar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnExportarExcel;

        private System.Windows.Forms.DataGridView dgvFichaTech;

        private System.Windows.Forms.Panel panelRodape;
        private System.Windows.Forms.Label lblInfoSistema;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private Label lblNumSerie;
        private TextBox txtNumeroSerie;
        private ComboBox cmbSetor;
        private ComboBox cmbMarcaComp;
        private ComboBox cmbModeloComp;
        private Button btnLimpar;
        private Button btnImportarPlanilha;
        private Button btnCancelar;
    }
}