using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class mesas : System.Web.UI.Page
{
    Consultassql datos = new Consultassql();
    protected void Page_Load(object sender, EventArgs e)
    {
        cargarmesas();
    }
    protected void cargarmesas()
    {
        int ambientes;
        DataTable dt = new DataTable();

        ambientes = int.Parse(datos.extraedatos("select count(*) from tambiente").Rows[0][0].ToString());


        if (ambientes > 1)
        {
            System.Web.UI.HtmlControls.HtmlGenericControl div10;
            System.Web.UI.HtmlControls.HtmlGenericControl div11;
            System.Web.UI.HtmlControls.HtmlGenericControl h310;


            System.Web.UI.HtmlControls.HtmlGenericControl div1;
            System.Web.UI.HtmlControls.HtmlGenericControl div2;
            System.Web.UI.HtmlControls.HtmlGenericControl div3;
            System.Web.UI.HtmlControls.HtmlGenericControl i;
            System.Web.UI.HtmlControls.HtmlGenericControl div4;
            System.Web.UI.HtmlControls.HtmlGenericControl h3;
            System.Web.UI.HtmlControls.HtmlGenericControl p;

            LinkButton lb;
            dt = datos.extraedatos("select idambiente,nombreambiente from tambiente");

            foreach (DataRow dtRow in dt.Rows)
            {
                div10 = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                div11 = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                h310 = new System.Web.UI.HtmlControls.HtmlGenericControl("h1");


                div10.Attributes.Add("class", "row");
                div11.Attributes.Add("class", "x_title");
                h310.Attributes.Add("style", "text-align:center;");
                h310.InnerText = dtRow[1].ToString();

                div11.Controls.Add(h310);
                div10.Controls.Add(div11);


                DataTable dt1 = new DataTable();
                  
                dt1 = datos.extraedatos("select mesa,estado,pedidos from tmesas where idambiente=" + dtRow[0].ToString());

                foreach (DataRow dtrow1 in dt1.Rows)
                {
                    lb = new LinkButton();

                    div1 = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                    div2 = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                    div3 = new System.Web.UI.HtmlControls.HtmlGenericControl("div");

                    i = new System.Web.UI.HtmlControls.HtmlGenericControl("i");
                    div4 = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                    h3 = new System.Web.UI.HtmlControls.HtmlGenericControl("h3");
                    p = new System.Web.UI.HtmlControls.HtmlGenericControl("p");

                    div1.Attributes.Add("class", "animated flipInY col-lg-2 col-md-4 col-sm-6 col-xs-12");

                    if (dtrow1[1].ToString().Equals("Disponible"))
                    {
                        div2.Attributes.Add("class", "tile-stats disponible");
                        h3.InnerText = "Disponible";

                    }
                    else
                    {
                        if (dtrow1[1].ToString().Equals("Enviado a Cocina"))
                        {
                            div2.Attributes.Add("class", "tile-stats ocupado");
                            h3.InnerText = "Enviado a Cocina";
                        }
                        else
                        {
                            if (dtrow1[1].ToString().Equals("Atendido"))
                            {
                                div2.Attributes.Add("class", "tile-stats atendido");
                                h3.InnerText = "Atendido";
                            }
                        }
                    }





                    div3.Attributes.Add("class", "col-md-10 icon");
                    div3.Attributes.Add("style", "color:white;");


                    div4.Attributes.Add("class", "count center-margin");
                    div4.InnerText = "Mesa " + dtrow1[0].ToString();

                    h3.Attributes.Add("style", "color:white;");

                    p.InnerText = dtrow1[2].ToString() + " Pedidos";


                    div3.Controls.Add(i);
                    //segun el orden
                    div2.Controls.Add(div3);
                    div2.Controls.Add(div4);
                    div2.Controls.Add(h3);
                    div2.Controls.Add(p);
                    div1.Controls.Add(div2);



                    lb.Controls.Add(div1);
                    lb.ID = dtrow1[0].ToString();

                    lb.Click += new EventHandler(lt_Click);

                    div10.Controls.Add(lb);

                }
                plcmesas.Controls.Add(div10);
            }
        }
        else
        {
            LinkButton lb;
            dt.Rows.Clear();
            System.Web.UI.HtmlControls.HtmlGenericControl div1;
            System.Web.UI.HtmlControls.HtmlGenericControl div2;
            System.Web.UI.HtmlControls.HtmlGenericControl div3;
            System.Web.UI.HtmlControls.HtmlGenericControl i;
            System.Web.UI.HtmlControls.HtmlGenericControl div4;
            System.Web.UI.HtmlControls.HtmlGenericControl h3;
            System.Web.UI.HtmlControls.HtmlGenericControl p;


            dt = datos.extraedatos("select mesa,estado,pedidos from tmesas order by mesa ASC");
            foreach (DataRow dtRow in dt.Rows)
            {
                lb = new LinkButton();



                div1 = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                div2 = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                div3 = new System.Web.UI.HtmlControls.HtmlGenericControl("div");

                i = new System.Web.UI.HtmlControls.HtmlGenericControl("i");
                div4 = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                h3 = new System.Web.UI.HtmlControls.HtmlGenericControl("h3");
                p = new System.Web.UI.HtmlControls.HtmlGenericControl("p");

                div1.Attributes.Add("class", "animated flipInY col-lg-2 col-md-4 col-sm-6 col-xs-12");

                if (dtRow[1].ToString().Equals("0"))
                {
                    div2.Attributes.Add("class", "tile-stats disponible");
                    h3.InnerText = "Disponible";

                }
                else
                {
                    if (dtRow[1].ToString().Equals("1"))
                    {
                        div2.Attributes.Add("class", "tile-stats ocupado");
                        h3.InnerText = "Ocupado";
                    }
                }
                div3.Attributes.Add("class", "col-md-10 icon");
                div3.Attributes.Add("style", "color:white;");

                i.Attributes.Add("class", "fa fa-angle-double-right");
                i.Attributes.Add("style", "margin-left:20px;");

                div4.Attributes.Add("class", "count center-margin");
                div4.InnerText = "Mesa " + dtRow[0].ToString();

                h3.Attributes.Add("style", "color:white;");

                p.InnerText = dtRow[2].ToString() + " Pedidos";


                div3.Controls.Add(i);
                div2.Controls.Add(div3);
                div2.Controls.Add(div4);
                div2.Controls.Add(h3);
                div2.Controls.Add(p);
                div1.Controls.Add(div2);



                lb.Controls.Add(div1);
                lb.ID = dtRow[0].ToString();
                lb.Click += new EventHandler(lt_Click);
                plcmesas.Controls.Add(lb);
            }
        }
               
       
    }
    protected void lt_Click(object sender, EventArgs e)
    {
        LinkButton bt = (LinkButton)sender;
        Session["mesa"] = bt.ID;
        Response.Redirect("./carta.aspx");

    }
}