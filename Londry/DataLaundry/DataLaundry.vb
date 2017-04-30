Public Class DataLaundry


    Private Sub Tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tambah1.Click
        cmb2.Visible = True
        Tambah2.Visible = True
        Tambah1.Visible = False
    End Sub

  


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb1.Visible = False
        cmb2.Visible = False
        cmb3.Visible = False
        Tambah1.Visible = False
        Tambah2.Visible = False
        tambah3.Visible = False


    End Sub

    Private Sub satuan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles satuan.CheckedChanged
        If satuan.Checked Then
            cmb1.Visible = True
            Tambah1.Visible = True
        Else
            cmb1.Visible = False
            Tambah1.Visible = False
            cmb2.Visible = False
            Tambah2.Visible = False

        End If
    End Sub

    
End Class
