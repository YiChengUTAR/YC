Public Class Containers
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        Panel1.Visible = CheckBox1.Checked
    End Sub

    Protected Sub Wizard1_FinishButtonClick(sender As Object, e As WizardNavigationEventArgs) Handles Wizard1.FinishButtonClick
        Result.Text = "Your name is: " & YourName.Text
        Result.Text &= "<br /> Your Favorite Language is: " & FavoriteLanguage.SelectedValue
    End Sub
End Class