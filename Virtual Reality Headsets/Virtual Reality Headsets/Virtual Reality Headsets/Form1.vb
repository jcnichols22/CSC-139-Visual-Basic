' Program Name: Virtual Reality Headset
' Developer:    Josh Nichols
' Date:         1/21/2022
' Purpose:      This application allows the user to select between
'               different types of VR Headsets to view them then is able to exit the program.
Public Class frmVRForward
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This section gives the command to the Exit button to close the program. 
        Close()

    End Sub

    Private Sub btnVRCrown_Click(sender As Object, e As EventArgs) Handles btnVRCrown.Click
        ' This block will tell the VR Crown button to show the VR Crow image, hide the VR Earbud image and enable the exit button.
        picVRCrown.Visible = True
        picVREarbud.Visible = False
        btnExit.Enabled = True


    End Sub

    Private Sub btnVREarbud_Click(sender As Object, e As EventArgs) Handles btnVREarbud.Click
        ' This blobk will tell the VR Earbud image to show and will aslo hide the VR Crown image and enable the exit button.
        picVRCrown.Visible = False
        picVREarbud.Visible = True
        btnExit.Enabled = True
    End Sub
End Class
