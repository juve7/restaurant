using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de validar
/// </summary>
public class validar
{

    public string SafeDBString(string inputValue)
    {
        return inputValue.Replace("'", "''");
    }
}