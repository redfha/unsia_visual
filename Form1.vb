Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO

Public Class Form1
    Public total_cost As Integer
    Public limit As Integer
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTipe.SelectedIndexChanged
        If ComboBoxTipe.Text = "Operasional" Then
            limit = 5000000
        ElseIf ComboBoxTipe.Text = "Non-operasional" Then
            limit = 3000000
        Else
            limit = 0
        End If
        TextBoxLimit.Text = limit.ToString()
    End Sub
    Private Sub submit_items_Click(sender As Object, e As EventArgs) Handles submit_items.Click
        If limit > 0 And TextBoxFileLocation.Text.Trim <> "" Then
            Call tableContent()
        Else
            System.Windows.Forms.MessageBox.Show("Harap mengisi tipe dan file spesifikasi barang yang diajukan")
        End If

    End Sub
    Sub tableContent()
        Dim list_table As New ListViewItem
        list_table.Text = ComboBoxTipe2.Text
        list_table.SubItems.Add(TextBoxDesc.Text)
        list_table.SubItems.Add(TextBoxQty.Text)
        list_table.SubItems.Add(TextBoxHargaSatuan.Text)
        list_table.SubItems.Add(Integer.Parse(TextBoxQty.Text) * Integer.Parse(TextBoxHargaSatuan.Text))
        list_items.Items.Add(list_table)
        Call totalPrice(Integer.Parse(TextBoxQty.Text) * Integer.Parse(TextBoxHargaSatuan.Text))
    End Sub
    Sub totalPrice(number)
        total_cost += number
        limit -= total_cost
        TextBoxTotalCost.Text = total_cost.ToString()
        TextBoxLastLimit.Text = limit.ToString()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles button_hapus.Click
        If list_items.SelectedItems.Count > 0 Then
            total_cost -= Integer.Parse(list_items.SelectedItems(0).SubItems(4).Text)
            limit += Integer.Parse(list_items.SelectedItems(0).SubItems(4).Text)
            TextBoxTotalCost.Text = total_cost.ToString()
            TextBoxLastLimit.Text = limit.ToString()
            list_items.Items.Remove(list_items.SelectedItems(0))
        End If
    End Sub
    Private Sub ButtonBrowseFile_Click(sender As Object, e As EventArgs) Handles ButtonBrowseFile.Click
        OpenFileDialog.InitialDirectory = "Documents"
        OpenFileDialog.FileName = "PDF File"
        OpenFileDialog.Title = "Open File"
        OpenFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files|*.*"
        OpenFileDialog.ShowDialog()
        TextBoxFileLocation.Text = OpenFileDialog.FileName
    End Sub
End Class
