Imports System.Reflection
Imports System.Web.Optimization
Imports Projeto.Dal
Imports SimpleInjector
Imports SimpleInjector.Integration.Web
Imports SimpleInjector.Integration.Web.Mvc
Imports SimpleInjector.Lifestyles

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)

        'Configurando Simple Injector
        Dim container = New Container
        container.Options.DefaultScopedLifestyle = New WebRequestLifestyle

        container.Register(Of IClienteContratos, ClienteRepositorio)(Lifestyle.Scoped)

        container.RegisterMvcControllers(Assembly.GetExecutingAssembly)
        container.Verify()
        DependencyResolver.SetResolver(New SimpleInjectorDependencyResolver(container))


    End Sub


End Class
