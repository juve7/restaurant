using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class configuracion : System.Web.UI.Page
{
    Consultassql datos = new Consultassql();
    protected void Page_Load(object sender, EventArgs e)
    {
        llenarmesas();
        llenarcategorias();
    }
    protected void llenarmesas()
    {
        DataTable dt = new DataTable();
        dt = datos.extraedatos("select ta.idambiente as idambiente,ta.nombreambiente as ambiente,count(*) as mesas from tmesas tm inner join tambiente ta on tm.idambiente=ta.idambiente group by ta.nombreambiente order by ta.idambiente asc");
        dgvmesas.DataSource = dt;
        dgvmesas.DataBind();
    }
    protected void llenarcategorias()
    {
        DataTable dt = new DataTable();
        dt = datos.extraedatos("select idcategoria,nombrecategoria as categoria from tcategorias");
        dgvcategoria.DataSource = dt;
        dgvcategoria.DataBind();

    }
    protected void btnagregar_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        Session["eli"] = null;
        dt=datos.extraedatos("select count(*) from tambiente where nombreambiente='" + txtambiente.Text + "'");

        if (!dt.Rows[0][0].ToString().Equals("0"))
        {
            dt.Rows.Clear();
            dt=datos.extraedatos("select idambiente from tambiente where nombreambiente='" + txtambiente.Text + "'");
            Session["idambiente"] = dt.Rows[0][0].ToString();
        }
        else
        {
            datos.enviardatos("insert into tambiente(nombreambiente) values('" + txtambiente.Text + "')");
            dt.Rows.Clear();
            dt = datos.extraedatos("select max(idambiente) from tambiente");
            Session["idambiente"] = dt.Rows[0][0].ToString();
        }

        recrear();
        llenarmesas();
    }
    protected void recrear()
    {
        if (Session["eli"] == null)
        {
            datos.enviardatos("delete from tmesas where idambiente=" + Session["idambiente"].ToString());
        }
        int a = 0;

        DataTable dt = new DataTable();
        if (dgvmesas.Rows.Count > 0)
        {
            foreach (GridViewRow dgr in dgvmesas.Rows)
            {
                dt = datos.extraedatos("select idambiente from tambiente where nombreambiente='" + dgr.Cells[0].Text + "'");

                if (dt.Rows.Count > 0)
                {
                    datos.enviardatos("delete from tmesas where idambiente=" + dt.Rows[0][0].ToString());
                    if (a == 0)
                    {
                        for (int i = 0; i < int.Parse(dgr.Cells[1].Text.ToString()); i++)
                        {
                            datos.enviardatos("insert into tmesas (idambiente,mesa) values (" + dt.Rows[0][0].ToString() + "," + (i + 1).ToString() + ")");
                        }
                    }
                    else
                    {
                        DataTable dt1 = new DataTable();
                        dt1 = datos.extraedatos("SELECT max(mesa) from tmesas");

                        for (int i = int.Parse(dt1.Rows[0][0].ToString()); i < int.Parse(dt1.Rows[0][0].ToString()) + int.Parse(dgr.Cells[1].Text.ToString()); i++)
                        {
                            datos.enviardatos("insert into tmesas (idambiente,mesa) values (" + dt.Rows[0][0].ToString() + "," + (i + 1).ToString() + ")");
                        }
                    }
                }
          
                a++;
            }
        }    
    
        if (Session["eli"] == null)
        {
            if (a > 0)
            {
                DataTable dt2 = new DataTable();
                dt2 = datos.extraedatos("SELECT max(mesa) from tmesas");
                for (int i = int.Parse(dt2.Rows[0][0].ToString()); i < int.Parse(dt2.Rows[0][0].ToString()) + int.Parse(txtmesas.Text.ToString()); i++)
                {
                    datos.enviardatos("insert into tmesas (idambiente,mesa) values (" + Session["idambiente"].ToString() + "," + (i + 1).ToString() + ")");
                }
            }
            else
            {
                for (int i = 0; i < +int.Parse(txtmesas.Text.ToString()); i++)
                {
                    datos.enviardatos("insert into tmesas (idambiente,mesa) values (" + Session["idambiente"].ToString() + "," + (i + 1).ToString() + ")");
                }
            }
        }
    }
    protected void dgvmesas_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            int id = Convert.ToInt32(dgvmesas.DataKeys[e.RowIndex].Value);
            datos.enviardatos("delete from tmesas where idambiente=" + id.ToString());
            datos.enviardatos("delete from tambiente where idambiente=" + id.ToString());
            Session["eli"] = "1";
            recrear();

        }
        catch { }
        llenarmesas();
    }

    protected void btnag_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt = datos.extraedatos("select count(*) from tcategorias where nombrecategoria='" + txtcategoria.Text + "'");
        if (dt.Rows[0][0].ToString() == "0")
        {
            datos.enviardatos("insert into tcategorias (nombrecategoria) values('" + txtcategoria.Text + "')");
            llenarcategorias();
        }
    }


    protected void dgvcategoria_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            int id = Convert.ToInt32(dgvcategoria.DataKeys[e.RowIndex].Value);
            datos.enviardatos("delete from tcategorias where idcategoria=" + id.ToString());
        }
        catch
        {

        }
        llenarcategorias();
    }

   
}