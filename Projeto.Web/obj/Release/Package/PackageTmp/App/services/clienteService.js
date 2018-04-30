app.service(
    '$clienteSvc',
    function ($http) {

        var services = {};

        services.cadastrar = function (model) {
            return $http.post("/Cliente/CadastrarCliente", model);
        }

        services.obterTodos = function () {
            return $http.get("Cliente/ObterTodosClientes");
        }

        services.deletar = function (model) {
            return $http.post("/Cliente/DeletarCliente/", model);
        }

        services.ObterCliente = function (id) {
            return $http.post("/Cliente/ObterCliente/", id);
        }

        services.atualizar = function (model) {
            return $http.post("/Cliente/AtualizarCliente", model);
        }

        return services;
    });
