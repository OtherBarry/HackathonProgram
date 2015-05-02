Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations

Public Class taskDatabase
    Public Property ID() As Integer
    Public Property name() As String
    Public Property subject() As String
    Public Property type() As String
    Public Property duedate() As Date
    Public Property length() As Integer
    Public Property internet() As Boolean
    Public Property notes() As String
End Class

Public Class TaskList
    Inherits DbContext
    Public Property Tasks() As DbSet(Of taskDatabase)
End Class