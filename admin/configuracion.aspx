<%@ Page Title="" Language="C#" MasterPageFile="admpri.master" AutoEventWireup="true" CodeFile="configuracion.aspx.cs" Inherits="configuracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" Runat="Server">
          
    
                    
    <div class="">
            <div class="page-title">
              <div class="title_left">
                <h3>Configuraciones</h3>
              </div>

              <div class="title_right">
                <div class="col-md-5 col-sm-5 col-xs-12 form-group pull-right top_search">
                  <div class="input-group">
                    <input type="text" class="form-control" placeholder="Search for...">
                    <span class="input-group-btn">
                      <button class="btn btn-default" type="button">Go!</button>
                    </span>
                  </div>
                </div>
              </div>
            </div>
            <div class="clearfix"></div>
           <asp:ScriptManager id="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel id="UpdatePanel1" runat="server">
            <ContentTemplate>
                <fieldset>     

        <div class="row">
              <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="x_panel">
                  <div class="x_title">
                    <h2>Ambientes <small>Indique la cantidad de ambientes y mesas que posee</small></h2>
                    <ul class="nav navbar-right panel_toolbox">
                      <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                      </li>
                 
                    
                    </ul>
                    <div class="clearfix"></div>
                  </div>
                  <div class="x_content">
                    <br>
                    <div id="demo-form2" data-parsley-validate="" class="form-horizontal form-label-left" >

                      <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="first-name">Nombre del Ambiente <span class="required">*</span>
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                            <asp:TextBox type="text" class="form-control col-md-7 col-xs-12"  ID="txtambiente" runat="server"></asp:TextBox>
                        </div>
                      </div>
                        <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="first-name">Cantidad de Mesas <span class="required">*</span>
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                            <asp:TextBox type="number" class="form-control col-md-7 col-xs-12"  ID="txtmesas" runat="server"></asp:TextBox>
                        </div>
                      </div>                     
                        
                     
                        <div class="row">   <div class=" col-lg-6 "></div>

                            <asp:Button ID="btnagregar" CssClass="btn btn-primary" runat="server" Text="Agregar" OnClick="btnagregar_Click" />
                     </div>
                   


                        <div class=" col-lg-3 "></div>
                        <div class="table-responsive col-lg-6 col-md-12 col-xs-12">
                            
                        <asp:GridView ID="dgvmesas" AutoGenerateColumns="false" DataKeyNames="idambiente" CssClass="table table-striped jambo_table bulk_action"  runat="server" OnRowDeleting="dgvmesas_RowDeleting" >
                            <Columns>  
                             
                                <asp:BoundField DataField="ambiente" HeaderText="AMBIENTE" />
                                 <asp:BoundField DataField="mesas" HeaderText="MESAS" />

                                 <asp:TemplateField HeaderText="" ShowHeader="false">

                                    <ItemTemplate>
                                        <asp:LinkButton ID="btneliminar" runat="server" CommandName="Delete" Text="Eliminar" ></asp:LinkButton>
                                    </ItemTemplate>
                    
                                  </asp:TemplateField>


                            </Columns>
                        </asp:GridView>

                    </div>

                    </div>
                  </div>
                </div>
              </div>
            </div>







              <div class="row">
              <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="x_panel">
                  <div class="x_title">
                    <h2>Categorías <small>Indique las categorías que incluye el menú</small></h2>
                    <ul class="nav navbar-right panel_toolbox">
                      <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                      </li>
                    </ul>
                    <div class="clearfix"></div>
                  </div>
                  <div class="x_content">
                    <br>
                    <div id="demo-form2" data-parsley-validate="" class="form-horizontal form-label-left" >

                      <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="first-name">Nombre de la Categoría <span class="required">*</span>
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                            <asp:TextBox type="text"  class="form-control col-md-7 col-xs-12"  ID="txtcategoria" runat="server"></asp:TextBox>
                        </div>
                      </div>
                       
                     
                        <div class="row">   <div class=" col-lg-6 "></div>

                            <asp:Button ID="btnag" CssClass="btn btn-primary" runat="server" Text="Agregar" OnClick="btnag_Click" />
                     </div>
                   


                        <div class=" col-lg-3 "></div>
                        <div class="table-responsive col-lg-6 col-md-12 col-xs-12">
                            
                        <asp:GridView ID="dgvcategoria" AutoGenerateColumns="false" DataKeyNames="idcategoria" CssClass="table table-striped jambo_table bulk_action"  runat="server" OnRowDeleting="dgvcategoria_RowDeleting" >
                            <Columns>  
                             
                                <asp:BoundField DataField="categoria" HeaderText="CATEGORIA" />

                                 <asp:TemplateField HeaderText="" ShowHeader="false">

                                    <ItemTemplate>
                                        <asp:LinkButton ID="btneliminar" runat="server" CommandName="Delete" Text="Eliminar" ></asp:LinkButton>
                                    </ItemTemplate>
                    
                                  </asp:TemplateField>


                            </Columns>
                        </asp:GridView>

                    </div>

                    </div>
                  </div>
                </div>
              </div>
            </div>

        </fieldset>
            </ContentTemplate>
        </asp:UpdatePanel>
                
                 

       
          </div> 

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" Runat="Server">
</asp:Content>

