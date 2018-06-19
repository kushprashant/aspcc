<%@ Page Title="Contact" Language="C#"  AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="apcc.Login" %>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Admin APURVA STAR PLUSE COMPUTER CLASSES | Log in</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <!-- Bootstrap 3.3.6 -->
    <link href="admin/bootstrap/css/bootstrap.css" rel="stylesheet" />
    <!-- Font Awesome -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.5.0/css/font-awesome.min.css">
    <!-- Ionicons -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/ionicons/2.0.1/css/ionicons.min.css">
    <!-- Theme style -->
    <link href="admin/dist/css/AdminLTE.css" rel="stylesheet" />
    <!-- iCheck -->
    <link href="admin/plugins/iCheck/square/blue.css" rel="stylesheet" />

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->
</head>
<body class="hold-transition login-page">
    <form runat="server">
    <div class="login-box">
        <div class="login-logo">
            <a href="Default.aspx" runat="server"><b>ASPCC</b></a>
        </div>
        <!-- /.login-logo -->
        <div class="login-box-body">
            <p class="login-box-msg">Sign in to start your session</p>
             <div class="form-group row" runat="server" id="DivError" visible="false">
                <div class="col-sm-12">
                    <div class="alert alert-danger alert-dismissible">
                        <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
                        <h4><i class="icon fa fa-ban"></i>Error!</h4>
                        <asp:Label Text="Please Try after some Time." ID="lblErrorMsg" runat="server" />
                    </div>
                </div>
            </div>
         
                <div class="form-group has-feedback">
                    <asp:TextBox runat="server" class="form-control" placeholder="UserName" ID="txtEmail" ClientIDMode="Static"/>
                    <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
                </div>
                <div class="form-group has-feedback">
                    <input type="password" class="form-control" placeholder="Password" id="txtpwd" runat="server" ClientIDMode="Static">
                    <span class="glyphicon glyphicon-lock form-control-feedback"></span>
                </div>
                <div class="row">
                    <div class="col-xs-8">
                        <div class="checkbox icheck">
                            <label>
                                <input type="checkbox">
                                Remember Me
           
                            </label>
                        </div>
                    </div>
                    <!-- /.col -->
                    <div class="col-xs-4">
                        <asp:Button Text="Submit" ID="btnLogin" runat="server" OnClick="btnLogin_Click" class="btn btn-primary btn-block btn-flat"/>
                    </div>
                    <!-- /.col -->
                </div>
       

          <%--  <div class="social-auth-links text-center">
                <p>- OR -</p>
                <a href="#" class="btn btn-block btn-social btn-facebook btn-flat"><i class="fa fa-facebook"></i>Sign in using
        Facebook</a>
                <a href="#" class="btn btn-block btn-social btn-google btn-flat"><i class="fa fa-google-plus"></i>Sign in using
        Google+</a>
            </div>--%>
            <!-- /.social-auth-links -->

            <a href="#">I forgot my password</a><br>
          <%--  <a href="register.html" class="text-center">Register a new membership</a>--%>

        </div>
        <!-- /.login-box-body -->
    </div>
        </form>
    <!-- /.login-box -->

    <!-- jQuery 2.2.3 -->
    <script src="admin/plugins/jQuery/jquery-2.2.3.min.js"></script>
    <!-- Bootstrap 3.3.6 -->
    <script src="admin/bootstrap/js/bootstrap.min.js"></script>
    <!-- iCheck -->
    <script src="admin/plugins/iCheck/icheck.min.js"></script>
    <script>
        $(function () {
            $('input').iCheck({
                checkboxClass: 'icheckbox_square-blue',
                radioClass: 'iradio_square-blue',
                increaseArea: '20%' // optional
            });
        });
</script>
</body>
</html>
