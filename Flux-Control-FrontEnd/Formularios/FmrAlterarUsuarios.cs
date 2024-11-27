using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FluxControl.Data.Repositories;
using FluxControl.Data.Model;

namespace Flux_Control_prototipo.Formularios
{
    public partial class FmrAlterarUsuarios : Form
    {
        private bool _Incluir = true;
        private Usuario oUsuarioSelecionado = null;
        private UsuarioRepository usuarioRepository = new UsuarioRepository(new DbFluxControlContext());

        public FmrAlterarUsuarios()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool UsuarioExiste(string EmailUsuario)
        {
            try
            {
                List<Usuario> usuarios = usuarioRepository.SelecionarTodos();
                return usuarios.Any(u => u.Email.Equals(EmailUsuario, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar se o usuário existe: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Retorna false em caso de erro
            }
        }

                public bool admin;
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtNome.Text))
                {
                    MessageBox.Show("Por favor, insira o nome do usuário.");
                    return;
                }


                if (_Incluir)
                {
                    if (UsuarioExiste(TxtNome.Text))
                    {
                        MessageBox.Show("Já existe um usuário com esse nome. Por favor, escolha outro nome.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (CheckBoxAdmin.Checked)
                    {
                        bool admin = true;
                    }
                    else
                    {
                        bool admin = false;
                    }
                    Usuario novoUsuario = new Usuario { Nome = TxtNome.Text, Senha = TxtSenha.Text, Email = TxtEmail.Text, Admin = admin };
                    usuarioRepository.Incluir(novoUsuario);
                }
                else
                {
                    oUsuarioSelecionado.Nome = TxtNome.Text;
                    oUsuarioSelecionado.Senha = TxtEmail.Text;
                    oUsuarioSelecionado.Email = TxtSenha.Text;

                    if (CheckBoxAdmin.Checked)
                    {
                       
                        oUsuarioSelecionado.Admin = true;
                    }
                    else
                    {
                        oUsuarioSelecionado.Admin = false;
                    }

                    usuarioRepository.Alterar(oUsuarioSelecionado);

                    _Incluir = true;
                }

                LimparControles();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarGrid()
        {
            try
            {
                GrdUsuarios.AutoGenerateColumns = false;
                GrdUsuarios.Columns.Clear();
                GrdUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Coluna Nome
                DataGridViewTextBoxColumn colNome = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Nome Usuário",
                    DataPropertyName = "Nome"
                };
                GrdUsuarios.Columns.Add(colNome);

                DataGridViewTextBoxColumn colEmail = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Email",
                    DataPropertyName = "Email"
                };
                GrdUsuarios.Columns.Add(colEmail);

                DataGridViewTextBoxColumn colSenha = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Senha",
                    DataPropertyName = "Senha"
                };
                GrdUsuarios.Columns.Add(colSenha);

                DataGridViewTextBoxColumn colAdmin = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Admin",
                    DataPropertyName = "Admin"
                };
                GrdUsuarios.Columns.Add(colAdmin);

                // Coluna Editar
                DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn
                {
                    HeaderText = "Editar",
                    Name = "BtnEditar"
                };
                GrdUsuarios.Columns.Add(colEditar);

                // Coluna Excluir
                DataGridViewButtonColumn colExcluir = new DataGridViewButtonColumn
                {
                    HeaderText = "Excluir",
                    Name = "BtnExcluir"
                };
                GrdUsuarios.Columns.Add(colExcluir);

                // Popula a grid com os dados
                GrdUsuarios.DataSource = usuarioRepository.SelecionarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar a grade de usuários: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparControles()
        {
            TxtNome.Text = "";
            TxtEmail.Text = "";
            oUsuarioSelecionado = null;
        }

        private void GrdUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    Usuario usuarioSelecionado = GrdUsuarios.Rows[e.RowIndex].DataBoundItem as Usuario;

                    if (usuarioSelecionado != null)
                    {
                        // Editar
                        if (GrdUsuarios.Columns[e.ColumnIndex].Name == "BtnEditar")
                        {
                            TxtNome.Text = usuarioSelecionado.Nome;
                            TxtEmail.Text = usuarioSelecionado.Senha;
                            TxtSenha.Text = usuarioSelecionado.Senha;

                            if (usuarioSelecionado.Admin == true)
                            {
                                CheckBoxAdmin.Checked = true;
                            }
                            else if (usuarioSelecionado.Admin == false)
                            {
                                CheckBoxAdmin.Checked = false;
                            }

                            oUsuarioSelecionado = usuarioSelecionado;
                            _Incluir = false;
                        }
                        // Excluir
                        else if (GrdUsuarios.Columns[e.ColumnIndex].Name == "BtnExcluir")
                        {
                            if (MessageBox.Show("Deseja realmente excluir este usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                try
                                {
                                    usuarioRepository.Excluir(usuarioSelecionado);
                                    CarregarGrid();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Erro ao processar a exclusão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao processar a ação na grade: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
