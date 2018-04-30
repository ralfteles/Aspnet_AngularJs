
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("Cliente")>
Public Class Cliente

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    <Column("IdCliente")>
    Public Property IdCliente As Integer

    <Column("Nome")>
    Public Property Nome As String

    <Column("Cpf")>
    Public Property Cpf As String

    <Column("Rg")>
    Public Property Rg As String

    <Column("Cep")>
    Public Property Cep As String

    <Column("Logradouro")>
    Public Property Logradouro As String

    <Column("Numero")>
    Public Property Numero As String

    <Column("Bairro")>
    Public Property Bairro As String

    <Column("Municipio")>
    Public Property Municipio As String

    <Column("Uf")>
    Public Property Uf As String

    <Column("NumeroTelefone")>
    Public Property NumeroTelefone As String

End Class
