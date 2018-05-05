<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mesas.aspx.cs" Inherits="mesas" %>

<!DOCTYPE html>
<html lang="en">
  <head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <!-- Meta, title, CSS, favicons, etc. -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>Ambientes</title>

    <!-- Bootstrap -->
    <link href="vendors/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet">
    <!-- Font Awesome -->
    <link href="vendors/font-awesome/css/font-awesome.min.css" rel="stylesheet">
    <!-- NProgress -->
    <link href="vendors/nprogress/nprogress.css" rel="stylesheet">
    
    <!-- Custom styling plus plugins -->
    <link href="build/css/custom.min.css" rel="stylesheet">
      <style>

          .ocupado {
          background-color:#ff9100  ;
          color:white;
          height:115px;
          }
        .ocupado:hover {
            background-color:#ffab40;
    color:white;
        }
    .disponible {
        background-color:#00b0ff   ;
        color:white;
        height:115px;

          }
        .disponible:hover {
            background-color:#40c4ff;
        }

         .atendido {
              background-color:#00c853  ;
              color:white;
              height:115px;

          }
        .atendido:hover {
            background-color:#00e676;
        }

              
      </style>
  </head>

  <body class="nav-md" style="background-color:white !important;">
    <form id="form1" runat="server">

    <div class="container body" style="background-color:white !important;">
      <div class="main_container" style="background-color:white !important;">
          
        <asp:PlaceHolder ID="plcmesas" runat="server"></asp:PlaceHolder>

          </div>

             
                    </div>
        
      </form>

    <!-- jQuery -->
    <script src="vendors/jquery/dist/jquery.min.js"></script>
    <!-- Bootstrap -->
    <script src="vendors/bootstrap/dist/js/bootstrap.min.js"></script>
    <!-- FastClick -->
    <script src="vendors/fastclick/lib/fastclick.js"></script>
    <!-- NProgress -->
    <script src="vendors/nprogress/nprogress.js"></script>

    <!-- Custom Theme Scripts -->
    <script src="build/js/custom.min.js"></script>
  </body>
</html>