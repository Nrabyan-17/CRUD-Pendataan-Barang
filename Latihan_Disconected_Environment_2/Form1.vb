
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    'Function untuk koneksi ke database'
    Sub koneksi()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1; userid=root; password=''; database=database"
        Try
            conn.Open()
            MessageBox.Show("Koneksi Berhasil")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    'Untuk menampilkan data pada form'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds = New DataSet()
        Call koneksi()
        da = New MySqlDataAdapter("SELECT * FROM tblbarang", conn)
        da.Fill(ds, "xxx")
        DataGridView1.DataSource = ds.Tables("xxx").DefaultView
    End Sub

    'Function untuk menambahkan data'
    Sub tambahData()
        Dim sqlcommand As New MySqlCommand()

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            sqlcommand.Connection = conn
            sqlcommand.CommandText = "INSERT INTO tblbarang (Kode_Barang, Nama_Barang, Jenis, Satuan, Harga_Beli, Harga_Jual) VALUES (@Kode_Barang, @Nama_Barang, @Jenis, @Satuan, @Harga_Beli, @Harga_Jual)"
            sqlcommand.Parameters.AddWithValue("@Kode_Barang", kodeBrg.Text)
            sqlcommand.Parameters.AddWithValue("@Nama_Barang", nmBrg.Text)
            sqlcommand.Parameters.AddWithValue("@Jenis", cbJnsBrg.SelectedItem.ToString())
            sqlcommand.Parameters.AddWithValue("@Satuan", cbJnsSatuan.SelectedItem.ToString())
            sqlcommand.Parameters.AddWithValue("@Harga_Beli", CDec(hrgBeli.Text))
            sqlcommand.Parameters.AddWithValue("@Harga_Jual", CDec(hrgJual.Text))

            sqlcommand.ExecuteNonQuery()
            MsgBox("data berhasil disimpan")

        Catch ex As Exception
            MsgBox("gagal menyimpan data: " & ex.Message)
        Finally
            conn.Close()
        End Try

        'da = New MySqlDataAdapter("SELECT MAX(CAST(no AS SIGNED)) + 1 FROM tblbarang", conn)
        'da.Fill(ds, "xx1")
        'If ds.Tables("xx1").Rows(0).Item(0) IsNot DBNull.Value Then
        'kodeBrg.Text = ds.Tables("xx1").Rows(0).Item(0).ToString()
        'Else
        'kodeBrg.Text = ""
        'End If '

        'Untuk refresh datagridview'
        ds.Clear()
        da = New MySqlDataAdapter("SELECT * FROM tblbarang", conn)
        da.Fill(ds, "xxx")
        DataGridView1.DataSource = ds.Tables("xxx").DefaultView
    End Sub

    'Tombol simpan'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call tambahData()
    End Sub

    'Function untuk mengedit data'
    Sub editData()
        Dim sqlCommand As New MySqlCommand
        Dim kode_barang As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString

        If DataGridView1.SelectedRows.Count >= 0 Then
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                sqlCommand.Connection = conn
                sqlCommand.CommandText = "UPDATE tblbarang SET Kode_Barang = @Kode_BarangBaru, Nama_Barang = @Nama_Barang, Jenis = @Jenis, Satuan = @Satuan, Harga_Beli = @Harga_Beli, Harga_Jual = @Harga_Jual WHERE Kode_Barang = @Kode_BarangLama"
                sqlCommand.Parameters.AddWithValue("@Kode_BarangBaru", kodeBrg.Text)
                sqlCommand.Parameters.AddWithValue("@Kode_BarangLama", kode_barang)
                sqlCommand.Parameters.AddWithValue("@Nama_Barang", nmBrg.Text)
                sqlCommand.Parameters.AddWithValue("@Jenis", cbJnsBrg.SelectedItem.ToString())
                sqlCommand.Parameters.AddWithValue("@Satuan", cbJnsSatuan.SelectedItem.ToString())
                sqlCommand.Parameters.AddWithValue("@Harga_Beli", CDec(hrgBeli.Text))
                sqlCommand.Parameters.AddWithValue("@Harga_Jual", CDec(hrgJual.Text))

                sqlCommand.ExecuteNonQuery()
                MsgBox("Data berhasil di update ")

            Catch ex As Exception
                MsgBox("Data gagal di update")
            Finally
                conn.Close()
            End Try

            'Untuk refresh datagridview'
            ds.Clear()
            da = New MySqlDataAdapter("SELECT * FROM tblbarang", conn)
            da.Fill(ds, "xxx")
            DataGridView1.DataSource = ds.Tables("xxx").DefaultView
        End If
    End Sub

    'Tombol edit'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call editData()
    End Sub

    'Function untuk menghapus data'
    Sub hapusData()
        Dim sqlCommand As New MySqlCommand
        Dim kode_barang As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            sqlCommand.Connection = conn
            sqlCommand.CommandText = "DELETE FROM tblbarang WHERE Kode_Barang = @Kode_Barang"
            sqlCommand.Parameters.AddWithValue("@Kode_Barang", kode_barang)

            sqlCommand.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus!")
        Catch ex As Exception
            MsgBox("Data barang gagal dihapus", ex.Message)
        Finally
            conn.Close()
        End Try

        'Untuk refresh datagridview'
        ds.Clear()
        da = New MySqlDataAdapter("SELECT * FROM tblbarang", conn)
        da.Fill(ds, "xxx")
        DataGridView1.DataSource = ds.Tables("xxx").DefaultView
    End Sub

    'Tombol hapus'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call hapusData()
    End Sub


End Class
