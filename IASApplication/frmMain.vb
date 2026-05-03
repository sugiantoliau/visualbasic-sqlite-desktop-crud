Imports system.data
Imports system.data.DataView
Imports system.data.DataTable
Imports System.Data.Common
Imports System.Data.SQLite





Public Class frmMAIN

    Dim conn As SQLiteConnection
    Dim connString As String = "Data Source=" & Application.StartupPath & "\Database\appdb;Version=3;"



    Private Sub frmMAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Sub fn_database_conn_check()
        Dim relativePath As String = IO.Path.Combine(Application.StartupPath, "Database", "app.db")
        Dim absolutePath As String = IO.Path.GetFullPath(relativePath)

        Try
            If Not System.IO.File.Exists(absolutePath) Then
                MsgBox("FILE NOT FOUND!" & vbCrLf & vbCrLf &
                       "Looked in: " & absolutePath,
                       MsgBoxStyle.Critical, "Directory Error")
                Return
            End If

            Using testConn As New SQLiteConnection("Data Source=" & absolutePath & ";Version=3;")
                testConn.Open()

                MsgBox("SUCCESS!" & vbCrLf &
                       "Database connected at: " & absolutePath & vbCrLf &
                       "SQLite Version: " & testConn.ServerVersion,
                       MsgBoxStyle.Information, "Connection Check")

                testConn.Close()
            End Using

        Catch ex As Exception
            MsgBox("CONNECTION FAILED!" & vbCrLf & vbCrLf & "Error: " & ex.Message, MsgBoxStyle.Critical, "System Error")
        End Try
    End Sub

    Sub fn_connectdb()
        Try
            Dim dbPath As String = IO.Path.Combine(Application.StartupPath, "..", "..", "Database", "app.db")

            Dim absolutePath As String = IO.Path.GetFullPath(dbPath)
            Console.WriteLine("Database resolved to: " & absolutePath)

            conn = New SQLiteConnection("Data Source=" & absolutePath & ";Version=3;")

            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message)
        End Try
    End Sub


    Sub fn_View_Data()
        Try
            fn_connectdb()
            Dim sql As String = "SELECT id, Name, Price FROM product"


            Dim adapter As New SQLiteDataAdapter(sql, conn)
            Dim dt As New DataTable()


            adapter.Fill(dt)


            DataGridView1.DataSource = dt


            DataGridView1.Columns(0).HeaderText = "ID"
            DataGridView1.Columns(1).HeaderText = "Product Name"
            DataGridView1.Columns(2).HeaderText = "Price"

        Catch ex As Exception
            MsgBox("View Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub fn_Add_Data()
        Try
            fn_connectdb()
            Dim sql As String = "INSERT INTO product (Name, Price) VALUES (@name, @price)"
            Using cmd As New SQLiteCommand(sql, conn)
                cmd.Parameters.AddWithValue("@name", tx_Name.Text)
                cmd.Parameters.AddWithValue("@price", Convert.ToDouble(tx_Price.Text))
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Product Added!")
        Catch ex As Exception
            MsgBox("Add Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Sub fn_Update_Data()
        Try
            fn_connectdb()
            Dim sql As String = "UPDATE product SET Name = @name, Price = @price WHERE id = @id"
            Using cmd As New SQLiteCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", tx_ID.Text)
                cmd.Parameters.AddWithValue("@name", tx_Name.Text)
                cmd.Parameters.AddWithValue("@price", Convert.ToDouble(tx_Price.Text))
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Product Updated!")
        Catch ex As Exception
            MsgBox("Update Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Sub fn_Delete_Data()
        Try
            If MsgBox("Are you sure?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                fn_connectdb()
                Dim sql As String = "DELETE FROM product WHERE id = @id"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", tx_ID.Text)
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("Product Deleted!")
            End If
        Catch ex As Exception
            MsgBox("Delete Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub bt_database_conn_check_Click(sender As Object, e As EventArgs) Handles bt_database_conn_check.Click
        fn_database_conn_check()
    End Sub


    Private Sub bt_AddDataProduct_Click(sender As Object, e As EventArgs) Handles bt_AddDataProduct.Click
        fn_Add_Data()
    End Sub

    Private Sub bt_UpdateDataProduct_Click(sender As Object, e As EventArgs) Handles bt_UpdateDataProduct.Click
        fn_Update_Data()
    End Sub

    Private Sub bt_DeleteDataProduct_Click(sender As Object, e As EventArgs) Handles bt_DeleteDataProduct.Click
        fn_Delete_Data()
    End Sub



End Class




