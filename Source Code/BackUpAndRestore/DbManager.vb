
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data.SqlClient
Imports System.Windows.Forms

'This file was created for database management purpose
'Written by CenDoy
'Date: 13/4/2007

Public Class DbManager
    Public Shared server As String
    Public Shared database As String
    Public Shared username As String
    Public Shared password As String
    Public Shared con As SqlConnection
    Public Shared com As SqlCommand
    Public Shared reader As SqlDataReader
    Public Shared isAdmin As Boolean = True
    Public Shared userId As String

    'return connection string to the database include of inital database
    Public Shared Function getConnectString() As String
        Return "Data Source=" + server + ";Initial Catalog=" + database + ";User Id=" + username + ";Password=" + password + ";"

    End Function 'getConnectString
    Public Shared strConn As String
    Public Shared Sub SetConnectionString(ByVal conn As String)
        strConn = conn
    End Sub
    'connect to database
    Public Shared Sub Connect()
        ' con = New SqlConnection(getConnectString())
        con = New SqlConnection(strConn)
    End Sub 'Connect


    'open a sql command and return in reader
    Public Shared Function OpenSQL(ByVal sql As String) As Boolean
        Try
            If con Is Nothing Then Connect()
            If con.State = System.Data.ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            com = New SqlCommand(sql, con)
            reader = com.ExecuteReader()
            Return True
        Catch ex As Exception
            MessageBox.Show("Exception Occurs: " + ex.ToString())
            Return False
        End Try
    End Function 'OpenSQL

    Public Shared Function CheckTableExists(ByVal sql As String) As Boolean
        Dim dt As DataTable = OpenSqlRetDataTable(sql)
        Return dt.Rows.Count > 0
    End Function

    Public Shared Function OpenSqlRetDataTable(ByVal sql As String) As DataTable
        Dim dt = New DataTable
        Try
            If con Is Nothing Then Connect()
            If con.State = System.Data.ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            Dim da As SqlDataAdapter = New SqlDataAdapter(sql, con)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MessageBox.Show("Exception Occurs: " + ex.ToString())
            Return Nothing
        End Try
    End Function

    Public Shared showMsgWhenError = True
    Public Shared Function ExeSQLNoTransaction(ByVal sql As String) As Boolean
        Try
            If con Is Nothing Then
                Connect()
            End If
            If con.State = System.Data.ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            com = New SqlCommand(sql, con)
            com.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            If showMsgWhenError Then MessageBox.Show("Exception Occurs: " + ex.ToString())
            Return False
        End Try
    End Function 'ExeSQL
    'execute a sql command with non returned.
    Public Shared Function ExeSQL(ByVal sql As String) As Boolean
        Try
            If con Is Nothing Then
                Connect()
            End If
            If con.State = System.Data.ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            com = New SqlCommand(sql, con)
            com.Transaction = con.BeginTransaction()
            com.ExecuteNonQuery()
            com.Transaction.Commit()
            Return True
        Catch ex As Exception
            If showMsgWhenError Then MessageBox.Show("Exception Occurs: " + ex.ToString())
            Return False
        End Try
    End Function 'ExeSQL
End Class 'DbManager