using System;

using System.Web.UI;
using System.Web.UI.WebControls;
using upskilling_webforms_todo_app.Modelos;

namespace upskilling_webforms_todo_app
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            rptTarefas.DataSource = Tarefa.ListarTarefas();
            rptTarefas.DataBind();

        }

        protected void addTarefa(object sender, EventArgs e)
        {
            string nomeTarefa = inputTarefa.Value;
            inputTarefa.Value = "";

           Prioridade prioridade = (Prioridade)Enum.Parse(typeof(Prioridade), DropDownPriopridade.SelectedValue);
           DropDownPriopridade.SelectedIndex = 0;

            string usuario = inputUsuario.Value;
            inputUsuario.Value = "";

            Tarefa novaTarefa = new Tarefa(nomeTarefa, prioridade,usuario);
            novaTarefa.AdicionarTarefa();

        }

        protected void rptUsuarios_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var  tarefa = (Tarefa)e.Item.DataItem;
                Image imgAvatar = (Image)e.Item.FindControl("imgAvatar");
                imgAvatar.ImageUrl = tarefa.Usuario.Avatar.Value;
            }
        }



    }
}