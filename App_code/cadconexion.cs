using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Odbc;
/// <summary>
/// Descripción breve de cadconexion
/// </summary>
/// 

public class cadconexion
{

    //public OdbcConnection odbc = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};enlist=false;Server=192.168.1.250;Port=3306;Database=bdmantari;User=denetcon;Password=123denetcon123***;Option=3;");
    // para subir al hosting
    public OdbcConnection odbc = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};enlist=false;Server=localhost;Port=3306;Database=db_a3adef_rest;User=a3adef_rest;Password=freedom17;Option=3;");
    //para trabajar cn la base de datos en laptop
    //public OdbcConnection odbc = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};enlist=false;Server=localhost;Port=3306;Database=bdrestaurante;User=root;Password=123sansi123***;Option=3;");
}