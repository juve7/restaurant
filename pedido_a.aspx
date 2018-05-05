<%@ Page Title="" Language="C#" MasterPageFile="~/principal.master" AutoEventWireup="true" CodeFile="pedido_a.aspx.cs" Inherits="pedido_a" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-xs-12 col-md-12">
                <!-- Slider one -->

                <div class="box-body">
                    <div class="row">
                        <div class="col-xs-12 col-md-12">
                            <div class="col-xs-6 col-md-6" style="padding-bottom: 20px">
                                <table>
                                    <tr>
                                        <td colspan="2">
                                            <img src="tablet/tablet/lomo-saltado-tipico-peruano.jpg" height="50%" width="50%" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label1" Style="font-size: 22px" runat="server" Text="CANTIDAD"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtcant" Style="font-size: 22px" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label2" Style="font-size: 22px" runat="server" Text="SUBTOTAL"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtsub" Style="font-size: 22px" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label3" Style="font-size: 22px" runat="server" Text="TOTAL"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txttot" Style="font-size: 22px" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:Button ID="Button1" runat="server" class="btn btn-info" Style="width: 130px; height: 60px; font-size: 20px" Text="FINALIZAR" />
                                            <asp:Button ID="Button2" runat="server" class="btn btn-info" Style="width: 130px; height: 60px; font-size: 20px" Text="AGREGAR" />
                                            <asp:Button ID="Button3" runat="server" class="btn btn-danger" Style="width: 130px; height: 60px; font-size: 20px" Text="CERRAR" OnClick="Button3_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <div class="col-xs-6 col-md-6" style="padding-bottom: 20px">
                                <table>
                                    <tr>
                                        <td>
                                            <a onclick="x1();" id="n1" runat="server" class="btn btn-danger" style="width: 110px; height: 110px; font-size: 70px">1</a>


                                        </td>
                                        <td>
                                            <a onclick="x2();" class="btn btn-danger" style="width: 110px; height: 110px; font-size: 70px">2</a>
                                        </td>
                                        <td>
                                            <a onclick="x3();" class="btn btn-danger" style="width: 110px; height: 110px; font-size: 70px">3</a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <a onclick="x4();" class="btn btn-danger" style="width: 110px; height: 110px; font-size: 70px">4</a>
                                        </td>
                                        <td>
                                            <a onclick="x5();" class="btn btn-danger" style="width: 110px; height: 110px; font-size: 70px">5</a>
                                        </td>
                                        <td>
                                            <a onclick="x6();" class="btn btn-danger" style="width: 110px; height: 110px; font-size: 70px">6</a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <a onclick="x7();" class="btn btn-danger" style="width: 110px; height: 110px; font-size: 70px">7</a>
                                        </td>
                                        <td>
                                            <a onclick="x8();" class="btn btn-danger" style="width: 110px; height: 110px; font-size: 70px">8</a>
                                        </td>
                                        <td>
                                            <a onclick="x9();" class="btn btn-danger" style="width: 110px; height: 110px; font-size: 70px">9</a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <a onclick="xc();" class="btn btn-danger" style="width: 110px; height: 110px; font-size: 70px">C</a>
                                        </td>
                                        <td>
                                            <a onclick="x0();" class="btn btn-danger" style="width: 110px; height: 110px; font-size: 70px">0</a>
                                        </td>
                                        <td>
                                            <a onclick="xm();" id="nm" runat="server" class="btn btn-danger" style="width: 110px; height: 110px; font-size: 70px"><<</a>
                                        </td>
                                    </tr>
                                </table>
                            </div>

                        </div>

                    </div>
                </div>
            </div>

        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" runat="Server">
    <script>
        function x1() {
            var v = document.getElementById('<%=txtcant.ClientID%>').value;
            var a = document.getElementById('<%=txtcant.ClientID%>');
            if(v=="0" || v=="")
            {
                a.value="1"
            }
            else
            {
                a.value=v+"1"
            }
        }
        function x2() {
            var v = document.getElementById('<%=txtcant.ClientID%>').value;
            var a = document.getElementById('<%=txtcant.ClientID%>');
            if(v=="0" || v=="")
            {
                a.value="2"
            }
            else
            {
                a.value=v+"2"
            }
        }
        function x3() {
            var v = document.getElementById('<%=txtcant.ClientID%>').value;
            var a = document.getElementById('<%=txtcant.ClientID%>');
            if(v=="0" || v=="")
            {
                a.value="3"
            }
            else
            {
                a.value=v+"3"
            }
        }
        function x4() {
            var v = document.getElementById('<%=txtcant.ClientID%>').value;
            var a = document.getElementById('<%=txtcant.ClientID%>');
            if(v=="0" || v=="")
            {
                a.value="4"
            }
            else
            {
                a.value=v+"4"
            }
        }
        function x5() {
            var v = document.getElementById('<%=txtcant.ClientID%>').value;
            var a = document.getElementById('<%=txtcant.ClientID%>');
            if(v=="0" || v=="")
            {
                a.value="5"
            }
            else
            {
                a.value=v+"5"
            }
        }
        function x6() {
            var v = document.getElementById('<%=txtcant.ClientID%>').value;
            var a = document.getElementById('<%=txtcant.ClientID%>');
            if(v=="0" || v=="")
            {
                a.value="6"
            }
            else
            {
                a.value=v+"6"
            }
        }
        function x7() {
            var v = document.getElementById('<%=txtcant.ClientID%>').value;
            var a = document.getElementById('<%=txtcant.ClientID%>');
            if(v=="0" || v=="")
            {
                a.value="7"
            }
            else
            {
                a.value=v+"7"
            }
        }
        function x8() {
            var v = document.getElementById('<%=txtcant.ClientID%>').value;
            var a = document.getElementById('<%=txtcant.ClientID%>');
            if(v=="0" || v=="")
            {
                a.value="8"
            }
            else
            {
                a.value=v+"8"
            }
        }
        function x9() {
            var v = document.getElementById('<%=txtcant.ClientID%>').value;
            var a = document.getElementById('<%=txtcant.ClientID%>');
            if(v=="0" || v=="")
            {
                a.value="9"
            }
            else
            {
                a.value=v+"9"
            }
        }
        function x0() {
            var v = document.getElementById('<%=txtcant.ClientID%>').value;
            var a = document.getElementById('<%=txtcant.ClientID%>');
            if(v=="0" || v=="")
            {
                a.value="0"
            }
            else
            {
                a.value=v+"0"
            }
        }
        function xc() {            
            var a = document.getElementById('<%=txtcant.ClientID%>');          
                a.value="0"          
        }
        function xm() {
            var v = document.getElementById('<%=txtcant.ClientID%>').value;
            var a = document.getElementById('<%=txtcant.ClientID%>');
            var x;
            x = parseInt(v.length) - parseInt(1)
            
            if(v=="0" || v=="")
            {
                a.value="0"
            }
            else
            {
                if (x == 0)
                {
                    a.value = "0"
                }
                else
                {
                    a.value = v.substring(0, x)
                }                
            }
        }
    </script>
</asp:Content>

