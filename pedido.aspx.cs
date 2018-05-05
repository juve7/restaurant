using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pedido : System.Web.UI.Page
{
    Consultassql datos = new Consultassql();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Request.QueryString["cat"] != null)
            {
                pru.Text = Request.QueryString["cat"].ToString();
            }
            for(int x=1;x<=5;x++)
            {
                genera();
            }
            

        }
    }
    private void genera()
    {
                                //< div class="col-xs-4 col-md-4" style="padding-bottom:20px">
                                //    <a href = "pedido_a.aspx" >< img  src="tablet/tablet/lomo-saltado-tipico-peruano.jpg" height="100%" width="100%"/></a>
                                //</div>                                
        //creando el control
        System.Web.UI.HtmlControls.HtmlGenericControl div;
        //instanciar el control
        div = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
        //diseñando el div por propiedades
        div.Attributes.Add("class", "col-xs-4 col-md-4");
        div.Attributes.Add("style", "padding-bottom:20px");

        System.Web.UI.HtmlControls.HtmlGenericControl a;
        a = new System.Web.UI.HtmlControls.HtmlGenericControl("a");

        a.Attributes.Add("href","pedido_a.aspx?cat="+"1");

        System.Web.UI.HtmlControls.HtmlGenericControl img;
        img = new System.Web.UI.HtmlControls.HtmlGenericControl("img");

        img.Attributes.Add("src", "tablet/tablet/lomo-saltado-tipico-peruano.jpg");
        img.Attributes.Add("height", "100%");
        img.Attributes.Add("width", "100%");
        a.Controls.Add(img);
        div.Controls.Add(a);
        Panel1.Controls.Add(div);
    }
}