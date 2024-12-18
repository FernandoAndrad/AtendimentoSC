using AtendimentoSpyCar.Properties;
using System.Text.RegularExpressions;
using System.Windows.Forms;
//Teste GITHUB
namespace AtendimentoSpyCar
{
    public partial class Form1 : Form
    {
        private List<ListViewItem> allItems = new List<ListViewItem>();
        private ErrorProvider errorProvider = new ErrorProvider();
        public Form1()
        {
            InitializeComponent();
            PreCarregar();
            //Desabilitando de maneira provisiória, botões ainda não estão prontos
            btnScript.Enabled = false;
            btnAtualizar.Enabled = false;
        }

        //Método para limpar todos os campos de texto
        public void LimparCampos()
        {
            txtNome.Clear();
            mtxtTelefone1.Clear();
            mtxtTelefone2.Clear();
            txtEmail.Clear();
            rtxtObs.Clear();
        }

        //Método para carregar dados no ListView para testar o programa
        private void PreCarregar()
        {
            var dadosTeste = new[]
            {
        new { Nome = "Fernando", Telefone = "(11) 98280-5615", Telefone2 = "(11) 95167-1530", Email = "fer.andrad3@gmail.com", Observacoes = "Teste 1" },
        new { Nome = "Ana", Telefone = "(31) 98877-1122", Telefone2 = "(31) 99999-1111", Email = "ana@exemplo.com", Observacoes = "Teste 2" },
        new { Nome = "Juliana", Telefone = "(91) 92211-2233", Telefone2 = "(91) 99999-6666", Email = "juliana@exemplo.com", Observacoes = "Teste 3" },
        new { Nome = "Lucas", Telefone = "(11) 91100-4455", Telefone2 = "(11) 99999-7777", Email = "lucas@exemplo.com", Observacoes = "Teste 4" },
        new { Nome = "Ricardo", Telefone = "(71) 94433-9900", Telefone2 = "(71) 99999-0000", Email = "ricardo@exemplo.com", Observacoes = "Teste 5" },
        new { Nome = "Paula", Telefone = "(61) 95544-7788", Telefone2 = "(61) 99999-9999", Email = "paula@exemplo.com", Observacoes = "Teste 6" },
        new { Nome = "José", Telefone = "(51) 96655-5566", Telefone2 = "(51) 99999-5555", Email = "jose@exemplo.com", Observacoes = "Teste 7" },
        new { Nome = "Mariana", Telefone = "(41) 97766-3344", Telefone2 = "(41) 99999-8888", Email = "mariana@exemplo.com", Observacoes = "Teste 8" },
        new { Nome = "Carlos", Telefone = "(21) 99330-4412", Telefone2 = "(21) 99999-3333", Email = "carlos@exemplo.com", Observacoes = "Teste 9" },
        new { Nome = "Bianca", Telefone = "(81) 93322-0011", Telefone2 = "(81) 99999-2222", Email = "bianca@exemplo.com", Observacoes = "Teste 10" }
        }; 
            foreach (var dado in dadosTeste)
            {
                var item = new ListViewItem(new[] { dado.Nome, dado.Telefone, dado.Telefone2, dado.Email, dado.Observacoes });
                lvRegistrados.Items.Add(item);
            }
    }          

        //Ao clicar no botão Registrar Ligação
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            var telefone = mtxtTelefone1.Text;
            var telefone2 = mtxtTelefone2.Text;
            var email = txtEmail.Text;
            var observacoes = rtxtObs.Text;

            bool isNomeValid = !string.IsNullOrWhiteSpace(nome);
            bool isTelefoneValid = mtxtTelefone1.MaskFull || mtxtTelefone1.Text.Count(char.IsDigit) >= 10;
            bool isTelefone2Valid = string.IsNullOrWhiteSpace(telefone2) || mtxtTelefone2.MaskFull || mtxtTelefone2.Text.Count(char.IsDigit) >= 10;

            // Limpa os erros anteriores
            errorProvider.Clear();

            // Verifica se os campos obrigatórios estão preenchidos
            if (!isNomeValid)
            {
                errorProvider.SetError(txtNome, "O campo Nome é obrigatório.");
            }
            if (!isTelefoneValid)
            {
                errorProvider.SetError(mtxtTelefone1, "Preencher um telefone válido é obrigatório.");
            }

            // Se os campos obrigatórios forem válidos, prosseguir com o registro
            if (isNomeValid && isTelefoneValid)
            {
                // Valida e-mail caso o campo for preenchido
                if (!string.IsNullOrEmpty(email) && !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Por favor, insira um e-mail válido.");
                    return;
                }

                // Adiciona os dados ao ListView
                var newItem = new ListViewItem(new[] { nome, telefone, telefone2, email, observacoes });
                lvRegistrados.Items.Insert(0, newItem); // Adiciona o item no início do ListView

                // Chama o método de limpar todos os campos
                LimparCampos();

                MessageBox.Show("Registro adicionado com sucesso!");
            }
        }

        //Ao clicar no botão "Editar"
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (lvRegistrados.SelectedItems.Count > 0)
            {
                var result = MessageBox.Show("Você tem certeza que deseja editar este item?", "Confirmar Edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var nome = txtNome.Text;
                    var telefone = mtxtTelefone1.Text;
                    var telefone2 = mtxtTelefone2.Text; // Novo campo
                    var email = txtEmail.Text;
                    var observacoes = rtxtObs.Text;

                    bool isNomeValid = !string.IsNullOrWhiteSpace(nome);
                    bool isTelefoneValid = mtxtTelefone1.MaskFull || mtxtTelefone1.Text.Count(char.IsDigit) >= 10;
                    bool isTelefone2Valid = string.IsNullOrWhiteSpace(telefone2) || mtxtTelefone2.MaskFull || mtxtTelefone2.Text.Count(char.IsDigit) >= 10;

                    // Obtem o item selecionado para capturar os dados
                    ListViewItem item = lvRegistrados.SelectedItems[0];

                    if (isNomeValid && (isTelefoneValid || isTelefone2Valid))
                    {
                        if (!string.IsNullOrWhiteSpace(nome) && (isTelefoneValid || isTelefone2Valid))
                        {
                            // Validar e-mail caso o campo for preenchido
                            if (string.IsNullOrWhiteSpace(email) || Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                            {
                                // Atualiza os subitens do ListView
                                item.SubItems[0].Text = nome;
                                item.SubItems[1].Text = telefone;
                                item.SubItems[2].Text = telefone2; // Atualiza o campo telefone2
                                item.SubItems[3].Text = email;
                                item.SubItems[4].Text = observacoes;

                                MessageBox.Show("Interessado editado com sucesso", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Chama o método de limpar todos os campos
                                LimparCampos();
                            }
                            else
                            {
                                MessageBox.Show("Por favor, insira um e-mail válido.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Preencha os dados corretamente para editar!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um item para editar.");
            }
        }

        //Ao clicar no botão "Excluir"
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lvRegistrados.SelectedItems.Count > 0)
            {
                var result = MessageBox.Show("Você tem certeza que deseja excluir este item?", "Confirmar Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var itemToRemove = lvRegistrados.SelectedItems[0];
                    lvRegistrados.Items.Remove(itemToRemove);
                    allItems.Remove(itemToRemove); // Remove o item da lista de todos os itens

                    // Chama o método de limpar todos os carmpos
                    LimparCampos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione registro para excluir.");
            }
        }

        //Ao clicar no botão "Limpar"
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Chama o método de limpar todos os carmpos
            LimparCampos();
        }

        // Ao clicar em um item, carrega os dados do ListView
        private void lvRegistrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRegistrados.SelectedItems.Count > 0)
            {
                //Obtem o item selecionado para capturar os dados
                var selectedItem = lvRegistrados.SelectedItems[0];

                // Preenche as TextBox com os dados do item selecionado
                txtNome.Text = selectedItem.SubItems[0].Text;
                mtxtTelefone1.Text = selectedItem.SubItems[1].Text;
                mtxtTelefone2.Text = selectedItem.SubItems[2].Text;
                txtEmail.Text = selectedItem.SubItems[3].Text;
                rtxtObs.Text = selectedItem.SubItems[4].Text;
            }

            // Verifica quantos itens estão selecionados
            if (lvRegistrados.SelectedItems.Count > 1)
            {
                // Desabilita os botões se mais de um item estiver selecionado
                btnRegistrar.Enabled = false;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            else
            {
                // Habilita os botões se um ou nenhum item estiver selecionado
                btnRegistrar.Enabled = true;
                btnEditar.Enabled = lvRegistrados.SelectedItems.Count > 0;
                btnExcluir.Enabled = lvRegistrados.SelectedItems.Count > 0;
            }
        }
    }
}
 
