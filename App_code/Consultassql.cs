using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

using System.Data.Odbc;
public class Consultassql
{
    public DataTable extraedatos(string nombre_sp)
    {
        DataTable dt = new DataTable();

        cadconexion cn = new cadconexion();
        OdbcDataAdapter da = new OdbcDataAdapter();
        OdbcCommand cmd = new OdbcCommand();
        cmd.Connection = cn.odbc;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = nombre_sp;
        cmd.Connection.Close();
        cmd.Connection.Open();
        da.SelectCommand = cmd;
        da.Fill(dt);
        cmd.Connection.Close();
        return dt;
       
    
    }
    public long scalar(string nombre_sp)
    {

        
        try
        {
            cadconexion cn = new cadconexion();

        OdbcCommand cmd = new OdbcCommand();
        cmd.Connection = cn.odbc;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = nombre_sp;
        cmd.Connection.Close();
        cmd.Connection.Open();
        long num = (long)cmd.ExecuteScalar();
        cmd.Connection.Close();

            return num;
        }
         catch
        {
            return 0;
        }
      
    }
    public void enviardatos(string nombre_sp)
    {

        cadconexion cn = new cadconexion();
        OdbcDataAdapter da = new OdbcDataAdapter();
        OdbcCommand cmd = new OdbcCommand();
        DataTable dt = new DataTable();
        cmd.Connection = cn.odbc;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = nombre_sp;
        cmd.Connection.Close();
        cmd.Connection.Open();
        da.SelectCommand = cmd;
        cmd.ExecuteNonQuery();
        cmd.Connection.Close();
 
    }

    //public void enviardatos(string nombre_sp,string param1,string param2)
    //{

    //    cadconexion cn = new cadconexion();
    //    OdbcDataAdapter da = new OdbcDataAdapter();
    //    OdbcCommand cmd = new OdbcCommand();
    //    DataTable dt = new DataTable();
    //    cmd.Connection = cn.odbc;
    //    cmd.CommandType = CommandType.StoredProcedure;
        
    //    cmd.CommandText = nombre_sp;
    //    cmd.Parameters.Add(param1, Data.SqlDbType.VarChar).Value)
    //    cmd.Connection.Open();
    //    da.SelectCommand = cmd;
    //    cmd.ExecuteNonQuery();
    //    cmd.Connection.Close();
      
    //}
    public DataTable extraedatos(string nombre_sp,string tipo,string cadena)
    {

        cadconexion cn = new cadconexion();
        OdbcDataAdapter da = new OdbcDataAdapter();
        OdbcCommand cmd = new OdbcCommand();
        DataTable dt = new DataTable();
        cmd.Connection = cn.odbc;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = nombre_sp;
        cmd.Parameters.AddWithValue(tipo, cadena);
        cmd.Connection.Open();
        da.SelectCommand = cmd;
        cmd.Connection.Close();
        da.Fill(dt);
        return dt;
    }
    //public DataTable extraedatos(string nombre_sp, int valor, string nombreparam)
    //{
    //    cadconexion cn = new cadconexion(); //
    //    SqlDataAdapter da = new SqlDataAdapter();
    //    SqlCommand cmd = new SqlCommand();
    //    DataTable dt = new DataTable();
    //    cmd.Connection = cn.cadsql; //
    //    cmd.CommandType = CommandType.StoredProcedure;
    //    cmd.CommandText = nombre_sp;
    //    cmd.Connection.Open();
    //    da.SelectCommand = cmd;
    //    da.SelectCommand.Parameters.Add(nombreparam, SqlDbType.Int).Value = valor;
    //    da.Fill(dt);
    //    return dt;
    //}
    //public DataTable extraedatos(string nombre_sp, String valor, string nombreparam)
    //{
    //    cadconexion cn = new cadconexion(); //
    //    SqlDataAdapter da = new SqlDataAdapter();
    //    SqlCommand cmd = new SqlCommand();
    //    DataTable dt = new DataTable();
    //    cmd.Connection = cn.cadsql; //
    //    cmd.CommandType = CommandType.StoredProcedure;
    //    cmd.CommandText = nombre_sp;
    //    cmd.Connection.Open();
    //    da.SelectCommand = cmd;
    //    da.SelectCommand.Parameters.Add(nombreparam, SqlDbType.NVarChar).Value = valor;
    //    da.Fill(dt);
    //    return dt;
    //}
    //public DataTable extraedatos(string nombre_sp, String valor, string nombreparam, int cat, string param2)
    //{
    //    cadconexion cn = new cadconexion(); //
    //    SqlDataAdapter da = new SqlDataAdapter();
    //    SqlCommand cmd = new SqlCommand();
    //    DataTable dt = new DataTable();
    //    cmd.Connection = cn.cadsql; //
    //    cmd.CommandType = CommandType.StoredProcedure;
    //    cmd.CommandText = nombre_sp;
    //    cmd.Connection.Open();
    //    da.SelectCommand = cmd;
    //    da.SelectCommand.Parameters.Add(nombreparam, SqlDbType.NVarChar).Value = valor;
    //    da.SelectCommand.Parameters.Add(param2, SqlDbType.Int).Value = cat;
    //    da.Fill(dt);
    //    return dt;
    //}
    //public DataTable extraedatos(string nombre_sp, String valor1, string nombreparam1,string valor2, string nombreparam2)
    //{
    //    cadconexion cn = new cadconexion(); //
    //    SqlDataAdapter da = new SqlDataAdapter();
    //    SqlCommand cmd = new SqlCommand();
    //    DataTable dt = new DataTable();
    //    cmd.Connection = cn.cadsql; //
    //    cmd.CommandType = CommandType.StoredProcedure;
    //    cmd.CommandText = nombre_sp;
    //    cmd.Connection.Open();
    //    da.SelectCommand = cmd;
    //    da.SelectCommand.Parameters.Add(nombreparam1, SqlDbType.NVarChar).Value = valor1;
    //    da.SelectCommand.Parameters.Add(nombreparam2, SqlDbType.NVarChar).Value = valor2;
    //    da.Fill(dt);
    //    return dt;
    //}
    //public DataTable extraedatosfecha(string nombre_sp, DateTime valor1, string nombreparam1, DateTime valor2, string nombreparam2)
    //{
    //    cadconexion cn = new cadconexion(); //
    //    SqlDataAdapter da = new SqlDataAdapter();
    //    SqlCommand cmd = new SqlCommand();
    //    DataTable dt = new DataTable();
    //    cmd.Connection = cn.cadsql; //
    //    cmd.CommandType = CommandType.StoredProcedure;
    //    cmd.CommandText = nombre_sp;
    //    cmd.Connection.Open();
    //    da.SelectCommand = cmd;
    //    da.SelectCommand.Parameters.Add(nombreparam1, SqlDbType.Date).Value = valor1;
    //    da.SelectCommand.Parameters.Add(nombreparam2, SqlDbType.Date).Value = valor2;
    //    da.Fill(dt);
    //    return dt;
    //}
    //public DataTable extraedatos(string nombre_sp, Double valor1, string nombreparam1, Double valor2, string nombreparam2)
    //{
    //    cadconexion cn = new cadconexion(); //
    //    SqlDataAdapter da = new SqlDataAdapter();
    //    SqlCommand cmd = new SqlCommand();
    //    DataTable dt = new DataTable();
    //    cmd.Connection = cn.cadsql; //
    //    cmd.CommandType = CommandType.StoredProcedure;
    //    cmd.CommandText = nombre_sp;
    //    cmd.Connection.Open();
    //    da.SelectCommand = cmd;
    //    da.SelectCommand.Parameters.Add(nombreparam1, SqlDbType.Money).Value = valor1;
    //    da.SelectCommand.Parameters.Add(nombreparam2, SqlDbType.Money).Value = valor2;
    //    da.Fill(dt);
    //    return dt;
    //}
    //    public DataTable extraedatos(string nombre_sp, int valor, string nombreparam, int valor1, string nombreparam1)
    //{
    //    cadconexion cn = new cadconexion(); //
    //    SqlDataAdapter da = new SqlDataAdapter();
    //    SqlCommand cmd = new SqlCommand();
    //    DataTable dt = new DataTable();
    //    cmd.Connection = cn.cadsql; //
    //    cmd.CommandType = CommandType.StoredProcedure;
    //    cmd.CommandText = nombre_sp;
    //    cmd.Connection.Open();
    //    da.SelectCommand = cmd;
    //    da.SelectCommand.Parameters.Add(nombreparam, SqlDbType.Int).Value = valor;
    //     da.SelectCommand.Parameters.Add(nombreparam1, SqlDbType.Int).Value = valor1;

    //    da.Fill(dt);
    //    return dt;
    //}
    //public DataTable extraedatos(string nombre_sp, int valor, string nombreparam, int valor1, string nombreparam1,string valor2, string nombreparam2)
    //{
    //    cadconexion cn = new cadconexion(); //
    //    SqlDataAdapter da = new SqlDataAdapter();
    //    SqlCommand cmd = new SqlCommand();
    //    DataTable dt = new DataTable();
    //    cmd.Connection = cn.cadsql; //
    //    cmd.CommandType = CommandType.StoredProcedure;
    //    cmd.CommandText = nombre_sp;
    //    cmd.Connection.Open();
    //    da.SelectCommand = cmd;
    //    da.SelectCommand.Parameters.Add(nombreparam, SqlDbType.Int).Value = valor;
    //     da.SelectCommand.Parameters.Add(nombreparam1, SqlDbType.Int).Value = valor1;
    //    da.SelectCommand.Parameters.Add(nombreparam2, SqlDbType.NVarChar).Value = valor2;
    //    da.Fill(dt);
    //    return dt;
    //}
}