<%@ Page Title="" Language="C#" MasterPageFile="~/principal.master" AutoEventWireup="true" CodeFile="agre_cat.aspx.cs" Inherits="agre_cat" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" Runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <!-- Slider one -->

                <div class="box-body">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="col-md-6 col-lg-6" style="color: cadetblue">
                                    <div style="clear: both" class="col-md-12">
                                        <h4 align="center"><b>OD</b></h4>
                                    </div>

                                    <div id="Div4" class="row" runat="server">
                                        <div class="col-md-12 size-detail">
                                            <div class="row">
                                                <div class="col-md-12">
                                                    <asp:Image ID="fileod3" CssClass="imageslide" runat="server" Style="width: 250px; height: 250px" />
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col-md-12 contentupload">
                                                    <div class="js">
                                                        <asp:FileUpload ID="file5" name="file-1[]" CssClass="fileinline inputfile inputfile-1" data-multiple-caption="{count} files selected" multiple runat="server" />
                                                        <label for="cuerpo_file5" runat="server">
                                                            <svg xmlns="http://www.w3.org/2000/svg" width="20" height="17" viewBox="0 0 20 17">
                                                                <path d="M10 0l-5.2 4.9h3.3v5.1h3.8v-5.1h3.3l-5.2-4.9zm9.3 11.5l-3.2-2.1h-2l3.4 2.6h-3.5c-.1 0-.2.1-.2.1l-.8 2.3h-6l-.8-2.2c-.1-.1-.1-.2-.2-.2h-3.6l3.4-2.6h-2l-3.2 2.1c-.4.3-.7 1-.6 1.5l.6 3.1c.1.5.7.9 1.2.9h16.3c.6 0 1.1-.4 1.3-.9l.6-3.1c.1-.5-.2-1.2-.7-1.5z" />
                                                            </svg>
                                                            <span>Elegir una fotografía en formato JPG&hellip;</span></label>
                                                    </div>
                                                    <div class="buttons">
                                                        <asp:LinkButton ID="LinkButton5" CssClass="btn btn-info btnstyle fileinline confirm" runat="server" title="Confirm" OnClick="btnconfirmar5_Click"><i class="fa fa-check" aria-hidden="true"></i></asp:LinkButton>
                                                        <asp:LinkButton ID="LinkButton6" CssClass="btn btn-warning btnstyle fileinline clean" runat="server" title="Clean" OnClick="btnlimpiar5_Click"><i class="fa fa-times" aria-hidden="true"></i></asp:LinkButton>
                                                        <asp:Label ID="lblsubido5" class="lbluploaded" runat="server"></asp:Label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>                               

                                    
                                </div>
                            <div class="col-md-6">
                                <asp:TextBox ID="txtcate" runat="server"></asp:TextBox>
                                <asp:Button ID="btnagregar" runat="server" Text="Button" OnClick="btnagregar_Click" />
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

