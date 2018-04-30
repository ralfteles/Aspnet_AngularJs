<!DOCTYPE html>
<html ng-app="app">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Controle Clientes</title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="~/Content/Site.css" rel="stylesheet" />

    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

    <script src="Scripts/angular.min.js"></script>
    <script src="Scripts/angular-route.min.js"></script>
    <script src="Scripts/Mask/ngMask.min.js"></script>
    <script src="Scripts/dirPagination.js"></script>

    <script src="App/app.js"></script>
    <script src="App/routes.js"></script>

    <script src="App/services/clienteService.js"></script>
    <script src="App/controllers/cliente/clienteController.js"></script>

</head>
<body class="container">
    <nav class="navbar navbar-inverse" style="margin-top:5px;">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand" href="#">Controle de Clientes</a>
            </div>
        </div>
    </nav>

    <!-- TOPO -->
    <div class="well well-sm" style="margin-top: -20px;">
        <h3 class="text-center">Sistema de Gestão de Clientes</h3>
        <br />
        <div class="text-center">
            <a href="#cliente/cadastro" class="btn btn-default btn-lg"><strong>Cadastrar</strong></a>

            <a href="#cliente/consulta" class="btn btn-info btn-lg"><strong>Consultar</strong></a>
        </div>
    </div>

    <!-- CONTEUDO -->
    <div class="row">

        <div ng-view></div>

    </div>

    @RenderBody()

</body>
</html>
