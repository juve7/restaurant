using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class categoria_t : System.Web.UI.Page
{
    Consultassql datos = new Consultassql();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DataTable dt = new DataTable();
            dt = datos.extraedatos("select tprucol from tpru");
          
        }
        cargarcat();
    }
    private void cargarcat()
    {
        DataTable dt = new DataTable();
        dt = datos.extraedatos("select idcategoria, nombrecategoria, img from tcategorias");
        foreach(DataRow dtr in dt.Rows)
        {
            System.Web.UI.HtmlControls.HtmlGenericControl div;
            //instanciar el control
            div = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            //diseñando el div por propiedades
            div.Attributes.Add("class", "col-xs-4 col-md-4");
            div.Attributes.Add("style", "padding-bottom:20px;position: relative;display: inline -block;text - align: center;");
            //div2
            System.Web.UI.HtmlControls.HtmlGenericControl div2;
            div2 = new System.Web.UI.HtmlControls.HtmlGenericControl("div2");
            div2.Attributes.Add("style", "position: absolute;top: 50%;left:50%;transform: translate(-50%, -50%)");

            //texto
            System.Web.UI.HtmlControls.HtmlGenericControl h1;

            h1 = new System.Web.UI.HtmlControls.HtmlGenericControl("h1");  
            h1.Attributes.Add("style", "text-align:center;color:black;font-weight: bold;");
            h1.InnerText = dtr[1].ToString();
            //etiqueta a
            System.Web.UI.HtmlControls.HtmlGenericControl a;
            a = new System.Web.UI.HtmlControls.HtmlGenericControl("a");

            a.Attributes.Add("href", "pedido.aspx?cat=" + dtr[0].ToString());
            //imagen
            System.Web.UI.HtmlControls.HtmlGenericControl img;
            img = new System.Web.UI.HtmlControls.HtmlGenericControl("img");

            img.Attributes.Add("src", dtr[2].ToString());
            img.Attributes.Add("height", "100%");
            img.Attributes.Add("width", "100%");
            //dando atributos segun su orden
            div2.Controls.Add(h1);
            a.Controls.Add(img);
            a.Controls.Add(div2);
            //div.Controls.Add(div2);
            //div.Controls.Add(img);
            div.Controls.Add(a);
            categorias.Controls.Add(div);
        }
    }
    private void genera()
    {
      
        System.Web.UI.HtmlControls.HtmlGenericControl div;
        //instanciar el control
        div = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
        //diseñando el div por propiedades
        div.Attributes.Add("class", "col-xs-4 col-md-4");
        div.Attributes.Add("style", "padding-bottom:20px");

        System.Web.UI.HtmlControls.HtmlGenericControl a;
        a = new System.Web.UI.HtmlControls.HtmlGenericControl("a");

        a.Attributes.Add("href", "pedido.aspx?cat=" + "1");

        System.Web.UI.HtmlControls.HtmlGenericControl img;
        img = new System.Web.UI.HtmlControls.HtmlGenericControl("img");

        img.Attributes.Add("src", "tablet/tablet/lomo-saltado-tipico-peruano.jpg");
        img.Attributes.Add("height", "100%");
        img.Attributes.Add("width", "100%");
        a.Controls.Add(img);
        div.Controls.Add(a);
        categorias.Controls.Add(div);
    }
}