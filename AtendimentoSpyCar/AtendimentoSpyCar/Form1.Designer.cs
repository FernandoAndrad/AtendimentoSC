namespace AtendimentoSpyCar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lvRegistrados = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            rtxtObs = new RichTextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            mtxtTelefone2 = new MaskedTextBox();
            mtxtTelefone1 = new MaskedTextBox();
            txtEmail = new TextBox();
            lblTelefone = new Label();
            txtNome = new TextBox();
            lblObs = new Label();
            lblEmail = new Label();
            lblNome = new Label();
            toolStrip1 = new ToolStrip();
            btnRegistrar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            btnLimpar = new ToolStripButton();
            tabPage2 = new TabPage();
            toolStrip2 = new ToolStrip();
            btnAtualizar = new ToolStripButton();
            btnScript = new ToolStripButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(2, 34);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1890, 892);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lvRegistrados);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(toolStrip1);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1882, 861);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Interessados";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvRegistrados
            // 
            lvRegistrados.AllowColumnReorder = true;
            lvRegistrados.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvRegistrados.Font = new Font("Microsoft Sans Serif", 11.25F);
            lvRegistrados.ForeColor = SystemColors.WindowText;
            lvRegistrados.FullRowSelect = true;
            lvRegistrados.Location = new Point(12, 382);
            lvRegistrados.Margin = new Padding(3, 2, 3, 2);
            lvRegistrados.Name = "lvRegistrados";
            lvRegistrados.Size = new Size(1663, 466);
            lvRegistrados.TabIndex = 2;
            lvRegistrados.UseCompatibleStateImageBehavior = false;
            lvRegistrados.View = View.Details;
            lvRegistrados.SelectedIndexChanged += lvRegistrados_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "1º Telefone";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "2º Telefone";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "E-mail";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Observações";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 515;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 40);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(864, 320);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Interessado";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.0805368F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.9194641F));
            tableLayoutPanel1.Controls.Add(rtxtObs, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 2);
            tableLayoutPanel1.Controls.Add(lblTelefone, 0, 1);
            tableLayoutPanel1.Controls.Add(txtNome, 1, 0);
            tableLayoutPanel1.Controls.Add(lblObs, 0, 3);
            tableLayoutPanel1.Controls.Add(lblEmail, 0, 2);
            tableLayoutPanel1.Controls.Add(lblNome, 0, 0);
            tableLayoutPanel1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(0, 26);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.9629631F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.0370369F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tableLayoutPanel1.Size = new Size(1043, 205);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // rtxtObs
            // 
            rtxtObs.Anchor = AnchorStyles.Left;
            rtxtObs.BackColor = SystemColors.Window;
            rtxtObs.Font = new Font("Segoe UI", 9F);
            rtxtObs.Location = new Point(129, 114);
            rtxtObs.Margin = new Padding(3, 2, 3, 2);
            rtxtObs.Name = "rtxtObs";
            rtxtObs.Size = new Size(723, 85);
            rtxtObs.TabIndex = 2;
            rtxtObs.Text = "";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(mtxtTelefone2, 1, 0);
            tableLayoutPanel2.Controls.Add(mtxtTelefone1, 0, 0);
            tableLayoutPanel2.Location = new Point(129, 29);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(726, 40);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // mtxtTelefone2
            // 
            mtxtTelefone2.Anchor = AnchorStyles.Left;
            mtxtTelefone2.Font = new Font("Segoe UI", 9F);
            mtxtTelefone2.Location = new Point(366, 6);
            mtxtTelefone2.Margin = new Padding(3, 2, 3, 2);
            mtxtTelefone2.Mask = "(00) 00000-0000";
            mtxtTelefone2.Name = "mtxtTelefone2";
            mtxtTelefone2.Size = new Size(357, 27);
            mtxtTelefone2.TabIndex = 0;
            // 
            // mtxtTelefone1
            // 
            mtxtTelefone1.Anchor = AnchorStyles.Left;
            mtxtTelefone1.Font = new Font("Segoe UI", 9F);
            mtxtTelefone1.Location = new Point(3, 6);
            mtxtTelefone1.Margin = new Padding(3, 2, 3, 2);
            mtxtTelefone1.Mask = "(00) 00000-0000";
            mtxtTelefone1.Name = "mtxtTelefone1";
            mtxtTelefone1.Size = new Size(346, 27);
            mtxtTelefone1.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left;
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(129, 76);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(723, 27);
            txtEmail.TabIndex = 1;
            // 
            // lblTelefone
            // 
            lblTelefone.Anchor = AnchorStyles.Right;
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblTelefone.Location = new Point(24, 37);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(99, 24);
            lblTelefone.TabIndex = 0;
            lblTelefone.Text = "Telefones:";
            lblTelefone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Left;
            txtNome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(129, 2);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(436, 27);
            txtNome.TabIndex = 4;
            // 
            // lblObs
            // 
            lblObs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblObs.AutoSize = true;
            lblObs.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblObs.Location = new Point(6, 108);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(117, 24);
            lblObs.TabIndex = 0;
            lblObs.Text = "Observação:";
            lblObs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblEmail.Location = new Point(55, 77);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(68, 24);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "E-mail:";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblNome.Location = new Point(56, 1);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(67, 24);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Font = new Font("Microsoft Sans Serif", 4.79999971F);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnRegistrar, btnEditar, btnExcluir, btnLimpar });
            toolStrip1.Location = new Point(3, 2);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1876, 36);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "ToolStrip Principal";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnRegistrar.Image = (Image)resources.GetObject("btnRegistrar.Image");
            btnRegistrar.ImageTransparentColor = Color.Magenta;
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(179, 33);
            btnRegistrar.Text = "Registrar Ligação";
            btnRegistrar.Click += BtnRegistrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 33);
            btnEditar.Text = "Editar";
            btnEditar.Click += BtnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(92, 33);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Image = (Image)resources.GetObject("btnLimpar.Image");
            btnLimpar.ImageTransparentColor = Color.Magenta;
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(88, 33);
            btnLimpar.Text = "Limpar";
            btnLimpar.Click += btnLimpar_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 27);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1882, 861);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pendências";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            toolStrip2.Font = new Font("Microsoft Sans Serif", 8.25F);
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { btnAtualizar, btnScript });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1693, 32);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "ToolStrip Secundária";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Segoe UI", 10.8F);
            btnAtualizar.Image = (Image)resources.GetObject("btnAtualizar.Image");
            btnAtualizar.ImageTransparentColor = Color.Magenta;
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(104, 29);
            btnAtualizar.Text = "Atualizar";
            // 
            // btnScript
            // 
            btnScript.Font = new Font("Segoe UI", 10.8F);
            btnScript.Image = (Image)resources.GetObject("btnScript.Image");
            btnScript.ImageTransparentColor = Color.Magenta;
            btnScript.Name = "btnScript";
            btnScript.Size = new Size(215, 29);
            btnScript.Text = "Script de Atendimento";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = SystemColors.HotTrack;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Location = new Point(0, 945);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1968, 105);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1693, 1029);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(toolStrip2);
            Controls.Add(tabControl1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Atendimento";
            WindowState = FormWindowState.Maximized;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ToolStrip toolStrip1;
        private ToolStripButton btnRegistrar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripButton btnLimpar;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStrip toolStrip2;
        private ToolStripButton btnAtualizar;
        private ToolStripButton btnScript;
        private Label lblNome;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblObs;
        private TextBox txtEmail;
        private RichTextBox rtxtObs;
        private TableLayoutPanel tableLayoutPanel2;
        private MaskedTextBox mtxtTelefone2;
        private TextBox txtNome;
        private MaskedTextBox mtxtTelefone1;
        private ListView lvRegistrados;
        private TableLayoutPanel tableLayoutPanel3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}
