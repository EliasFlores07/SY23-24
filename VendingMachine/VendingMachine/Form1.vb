﻿Public Class Form1
    Dim WithEvents CS As New CoinSlot

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CS.insertQuarters()
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CS.insertDollars()
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CS.insertDimes()
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CS.insertNickles()
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CS.coinreturn()
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub CS_CoinReturnEvent(d As Integer, q As Integer, dm As Integer, n As Integer) Handles CS.CoinReturnEvent
        If d > 0 Then
            DollarPictureBox.Visible = True
        Else
            DollarPictureBox.Visible = False
        End If

        If q > 0 Then
            QuarterPictureBox.Visible = True
        Else
            QuarterPictureBox.Visible = False
        End If

        If dm > 0 Then
            DimePictureBox.Visible = True
        Else
            DimePictureBox.Visible = False
        End If

        If n > 0 Then
            NicklePictureBox.Visible = True
        Else
            NicklePictureBox.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case IDTextBox.Text

            Case ProductControl1.ProductID
                CS.Buy(ProductControl1)

            Case ProductControl2.ProductID
                CS.Buy(ProductControl2)

            Case ProductControl3.ProductID
                CS.Buy(ProductControl3)

            Case ProductControl4.ProductID
                CS.Buy(ProductControl4)

            Case ProductControl5.ProductID
                CS.Buy(ProductControl5)

            Case ProductControl6.ProductID
                CS.Buy(ProductControl6)

            Case ProductControl7.ProductID
                CS.Buy(ProductControl7)

            Case ProductControl8.ProductID
                CS.Buy(ProductControl8)

            Case ProductControl9.ProductID
                CS.Buy(ProductControl9)

            Case ProductControl10.ProductID
                CS.Buy(ProductControl10)

            Case ProductControl11.ProductID
                CS.Buy(ProductControl11)

            Case ProductControl12.ProductID
                CS.Buy(ProductControl12)

            Case ProductControl13.ProductID
                CS.Buy(ProductControl13)

            Case ProductControl14.ProductID
                CS.Buy(ProductControl14)

            Case ProductControl15.ProductID
                CS.Buy(ProductControl15)

            Case ProductControl16.ProductID
                CS.Buy(ProductControl16)

            Case Else

        End Select
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub CS_Dispense(P As Image) Handles CS.Dispense
        ProductPictureBox.Image = P
    End Sub
End Class
