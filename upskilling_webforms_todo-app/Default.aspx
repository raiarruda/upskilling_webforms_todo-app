<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="upskilling_webforms_todo_app._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid" style="margin-top: 50px;">

        <div class="row panel panel-default">
            <div class="panel-body">
                <div class="form-horizontal">
                    <div class="form-group">
                        <label for="inputTarefa">Título:</label>

                        <input type="text" class="form-control" runat="server" id="inputTarefa" placeholder="Digite sua tarefa">
                    </div>
                    <div class="form-group">
                        <label for="DropDownPriopridade">Prioridade:</label>
                        <asp:DropDownList CssClass="form-control " ID="DropDownPriopridade" runat="server">
                            <asp:ListItem>Baixa</asp:ListItem>
                            <asp:ListItem>Media</asp:ListItem>
                            <asp:ListItem>Alta</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="inputUsuario">Usuário:</label>

                        <input type="text" class="form-control" runat="server" id="inputUsuario" placeholder="Digite o usuario">
                    </div>
                    <div class="form-group">
                        <asp:Button class="btn btn-primary" runat="server" Text="Add!" OnClick="addTarefa" />

                    </div>
                </div>
            </div>
        </div>

        <div class="todo-container">

            <div class="tarefa h3">TAREFA</div>
            <div class="prioridade h3">PRIORIDADE</div>
            <div class="usuario h3">USUARIO</div>
            <div class="acoes h3 ">AÇÕES</div>
        </div>
        <asp:Repeater ID="rptTarefas" runat="server" OnItemDataBound="rptUsuarios_ItemDataBound">
            <ItemTemplate>
                <div class="todo-container" runat="server">

                    <div class="tarefa"><%# Eval("Titulo") %></div>

                    <div class="prioridade ">
                        <%# Eval("LabelPrioridade") %>
                    </div>
                    <div class="usuario">
        
                        <div class="media-left">

                            <asp:Image runat="server" ID="imgAvatar" CssClass="media-object img-circle" />

                        </div>
                    </div>
                    <div class="acoes">
                        <span class="glyphicon glyphicon-ok text-success" aria-hidden="true">ok</span>
                        <span class="glyphicon glyphicon-trash text-danger" aria-hidden="true">x</span>

                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>


    </div>

</asp:Content>
