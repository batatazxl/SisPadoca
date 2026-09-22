namespace SisPadoca
{
    partial class FrmProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ImgLista = new ImageList(components);
            PbxImagem = new PictureBox();
            LblNCM = new Label();
            TxbNCM = new TextBox();
            TxbDescricao = new TextBox();
            LblDescricao = new Label();
            TxbCodigoBarras = new TextBox();
            LblCodigoBarras = new Label();
            LblUnidade = new Label();
            CmbMedida = new ComboBox();
            BtnNovo = new Button();
            TxbLote = new TextBox();
            LblLote = new Label();
            BtnEditar = new Button();
            BtnExcluir = new Button();
            BtnLimpar = new Button();
            BtnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)PbxImagem).BeginInit();
            SuspendLayout();
            // 
            // ImgLista
            // 
            ImgLista.ColorDepth = ColorDepth.Depth32Bit;
            ImgLista.ImageSize = new Size(16, 16);
            ImgLista.TransparentColor = Color.Transparent;
            // 
            // PbxImagem
            // 
            PbxImagem.Location = new Point(89, 12);
            PbxImagem.Name = "PbxImagem";
            PbxImagem.Size = new Size(197, 247);
            PbxImagem.TabIndex = 0;
            PbxImagem.TabStop = false;
            // 
            // LblNCM
            // 
            LblNCM.AutoSize = true;
            LblNCM.Location = new Point(322, 12);
            LblNCM.Name = "LblNCM";
            LblNCM.Size = new Size(52, 25);
            LblNCM.TabIndex = 1;
            LblNCM.Text = "NCM";
            // 
            // TxbNCM
            // 
            TxbNCM.Location = new Point(322, 49);
            TxbNCM.Name = "TxbNCM";
            TxbNCM.Size = new Size(168, 31);
            TxbNCM.TabIndex = 2;
            // 
            // TxbDescricao
            // 
            TxbDescricao.Location = new Point(322, 136);
            TxbDescricao.Name = "TxbDescricao";
            TxbDescricao.Size = new Size(286, 31);
            TxbDescricao.TabIndex = 4;
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Location = new Point(322, 99);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(88, 25);
            LblDescricao.TabIndex = 3;
            LblDescricao.Text = "Descrição";
            // 
            // TxbCodigoBarras
            // 
            TxbCodigoBarras.Location = new Point(322, 228);
            TxbCodigoBarras.Name = "TxbCodigoBarras";
            TxbCodigoBarras.Size = new Size(286, 31);
            TxbCodigoBarras.TabIndex = 6;
            // 
            // LblCodigoBarras
            // 
            LblCodigoBarras.AutoSize = true;
            LblCodigoBarras.Location = new Point(322, 191);
            LblCodigoBarras.Name = "LblCodigoBarras";
            LblCodigoBarras.Size = new Size(149, 25);
            LblCodigoBarras.TabIndex = 5;
            LblCodigoBarras.Text = "Código de Barras";
            // 
            // LblUnidade
            // 
            LblUnidade.AutoSize = true;
            LblUnidade.Location = new Point(634, 99);
            LblUnidade.Name = "LblUnidade";
            LblUnidade.Size = new Size(168, 25);
            LblUnidade.TabIndex = 7;
            LblUnidade.Text = "Unidade de Medida";
            // 
            // CmbMedida
            // 
            CmbMedida.FormattingEnabled = true;
            CmbMedida.Items.AddRange(new object[] { "Unitário", "Kilo", "Dúzia" });
            CmbMedida.Location = new Point(634, 136);
            CmbMedida.Name = "CmbMedida";
            CmbMedida.Size = new Size(214, 33);
            CmbMedida.TabIndex = 8;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(89, 279);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(147, 80);
            BtnNovo.TabIndex = 9;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            // 
            // TxbLote
            // 
            TxbLote.Location = new Point(634, 228);
            TxbLote.Name = "TxbLote";
            TxbLote.Size = new Size(214, 31);
            TxbLote.TabIndex = 11;
            // 
            // LblLote
            // 
            LblLote.AutoSize = true;
            LblLote.Location = new Point(634, 191);
            LblLote.Name = "LblLote";
            LblLote.Size = new Size(46, 25);
            LblLote.TabIndex = 10;
            LblLote.Text = "Lote";
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(242, 279);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(147, 80);
            BtnEditar.TabIndex = 12;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(395, 279);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(147, 80);
            BtnExcluir.TabIndex = 13;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(548, 279);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(147, 80);
            BtnLimpar.TabIndex = 14;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(701, 279);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(147, 80);
            BtnFechar.TabIndex = 15;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 550);
            Controls.Add(BtnFechar);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(TxbLote);
            Controls.Add(LblLote);
            Controls.Add(BtnNovo);
            Controls.Add(CmbMedida);
            Controls.Add(LblUnidade);
            Controls.Add(TxbCodigoBarras);
            Controls.Add(LblCodigoBarras);
            Controls.Add(TxbDescricao);
            Controls.Add(LblDescricao);
            Controls.Add(TxbNCM);
            Controls.Add(LblNCM);
            Controls.Add(PbxImagem);
            Name = "FrmProdutos";
            Text = "FrmProdutos";
            ((System.ComponentModel.ISupportInitialize)PbxImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList ImgLista;
        private PictureBox PbxImagem;
        private Label LblNCM;
        private TextBox TxbNCM;
        private TextBox TxbDescricao;
        private Label LblDescricao;
        private TextBox TxbCodigoBarras;
        private Label LblCodigoBarras;
        private Label LblUnidade;
        private ComboBox CmbMedida;
        private Button BtnNovo;
        private TextBox TxbLote;
        private Label LblLote;
        private Button BtnEditar;
        private Button BtnExcluir;
        private Button BtnLimpar;
        private Button BtnFechar;
    }
}