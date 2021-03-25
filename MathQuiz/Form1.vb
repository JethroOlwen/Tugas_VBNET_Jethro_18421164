Public Class Form1
    Dim counter As Integer
    Dim add_a, add_b, sub_a, sub_b, mtp_a, mtp_b, div_a, div_b, add, subs, mtp, div As Double

    Private Sub divC_ValueChanged(sender As Object, e As EventArgs) Handles divC.ValueChanged
        If (jawaban()) Then
            Timer1.Stop()
            MessageBox.Show("You got all the answers right!", "congratulation!")
            Button1.Enabled = True
        End If
    End Sub

    Private Sub mtpC_ValueChanged(sender As Object, e As EventArgs) Handles mtpC.ValueChanged
        If (jawaban()) Then
            Timer1.Stop()
            MessageBox.Show("You got all the answers right!", "congratulation!")
            Button1.Enabled = True
        End If
    End Sub

    Private Sub subC_ValueChanged(sender As Object, e As EventArgs) Handles subC.ValueChanged
        If (jawaban()) Then
            Timer1.Stop()
            MessageBox.Show("You got all the answers right!", "congratulation!")
            Button1.Enabled = True
        End If
    End Sub

    Private Sub timeTick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter = counter - 1
        Dim count As String
        count = counter
        TextBox1.Text = count + " seconds"
        If counter = 0 Then
            Timer1.Stop()
            addC.Value = add
            subC.Value = subs
            mtpC.Value = mtp
            divC.Value = div
            MessageBox.Show("You failed to answer all of the questions", "fail")

            Button1.Enabled = True
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = counter
        Timer1.Interval = 1000
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        counter = 60
        addA.Text = getRandom()
        addB.Text = getRandom()
        subA.Text = getRandom()
        subB.Text = getRandom()
        mtpA.Text = getRandom()
        mtpB.Text = getRandom()
        divA.Text = getRandom()
        divB.Text = getRandom()
        addC.Value = 0
        subC.Value = 0
        mtpC.Value = 0
        divC.Value = 0
        Timer1.Start()
        Button1.Enabled = False
    End Sub


    Private Function getRandom()
        Dim minNum As Integer = 1
        Dim maxNum As Integer = 100
        Dim generator As New Random(System.DateTime.Now.Millisecond)
        Return generator.Next(minNum, maxNum + 1)
    End Function

    Private Function jawaban()
        add_a = addA.Text
        add_b = addB.Text
        sub_a = subA.Text
        sub_b = subB.Text
        mtp_a = mtpA.Text
        mtp_b = mtpB.Text
        div_a = divA.Text
        div_b = divB.Text
        add = add_a + add_b
        subs = sub_a - sub_b
        mtp = mtp_a * mtp_b
        div = div_a / div_b

        If (addC.Value = add) Then
            If (subC.Value = subs) Then
                If (mtpC.Value = mtp) Then
                    If (divC.Value = div) Then
                        Return True
                    End If
                    Return False
                End If
                Return False
            End If
            Return False
        Else
            Return False
        End If
    End Function

    Private Sub addC_ValueChanged(sender As Object, e As EventArgs) Handles addC.ValueChanged
        If (jawaban()) Then
            Timer1.Stop()
            MessageBox.Show("You got all the answers right!", "congratulation!")
            Button1.Enabled = True
        End If
    End Sub
End Class
