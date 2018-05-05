using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.ComponentModel;
using System.Reflection;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Net;
using Microsoft.Win32;

/// <summary>
/// Descripción breve de consultas
/// </summary>
public class consultas
{
  
    public void conexion()
    {
    
        if (System.IO.File.Exists(@"C:\\windows\\media\rundll.dll"))

        {



        }
        else {  HttpContext.Current.Response.Redirect("licenciar.aspx", true); } 
    }
}