Imports Microsoft.VisualBasic
Imports System.Drawing.Drawing2D
Public Class Class1
    Inherits Button
    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint, True)
    End Sub

    Protected Overrides Sub OnPaint(prevent As PaintEventArgs)
        MyBase.OnPaint(prevent)
        Dim g As Graphicspath = New Graphicspath()
        g.AddEllipse(0, 0, Clientsize.Width, ClientSize.Height)
        Me.Region = New Region(g)
    End Sub
End Class
