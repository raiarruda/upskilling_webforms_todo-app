using System.Collections.Generic;

namespace upskilling_webforms_todo_app.Modelos
{
    public partial class Tarefa
    {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public Prioridade NivelPrioridade { get; set; }
        public string LabelPrioridade => GetPrioridadeLabel(NivelPrioridade);
        public bool Concluida { get; set; } = false;

        public Usuario Usuario { get; set; }

        private static List<Tarefa> tarefas = new List<Tarefa>();

        public Tarefa(string titulo, Prioridade nivelPrioridade, string usuario)
        {
         
            Titulo = titulo;
            NivelPrioridade = nivelPrioridade;
            Usuario = Usuario.BuscarUsuarioPorNome(usuario);
        }

        public void AdicionarTarefa()
        {
            tarefas.Add(this);
        }

        public static void RemoverTarefa(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);
        }
        public static void ConcluirTarefa(Tarefa tarefa)
        {
            tarefa.Concluida = true;
        }

        public static List<Tarefa> ListarTarefas()
        {
            return tarefas;
        }

        protected static string GetPrioridadeLabel(Prioridade nivelPrioridade)
        {
            string labelClass = "";
            string labelText = "";

            switch (nivelPrioridade)
            {
                case Prioridade.Alta:
                    labelClass = "label-danger";
                    labelText = "Alta";
                    break;

                case Prioridade.Media:
                    labelClass = "label-warning";
                    labelText = "Média";
                    break;

                case Prioridade.Baixa:
                    labelClass = "label-info";
                    labelText = "Baixa";
                    break;
            }

            return string.Format("<span class=\"label {0}\">{1}</span>", labelClass, labelText);
        }

    }
}