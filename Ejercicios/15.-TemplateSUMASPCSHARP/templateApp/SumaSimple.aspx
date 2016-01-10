<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="SumaSimple.aspx.cs" Inherits="templateApp.SumaSimple" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<div class="row">
    <br />
    <div class="col-md-12">
        <div class="box box-success">
                <div class="box-header">
                  <h3 class="box-title">Suma Simple</h3>
                </div>
                <div class="box-body">
                  <label for="exampleInputEmail1">Número 1</label>
                    <asp:TextBox CssClass="form-control input-lg" ID="txtvalor1" runat="server"></asp:TextBox>
                    <br />
                    <label for="exampleInputEmail1">Número 2</label>
&nbsp;<asp:TextBox ID="txtvalor2" CssClass="form-control input-lg" runat="server"></asp:TextBox>
                    <br />
                    <label for="exampleInputEmail1">Resultado</label>
                    <asp:TextBox CssClass="form-control input-lg" ID="txtresultado" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="Button1" CssClass="btn btn-danger" runat="server" Text="Sumar" OnClick="Button1_Click" />
                </div><!-- /.box-body -->
              </div>

    </div>

</div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
