﻿<%--
        ESTAS MSGS ESTÃO NO TCC I, EM CASO DE MUDANÇA EFETUAR A MESMA NO ARQUIVO DO PROJETO
        Como chegar nesta Tela = Principal/Cadastrar Brat
        Título da Tela = Cadastrar Brat
        Msg de Sucesso = BRAT Cadastrado com Sucesso
        Msg de Cancelamento = Cadastro Cancelado
        Msg de Validação = Verificar Dados Informados 
        
        OBRIGATORIEDADE DE NO MINIMO 2 TESTEMUNHAS              
--%>
<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Brato.Entities.TestemunhaEntity>" %>
<% var lstSexo = Brato.UserInterface.WebUserInterfaceHelper.DropDownListHelper.CarregarDropDown<SexoEnum>();
   var lstEstadoCivil = Brato.UserInterface.WebUserInterfaceHelper.DropDownListHelper.CarregarDropDown<EstadoCivilEnum>(); %>
<div class="formItems">
    <form id="formTestemunha">
    <input type="hidden" name="Brat.IdBrat" class="Brat_IdBrat" />
    <div class="formItem doisquintos">
        <span>*Nome</span>
        <%= Html.TextBoxFor(model => model.Pessoa.Nome, new { size = "60", MaxLength = "50" })%>
    </div>
    <div class="formItem inteiro">
        <div class="formItem oitavo">
            <span>*UF</span>
            <select name="Pessoa.UF.Uf" id="ddlUf" class="ddlUf">
            </select>
        </div>
        <div class="formItem terco">
            <span>*Município</span>
            <select name="Pessoa.Municipio.IdMunicipio" id="ddlMunicipio" class="ddlMunicipio">
                <option value="0" selected="selected">Selecione</option>
            </select>
        </div>
        <div class="formItem doisQuintos">
            <span>*Bairro</span>
            <select name="Pessoa.Bairro.IdBairro" id="ddlBairro" class="ddlBairro">
                <option value="0" selected="selected">Selecione</option>
            </select>
        </div>
    </div>
    <div class="formItem inteiro">
        <div class="formItem tresQuintos">
            <span>*Logradouro</span>
            <select name="Pessoa.Logradouro.IdLogradouro" id="ddlLogradouro" class="ddlLogradouro">
                <option value="0" selected="selected">Selecione</option>
            </select>
        </div>
        <div class="formItem nono">
            <span>Numero</span>
            <%= Html.TextBoxFor(model => model.Pessoa.Numero, new { size = "7", MaxLength = "7" })%>
        </div>
        <div class="formItem tresQuintos">
            <span>Complemento</span>
            <%= Html.TextBoxFor(model => model.Pessoa.Complemento, new { size = "60", MaxLength = "50" })%>
        </div>
    </div>
    <div class="formItem inteiro">
        <div class="formItem quarto">
            <span>*Sexo</span>
            <%= Html.DropDownListFor(model => model.Pessoa.Sexo, lstSexo, "Selecione", null)%>
        </div>
        <div class="formItem quarto">
            <span>CPF</span>
            <%= Html.TextBoxFor(model => model.Pessoa.Cpf, new { size = "20", MaxLength = "11" })%>
        </div>
    </div>
    <br />
    <br style="clear: both;" />
    <div class="clear" id="divGridTestemunha" style="clear: both; margin-top: 5%;">
        <% Html.RenderPartial("GridControl"); %>
    </div>
    <div class="formItem inteiro">
        <a href="#" id="continuarTestemunha" class="ui-state-default ui-corner-all botao"
            style="float: inherit;">Continuar</a>
    </div>
    </form>
</div>
