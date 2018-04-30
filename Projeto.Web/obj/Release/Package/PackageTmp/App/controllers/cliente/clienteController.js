app.controller(
    'clienteCtrl',
    function ($clienteSvc, $routeParams) {
        var vm = this;

        vm.Cadastrar = function (isValid) {

            if (isValid) {
                vm.mensagem = {};

                $clienteSvc.cadastrar(vm.model)
                .then(function () {
                    vm.mensagem = "Cliente " + vm.model.Nome + " cadastrado com sucesso!";
                    vm.model = {};
                })
                 .catch(function (e) {
                     console.log(e.data);
                 });
            }
        }

        vm.Atualizar = function (isValid) {

            if (isValid) {
                vm.mensagem = {};

                var model = vm.model;

                $clienteSvc.atualizar(model)
                .then(function () {
                    vm.mensagem = "Cliente " + vm.model.Nome + " atualizado com sucesso!";
                })
                 .catch(function (e) {
                     console.log(e.data);
                 });
            }
        }

        vm.listaClientes = function () {

            $clienteSvc.obterTodos()

            .then(function (result) {
                vm.clientes = result.data;
            })
             .catch(function (e) {
                 console.log(e.data);
             });
        }

        vm.deletar = function (c) {

            $clienteSvc.deletar(c)
            .then(function () {
                vm.mensagem = "Cliente excluido com sucesso!";
                vm.listaClientes();
            })
             .catch(function (e) {
                 console.log(e.data);
             });
        }

        vm.ObterCliente = function () {

            var id = $routeParams;

            $clienteSvc.ObterCliente(id)
            .then(function (result) {
                vm.model = result.data;
            })
            .catch(function (e) {
                console.log(e.data);
            });
        }


    });