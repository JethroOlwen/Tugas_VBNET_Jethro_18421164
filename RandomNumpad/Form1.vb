Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nums As New ArrayList
        For i As Integer = 1 To 9
            nums.Add(i)
        Next
        RandomOrder(nums)
        Button1.Text = nums.Item(0)
        Button2.Text = nums.Item(1)
        Button3.Text = nums.Item(2)
        Button4.Text = nums.Item(3)
        Button5.Text = nums.Item(4)
        Button6.Text = nums.Item(5)
        Button7.Text = nums.Item(6)
        Button8.Text = nums.Item(7)
        Button9.Text = nums.Item(8)
    End Sub

    Private Sub RandomOrder(items As ArrayList)
        Dim r As New Random
        For counter As Integer = 0 To items.Count - 1
            Dim temp As Object
            Dim target As Integer
            target = r.Next(items.Count - counter) + counter
            temp = items.Item(counter)
            items.Item(counter) = items.Item(target)
            items.Item(target) = temp
        Next
    End Sub

End Class
