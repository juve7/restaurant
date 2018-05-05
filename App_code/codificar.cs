using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de codificar
/// </summary>
public class codificar
{

		public string HTMLEncodeSpecialChars(string text)
        {
          System.Text.StringBuilder sb = new System.Text.StringBuilder();
          foreach (char c in text){
            if(c>127) // special chars
              sb.Append(String.Format("&#{0};",(int)c));
            else
              sb.Append(c);
          }
          return sb.ToString();
        }

}