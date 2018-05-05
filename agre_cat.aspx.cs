using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Drawing;
using System.Web.UI.WebControls;

public partial class agre_cat : System.Web.UI.Page
{
    Consultassql datos = new Consultassql();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {

        }
    }
   
    //image 5
    protected void btnconfirmar5_Click(object sender, EventArgs e)
    {
        try
        {
            //HttpCookie idproduct = Request.Cookies["idpaciente"];
            string namefile = file5.FileName.ToLower();
            //string newfile = idproduct.Value + "-primaryphoto.jpg";
            string newfile = /*idproduct.Value + "-" +*/ namefile;
            string fileresize1 = "300x300-" + newfile;
            Random rnd = new Random();
            int nume = rnd.Next(1, 1000000);
            file5.SaveAs(MapPath("./images/temp/" + nume.ToString() + "categoria.jpg"));
            //UpdatePanel1.Update();

            images.ResizeImage(MapPath("./images/temp/" + nume.ToString() + "categoria.jpg").ToString(), MapPath("./images/imgcat/" + nume.ToString() + "categoria.jpg").ToString(), 300, 300);
            fileod3.ImageUrl = "./images/imgcat/" + nume.ToString() + "categoria.jpg";

            lblsubido5.Text = "Foto subida";
        }
        catch (Exception ex)
        {
            lblsubido5.Text = "Hubo un  error al subir, la foto debe ser en formato JPG.";
        }
    }
    protected void btnlimpiar5_Click(object sender, EventArgs e)
    {
        try
        {
            fileod3.ImageUrl = "";
            lblsubido5.Text = "";
        }
        catch (Exception ex)
        {

        }
    }
    protected void btnagregar_Click(object sender, EventArgs e)
    {
        datos.enviardatos("insert into tcategorias (nombrecategoria, img) values('" + txtcate.Text + "','" + fileod3.ImageUrl + "')");
        limpiar();
    }
    private void limpiar()
    {
        txtcate.Text = "";
        fileod3.ImageUrl = "";
    }
}