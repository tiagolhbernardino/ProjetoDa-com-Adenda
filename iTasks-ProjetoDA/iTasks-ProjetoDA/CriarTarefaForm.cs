using iTasks_ProjetoDA.Enums;
using iTasks_ProjetoDA.Models;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace iTasks_ProjetoDA
{
    public partial class CriarTarefaForm : Form
    {
        private readonly Utilizador utilizadorAtual;
        private readonly Tarefa _tarefaExistente;
        private readonly bool _isReadOnly;

        public CriarTarefaForm(Utilizador utilizadorAtual)
        {
            InitializeComponent();
            this.utilizadorAtual = utilizadorAtual;
            _isReadOnly = false;

            CarregarListaProgramadores();
            CarregarListaTiposTarefa();
            CarregarListaProjetos();
            cBEstado.DataSource = Enum.GetValues(typeof(EstadoAtual));
        }


        public CriarTarefaForm(Utilizador utilizadorAtual, Tarefa tarefa , bool isReadOnly) : this(utilizadorAtual)
        {
            _tarefaExistente = tarefa;
            _isReadOnly = isReadOnly;
            PreencherCampos(_tarefaExistente);

            btnCriar.Visible = false;                         // ← alterado
            btnAtualizar.Visible = true;                          // ← alterado
            btnAtualizar.Enabled = utilizadorAtual is Gestor;     // ← alterado

            if (_isReadOnly)
            {
                AjustarModo();
                btnAtualizar.Visible = false;                     // ← alterado
            }


        }

        private void CarregarListaProjetos()
        {
            using (var db = new iTasksContext())
            {
                cBProjeto.DataSource = db.Projetos.ToList();
                cBProjeto.DisplayMember = "Descricao";
                cBProjeto.ValueMember = "Id";
            }
        }
        public void PreencherCampos(Tarefa t)
        {
            if (t == null) return;

            // ID
            tBId.Text = t.Id.ToString();

            // Datas reais
            tBDataRealInicio.Text = t.DataInicio.HasValue
                ? t.DataInicio.Value.ToString("g")
                : "";
            tBDataRealFim.Text = t.DataFim.HasValue
                ? t.DataFim.Value.ToString("g")
                : "";

            // Data de criação
            tBDataDeCriacao.Text = t.DataCriacao.ToString("g");

            // Descrição, ordem, story points, previsões e estado
            tBDescricao.Text = t.Descricao;
            tBOrdem.Text = t.OrdemExecucao.ToString();
            tBStoryPoints.Text = t.StoryPoints.ToString();
            dPInicio.Value = t.DataPrevistaInicio;
            dPFim.Value = t.DataPrevistaFim;
            cBEstado.SelectedItem = t.EstadoAtual;

            // Seleção de Programador e Projeto por Value
            cBProgramador.SelectedValue = t.ProgramadorId;
            cBTipoTarefa.SelectedValue = t.TipoTarefaId;
            cBProjeto.SelectedValue = t.ProjetoId;
        }


        public void AjustarModo()
        {
            tBDescricao.ReadOnly = true;
            cBProgramador.Enabled = false;
            cBTipoTarefa.Enabled = false;
            tBOrdem.ReadOnly = true;
            tBStoryPoints.ReadOnly = true;
            dPInicio.Enabled = false;
            dPFim.Enabled = false;
            cBEstado.Enabled = false;

            btnCriar.Visible = false;
            btnFechar.Text = "Fechar";
        }

        private void CarregarListaProgramadores()
        {
            using (var db = new iTasksContext())
            {
                var programadores = db.Utilizadors.OfType<Programador>().Where(p => p.IdGestor == utilizadorAtual.Id).ToList();
                cBProgramador.DataSource = programadores;
                cBProgramador.DisplayMember = "Username";
                cBProgramador.ValueMember = "Id";
            }
        }

        private void CarregarListaTiposTarefa()
        {
            using (var db = new iTasksContext())
            {
                var tiposTarefa = db.TiposTarefa.ToList();
                cBTipoTarefa.DataSource = tiposTarefa;
                cBTipoTarefa.DisplayMember = "Nome";    // mostra o Nome em vez de uma propriedade inválida
                cBTipoTarefa.ValueMember = "Id";
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (!(utilizadorAtual is Gestor gestor))
            {
                MessageBox.Show("Apenas gestores podem criar tarefas.");
                return;
            }

            // Validações de campos
            string descricao = tBDescricao.Text.Trim();
            if (string.IsNullOrEmpty(descricao))
            {
                MessageBox.Show("Preencha a descrição.");
                tBDescricao.Focus();
                return;
            }

            if (!(cBProgramador.SelectedItem is Programador programador))
            {
                MessageBox.Show("Selecione um programador.");
                cBProgramador.Focus();
                return;
            }

            if (!(cBTipoTarefa.SelectedItem is TipoTarefa tipoTarefa))
            {
                MessageBox.Show("Selecione um tipo de tarefa.");
                cBTipoTarefa.Focus();
                return;
            }

            if (!(cBProjeto.SelectedItem is Projeto projeto)) 
            {
                MessageBox.Show("É necessario selecionar um projeto");
                cBProjeto.Focus();
                return;
            }

            if (!int.TryParse(tBOrdem.Text.Trim(), out int ordem) || ordem <= 0)
            {
                MessageBox.Show("Ordem de execução inválida (maior que zero).");
                tBOrdem.Focus();
                return;
            }

            if (!int.TryParse(tBStoryPoints.Text.Trim(), out int storyPoints) || storyPoints < 0)
            {
                MessageBox.Show("Story Points inválidos (zero ou positivo).");
                tBStoryPoints.Focus();
                return;
            }

            DateTime dataInicioPrevista = dPInicio.Value.Date;
            DateTime dataFimPrevista = dPFim.Value.Date;
            if (dataFimPrevista < dataInicioPrevista)
            {
                MessageBox.Show("Data final não pode ser anterior à inicial.");
                dPFim.Focus();
                return;
            }

            var estadoAtual = (EstadoAtual)cBEstado.SelectedItem;


            using (var db = new iTasksContext())
            {
                bool ordemExistente = db.Tarefas.Any(t => t. ProgramadorId== programador.Id && t.OrdemExecucao == ordem);
                if (ordemExistente)
                {
                    MessageBox.Show("Já existe uma tarefa com esta ordem para este programador.");
                    return;
                }
            }

            // Criar objeto Tarefa usando construtor vazio + inicializador
            var novaTarefa = new Tarefa
            {
                
                IdGestor = gestor.Id,
                ProgramadorId = programador.Id,
                Descricao = descricao,
                OrdemExecucao = ordem,
                StoryPoints = storyPoints,
                DataPrevistaInicio = dataInicioPrevista,
                DataPrevistaFim = dataFimPrevista,
                DataCriacao = DateTime.Now,
                TipoTarefaId = tipoTarefa.Id,
                EstadoAtual = estadoAtual,
                ProjetoId = projeto.Id
            };

            // Salvar no banco
            using (var db = new iTasksContext())
            {


                db.Tarefas.Add(novaTarefa);
                db.SaveChanges();
            }

            MessageBox.Show("Tarefa criada com sucesso.");
            DialogResult = DialogResult.OK;
            Close();
        }   



        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (_tarefaExistente == null) return;

            // 2) Só gestores podem atualizar
            if (!(utilizadorAtual is Gestor gestor))
            {
                MessageBox.Show("Apenas gestores podem atualizar tarefas.");
                return;
            }

            // 3) Validações de campos
            string descricao = tBDescricao.Text.Trim();
            if (string.IsNullOrEmpty(descricao))
            {
                MessageBox.Show("Preencha a descrição.");
                tBDescricao.Focus();
                return;
            }

            if (!(cBProgramador.SelectedItem is Programador programador))
            {
                MessageBox.Show("Selecione um programador.");
                cBProgramador.Focus();
                return;
            }

            if (!(cBTipoTarefa.SelectedItem is TipoTarefa tipoTarefa))
            {
                MessageBox.Show("Selecione um tipo de tarefa.");
                cBTipoTarefa.Focus();
                return;
            }

            if (!(cBProjeto.SelectedItem is Projeto projeto))
            {
                MessageBox.Show("Selecione um projeto.");
                cBProjeto.Focus();
                return;
            }

            if (!int.TryParse(tBOrdem.Text.Trim(), out int ordem) || ordem <= 0)
            {
                MessageBox.Show("Ordem de execução inválida (maior que zero).");
                tBOrdem.Focus();
                return;
            }

            if (!int.TryParse(tBStoryPoints.Text.Trim(), out int storyPoints) || storyPoints < 0)
            {
                MessageBox.Show("Story Points inválidos (zero ou positivo).");
                tBStoryPoints.Focus();
                return;
            }

            DateTime dtInicioPrev = dPInicio.Value.Date;
            DateTime dtFimPrev = dPFim.Value.Date;
            if (dtFimPrev < dtInicioPrev)
            {
                MessageBox.Show("Data final não pode ser anterior à inicial.");
                dPFim.Focus();
                return;
            }

            var estadoAtual = (EstadoAtual)cBEstado.SelectedItem;

            using (var db = new iTasksContext())
            {
                // 4) Garante ordem única entre outras tarefas do mesmo programador
                bool ordemDuplicada = db.Tarefas.Any(t =>
                    t.ProgramadorId == programador.Id &&
                    t.OrdemExecucao == ordem &&
                    t.Id != _tarefaExistente.Id);
                if (ordemDuplicada)
                {
                    MessageBox.Show("Já existe outra tarefa com esta ordem para este programador.");
                    return;
                }

                // 5) Garante descrição única
                bool descricaoDuplicada = db.Tarefas.Any(t =>
                    t.Descricao == descricao &&
                    t.Id != _tarefaExistente.Id);
                if (descricaoDuplicada)
                {
                    MessageBox.Show("Já existe outra tarefa com esta descrição.");
                    return;
                }

                // 6) (ID não muda, mas garantimos não colidir)
                //   já por default não vais alterar o Id em edição

                // 7) Finalmente faz o attach e atualiza
                db.Tarefas.Attach(_tarefaExistente);
                _tarefaExistente.Descricao = descricao;
                _tarefaExistente.ProgramadorId = programador.Id;
                _tarefaExistente.TipoTarefaId = tipoTarefa.Id;
                _tarefaExistente.OrdemExecucao = ordem;
                _tarefaExistente.StoryPoints = storyPoints;
                _tarefaExistente.DataPrevistaInicio = dtInicioPrev;
                _tarefaExistente.DataPrevistaFim = dtFimPrev;
                _tarefaExistente.EstadoAtual = estadoAtual;
                _tarefaExistente.ProjetoId = projeto.Id;

                db.SaveChanges();
            }

            MessageBox.Show("Tarefa atualizada com sucesso.");
            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
