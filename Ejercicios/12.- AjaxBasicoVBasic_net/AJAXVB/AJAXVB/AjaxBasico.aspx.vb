Public Class AjaxBasico
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        resultado.Text = Convert.ToInt32(a.Text) + Convert.ToInt32(b.Text)



    End Sub
End Class