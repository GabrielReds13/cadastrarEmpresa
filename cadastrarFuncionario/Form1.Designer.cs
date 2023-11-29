namespace CadastrarFuncionario
{
    partial class Form1
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.cb_sitCadastral = new System.Windows.Forms.ComboBox();
            this.btn_limpar = new System.Windows.Forms.PictureBox();
            this.btn_salvar = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.cb_porteEmpresa = new System.Windows.Forms.ComboBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lb_empresas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txt_inicioAtividade = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.cb_regTributario = new System.Windows.Forms.ComboBox();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.cb_natJuridica = new System.Windows.Forms.ComboBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.txt_razaoSocial = new System.Windows.Forms.TextBox();
            this.txt_capitalSocial = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_limpar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.txt_nome.Location = new System.Drawing.Point(54, 143);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(0);
            this.txt_nome.Multiline = true;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(366, 28);
            this.txt_nome.TabIndex = 2;
            this.txt_nome.Text = "Nome fantasia";
            // 
            // cb_sitCadastral
            // 
            this.cb_sitCadastral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sitCadastral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.cb_sitCadastral.FormattingEnabled = true;
            this.cb_sitCadastral.Items.AddRange(new object[] {
            "Ativa",
            "Nula",
            "Suspensa",
            "Inapta",
            "Baixada"});
            this.cb_sitCadastral.Location = new System.Drawing.Point(54, 250);
            this.cb_sitCadastral.Margin = new System.Windows.Forms.Padding(0);
            this.cb_sitCadastral.Name = "cb_sitCadastral";
            this.cb_sitCadastral.Size = new System.Drawing.Size(366, 28);
            this.cb_sitCadastral.TabIndex = 7;
            this.cb_sitCadastral.Text = "Situação cadastral";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Image = global::CadastrarFuncionario.Properties.Resources.Clear;
            this.btn_limpar.Location = new System.Drawing.Point(242, 627);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(178, 50);
            this.btn_limpar.TabIndex = 9;
            this.btn_limpar.TabStop = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Image = global::CadastrarFuncionario.Properties.Resources.Save_Off;
            this.btn_salvar.Location = new System.Drawing.Point(54, 627);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(178, 50);
            this.btn_salvar.TabIndex = 8;
            this.btn_salvar.TabStop = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(54, 221);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.pictureBox4.Size = new System.Drawing.Size(366, 2);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(54, 171);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.pictureBox2.Size = new System.Drawing.Size(366, 2);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CadastrarFuncionario.Properties.Resources.User_Photo;
            this.pictureBox1.Location = new System.Drawing.Point(195, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(54, 317);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.pictureBox6.Size = new System.Drawing.Size(112, 2);
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // cb_porteEmpresa
            // 
            this.cb_porteEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_porteEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.cb_porteEmpresa.FormattingEnabled = true;
            this.cb_porteEmpresa.Items.AddRange(new object[] {
            "Pequena",
            "Média",
            "Grande"});
            this.cb_porteEmpresa.Location = new System.Drawing.Point(183, 347);
            this.cb_porteEmpresa.Margin = new System.Windows.Forms.Padding(0);
            this.cb_porteEmpresa.Name = "cb_porteEmpresa";
            this.cb_porteEmpresa.Size = new System.Drawing.Size(237, 28);
            this.cb_porteEmpresa.TabIndex = 14;
            this.cb_porteEmpresa.Text = "Porte da empresa";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.Location = new System.Drawing.Point(54, 373);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.pictureBox9.Size = new System.Drawing.Size(112, 2);
            this.pictureBox9.TabIndex = 19;
            this.pictureBox9.TabStop = false;
            // 
            // lb_empresas
            // 
            this.lb_empresas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.lb_empresas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_empresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empresas.ForeColor = System.Drawing.Color.White;
            this.lb_empresas.FormattingEnabled = true;
            this.lb_empresas.Location = new System.Drawing.Point(521, 63);
            this.lb_empresas.Name = "lb_empresas";
            this.lb_empresas.Size = new System.Drawing.Size(889, 598);
            this.lb_empresas.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(515, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Empresas";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(464, 21);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.pictureBox3.Size = new System.Drawing.Size(2, 656);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // txt_cpf
            // 
            this.txt_cpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_cpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.txt_cpf.Location = new System.Drawing.Point(54, 289);
            this.txt_cpf.Margin = new System.Windows.Forms.Padding(0);
            this.txt_cpf.Mask = "000,000,000-00";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(112, 19);
            this.txt_cpf.TabIndex = 25;
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.txt_cnpj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_cnpj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.txt_cnpj.Location = new System.Drawing.Point(183, 289);
            this.txt_cnpj.Margin = new System.Windows.Forms.Padding(0);
            this.txt_cnpj.Mask = "00,000,000/0000-00";
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(143, 19);
            this.txt_cnpj.TabIndex = 27;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(183, 317);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.pictureBox5.Size = new System.Drawing.Size(143, 2);
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // txt_inicioAtividade
            // 
            this.txt_inicioAtividade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.txt_inicioAtividade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_inicioAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_inicioAtividade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.txt_inicioAtividade.Location = new System.Drawing.Point(340, 289);
            this.txt_inicioAtividade.Margin = new System.Windows.Forms.Padding(0);
            this.txt_inicioAtividade.Mask = "00/00/0000";
            this.txt_inicioAtividade.Name = "txt_inicioAtividade";
            this.txt_inicioAtividade.Size = new System.Drawing.Size(80, 19);
            this.txt_inicioAtividade.TabIndex = 29;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Location = new System.Drawing.Point(340, 317);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.pictureBox7.Size = new System.Drawing.Size(80, 2);
            this.pictureBox7.TabIndex = 28;
            this.pictureBox7.TabStop = false;
            // 
            // txt_telefone
            // 
            this.txt_telefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.txt_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_telefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.txt_telefone.Location = new System.Drawing.Point(54, 344);
            this.txt_telefone.Margin = new System.Windows.Forms.Padding(0);
            this.txt_telefone.Mask = "(00) 00000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(112, 19);
            this.txt_telefone.TabIndex = 30;
            // 
            // cb_regTributario
            // 
            this.cb_regTributario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_regTributario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.cb_regTributario.FormattingEnabled = true;
            this.cb_regTributario.Items.AddRange(new object[] {
            "Simples nacional",
            "Lucro presumido",
            "Real"});
            this.cb_regTributario.Location = new System.Drawing.Point(54, 401);
            this.cb_regTributario.Margin = new System.Windows.Forms.Padding(0);
            this.cb_regTributario.Name = "cb_regTributario";
            this.cb_regTributario.Size = new System.Drawing.Size(195, 28);
            this.cb_regTributario.TabIndex = 31;
            this.cb_regTributario.Text = "Regime tributário";
            // 
            // cb_tipo
            // 
            this.cb_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Matriz",
            "Filial"});
            this.cb_tipo.Location = new System.Drawing.Point(270, 401);
            this.cb_tipo.Margin = new System.Windows.Forms.Padding(0);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(150, 28);
            this.cb_tipo.TabIndex = 32;
            this.cb_tipo.Text = "Tipo";
            // 
            // cb_natJuridica
            // 
            this.cb_natJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_natJuridica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.cb_natJuridica.FormattingEnabled = true;
            this.cb_natJuridica.Items.AddRange(new object[] {
            "EI – Empresário Individual",
            "MEI – Microempreendedor Individual",
            "Sociedade Anônima",
            "Sociedade Simples Limitada",
            "Sociedade Limitada Unipessoal"});
            this.cb_natJuridica.Location = new System.Drawing.Point(54, 453);
            this.cb_natJuridica.Margin = new System.Windows.Forms.Padding(0);
            this.cb_natJuridica.Name = "cb_natJuridica";
            this.cb_natJuridica.Size = new System.Drawing.Size(366, 28);
            this.cb_natJuridica.TabIndex = 33;
            this.cb_natJuridica.Text = "Natureza jurídica";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.White;
            this.pictureBox10.Location = new System.Drawing.Point(54, 533);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.pictureBox10.Size = new System.Drawing.Size(366, 2);
            this.pictureBox10.TabIndex = 35;
            this.pictureBox10.TabStop = false;
            // 
            // txt_razaoSocial
            // 
            this.txt_razaoSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.txt_razaoSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_razaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_razaoSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.txt_razaoSocial.Location = new System.Drawing.Point(54, 193);
            this.txt_razaoSocial.Margin = new System.Windows.Forms.Padding(0);
            this.txt_razaoSocial.Multiline = true;
            this.txt_razaoSocial.Name = "txt_razaoSocial";
            this.txt_razaoSocial.Size = new System.Drawing.Size(366, 28);
            this.txt_razaoSocial.TabIndex = 36;
            this.txt_razaoSocial.Text = "Razão social";
            // 
            // txt_capitalSocial
            // 
            this.txt_capitalSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.txt_capitalSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_capitalSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_capitalSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.txt_capitalSocial.Location = new System.Drawing.Point(54, 505);
            this.txt_capitalSocial.Margin = new System.Windows.Forms.Padding(0);
            this.txt_capitalSocial.Multiline = true;
            this.txt_capitalSocial.Name = "txt_capitalSocial";
            this.txt_capitalSocial.Size = new System.Drawing.Size(366, 28);
            this.txt_capitalSocial.TabIndex = 37;
            this.txt_capitalSocial.Text = "Capital social (R$)";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Location = new System.Drawing.Point(54, 585);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.pictureBox8.Size = new System.Drawing.Size(366, 2);
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            // 
            // txt_endereco
            // 
            this.txt_endereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.txt_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_endereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.txt_endereco.Location = new System.Drawing.Point(54, 557);
            this.txt_endereco.Margin = new System.Windows.Forms.Padding(0);
            this.txt_endereco.Multiline = true;
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(366, 28);
            this.txt_endereco.TabIndex = 17;
            this.txt_endereco.Text = "Endereço ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1446, 718);
            this.Controls.Add(this.txt_capitalSocial);
            this.Controls.Add(this.txt_razaoSocial);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.cb_natJuridica);
            this.Controls.Add(this.cb_tipo);
            this.Controls.Add(this.cb_regTributario);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_inicioAtividade);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.txt_cnpj);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_empresas);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.cb_porteEmpresa);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.cb_sitCadastral);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.Text = "System - Novo Funcionário";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_limpar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox cb_sitCadastral;
        private System.Windows.Forms.PictureBox btn_salvar;
        private System.Windows.Forms.PictureBox btn_limpar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ComboBox cb_porteEmpresa;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.ListBox lb_empresas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
        private System.Windows.Forms.MaskedTextBox txt_cnpj;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.MaskedTextBox txt_inicioAtividade;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.ComboBox cb_regTributario;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.ComboBox cb_natJuridica;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.TextBox txt_razaoSocial;
        private System.Windows.Forms.TextBox txt_capitalSocial;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox txt_endereco;
    }
}

