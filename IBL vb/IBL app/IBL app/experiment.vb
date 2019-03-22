Public Class experiment
    ' Use this Random object to choose random icons for the squares
    
    Private random As New Random

    ' Each of these letters is an interesting icon
    ' in the Webdings font,
    ' and each icon appears twice in this list
    Private icons= New List(Of String) From {"ker", "ker", "Nee", "Nee", ",!", ",!", "kk", "kk", "bs", "bs", "vaa", "vaa", "wez", "wez", "zez", "zez"}

    End Sub

    ''' <summary>
    ''' Assign each icon from the list of icons to a random square
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AssignIconsToSquares()

        ' The TableLayoutPanel has 16 labels,
        ' and the icon list has 16 icons,
        ' so an icon is pulled at random from the list
        ' and added to each label
        For Each control In TableLayoutPanel1.Controls
            ' The statements you want to execute 
            ' for each label go here
            ' The statements use iconLabel to access 
            ' each label's properties and methods
        Next
        Dim iconLabel = TryCast(Control, Label)
        If iconLabel IsNot Nothing Then
            Dim randomNumber = random.Next(icons.Count)
            iconLabel.Text = icons(randomNumber)
            ' iconLabel.ForeColor = iconLabel.BackColor
            icons.RemoveAt(randomNumber)
        End If
        Next

    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        AssignIconsToSquares()
    End Sub
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub
End Class