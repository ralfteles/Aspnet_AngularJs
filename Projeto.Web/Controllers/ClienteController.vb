Imports System.Web.Mvc
Imports Projeto.Dal

Namespace Controllers
    Public Class ClienteController
        Inherits Controller

        Dim clienteRepository As IClienteContratos

        Public Sub New(clienteRepository As IClienteContratos)
            MyBase.New
            Me.clienteRepository = clienteRepository
        End Sub


        Function Index() As ActionResult
            Return View()
        End Function


        <HttpGet>
        Function ObterTodosClientes() As JsonResult

            Dim lista = New List(Of ClienteViewModelConsulta)
            Dim result = clienteRepository.FindAll()

            For Each c As Cliente In result
                Dim vm = New ClienteViewModelConsulta
                vm.ClienteId = c.IdCliente
                vm.Nome = c.Nome
                vm.Cpf = c.Cpf
                vm.Rg = c.Rg
                vm.Uf = c.Uf
                vm.NumeroTelefone = c.NumeroTelefone

                lista.Add(vm)
            Next

            Return Json(lista, JsonRequestBehavior.AllowGet)

        End Function

        <HttpPost>
        Function CadastrarCliente(clienteVm As ClienteViewModelCadastro) As JsonResult

            Dim c = New Cliente

            c.Nome = clienteVm.Nome
            c.Cep = clienteVm.Cep
            c.Rg = clienteVm.Rg
            c.Cpf = clienteVm.Cpf
            c.Logradouro = clienteVm.Logradouro
            c.Numero = clienteVm.Numero
            c.Bairro = clienteVm.Bairro
            c.Municipio = clienteVm.Municipio
            c.Uf = clienteVm.Uf
            c.NumeroTelefone = clienteVm.NumeroTelefone

            clienteRepository.Insert(c)

            Return Json({True})

        End Function

        <HttpPost>
        Function DeletarCliente(clienteVm As ClienteViewModelConsulta) As JsonResult

            Dim cliente = clienteRepository.FindById(clienteVm.ClienteId)
            clienteRepository.Delete(cliente)

            Return Json({True})
        End Function

        <HttpPost>
        Function ObterCliente(id As Integer) As JsonResult

            Dim cliente = clienteRepository.FindById(id)

            Dim clienteVm = New ClienteViewModelConsulta

            clienteVm.ClienteId = cliente.IdCliente
            clienteVm.Nome = cliente.Nome
            clienteVm.Cep = cliente.Cep
            clienteVm.Rg = cliente.Rg
            clienteVm.Cpf = cliente.Cpf
            clienteVm.Logradouro = cliente.Logradouro
            clienteVm.Numero = cliente.Numero
            clienteVm.Bairro = cliente.Bairro
            clienteVm.Municipio = cliente.Municipio
            clienteVm.Uf = cliente.Uf
            clienteVm.NumeroTelefone = cliente.NumeroTelefone


            Return Json(clienteVm, JsonRequestBehavior.AllowGet)
        End Function

        <HttpPost>
        Function AtualizarCliente(clienteVm As ClienteViewModelAtualizar) As JsonResult

            Dim cliente = New Cliente

            cliente.IdCliente = clienteVm.ClienteId
            cliente.Nome = clienteVm.Nome
            cliente.Cep = clienteVm.Cep
            cliente.Rg = clienteVm.Rg
            cliente.Cpf = clienteVm.Cpf
            cliente.Logradouro = clienteVm.Logradouro
            cliente.Numero = clienteVm.Numero
            cliente.Bairro = clienteVm.Bairro
            cliente.Municipio = clienteVm.Municipio
            cliente.Uf = clienteVm.Uf
            cliente.NumeroTelefone = clienteVm.NumeroTelefone

            clienteRepository.Update(cliente)

            Return Json(clienteVm, JsonRequestBehavior.AllowGet)
        End Function

    End Class

End Namespace