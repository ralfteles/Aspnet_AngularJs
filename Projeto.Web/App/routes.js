//mapear as rotas e páginas desta aplicação..
app.config(function ($routeProvider) {
    $routeProvider

    .when(
        '/cliente/cadastro',
        {
            templateUrl: '/App/views/cliente/cadastro.html',
            controller: 'clienteCtrl as vm'
        })
    .when(
        '/cliente/consulta',
        {
            templateUrl: '/App/views/cliente/consulta.html',
            controller: 'clienteCtrl as vm'
        })
    .when(
        '/cliente/editar/:id',
        {
            templateUrl: '/App/views/cliente/editar.html',
            controller: 'clienteCtrl as vm'
        })

    $routeProvider.otherwise({
        redirectTo: '/'
    });


});

app.config(function ($locationProvider) {
    $locationProvider.hashPrefix('');
});
