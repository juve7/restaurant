<%@ Page Title="" Language="C#" MasterPageFile="~/principal.master" AutoEventWireup="true" CodeFile="pedido.aspx.cs" Inherits="pedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" Runat="Server">
     <div class="container">      
        <div class="row">
            <div class="col-xs-12 col-md-12">
                <!-- Slider one -->            

                    <div class="box-body">
                        <div class="row">
                            <div class="col-xs-12 col-md-12" >

                                <asp:Panel ID="Panel1" runat="server">


                                </asp:Panel>                                
                                <div class="col-xs-4 col-md-4">
                                    <asp:TextBox ID="pru" runat="server"></asp:TextBox>
                                </div>
                            </div>
                          
                        </div>
                    </div>
                </div>
           
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" Runat="Server">
</asp:Content>

