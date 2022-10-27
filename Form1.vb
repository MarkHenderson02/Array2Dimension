Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Arr(3, 1) As String
        Arr(0, 0) = "NIM"
        Arr(0, 1) = "Nama"
        Arr(1, 0) = "Jenis Kelamin"
        Arr(1, 1) = "Prodi"
        Arr(2, 0) = "Laki-laki"
        Arr(2, 1) = "Perempuan"
        Arr(3, 0) = "Tehnik Informatika"
        Arr(3, 1) = "Sistem Informasi"

        LV1.GridLines = True
        LV1.View = View.Details

        For Baris = 0 To 1
            For Kolom = 0 To 1
                LV1.Columns.Add(Arr(Baris, Kolom), 100)
            Next Kolom
        Next Baris

        For Baris = 2 To 2
            For Kolom = 0 To 1
                cbKelamin.Items.Add(Arr(Baris, Kolom))
            Next Kolom
        Next Baris

        For Baris = 3 To 3
            For Kolom = 0 To 1
                cbProdi.Items.Add(Arr(Baris, Kolom))
            Next Kolom
        Next Baris
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim Arr(3) As String
        Arr(0) = txtNim.Text
        Arr(1) = txtNama.Text
        Arr(2) = cbKelamin.Text
        Arr(3) = cbProdi.Text

        Dim listitem As ListViewItem
        listitem = New ListViewItem

        If txtNama.Text <> "" And txtNim.Text <> "" Then
            Arr(0) = txtNim.Text
            Dim ketemu = False
            For i = 0 To LV1.Items.Count - 1
                If LV1.Items(i).Text = txtNim.Text Then
                    ketemu = True
                    Exit For
                End If
            Next
            If Not ketemu Then
                listitem = LV1.Items.Add(Arr(0))
                listitem.SubItems.Add(Arr(1))
                listitem.SubItems.Add(Arr(2))
                listitem.SubItems.Add(Arr(3))

                txtNim.Text = txtNim.Text + 1
            Else
                MsgBox("Nomor Induk Mahasiswa Sudah ada ")
            End If
        Else
            MsgBox("Data Nomor Induk Mahasiswa (NIM) tidak boleh kosong")
        End If
        txtNama.Text = ""
            cbKelamin.Text = ""
            cbProdi.Text = ""
        txtNama.Focus()
    End Sub
End Class
