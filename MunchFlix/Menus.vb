Public Class frmMenus
    Private Sub frmMenus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstOptions.Items.Add("Drinks")
        lstOptions.Items.Add("Appetizers")
        lstOptions.Items.Add("Main Meal")
        lstOptions.Items.Add("Dessert")

        If frmMainMenu.blnDrinks = True Then
            lstOptions.SelectedItem = 0
        ElseIf frmMainMenu.blnAppetizers = True Then
            lstOptions.SelectedItem = 1
        ElseIf frmMainMenu.blnMainMeal = True Then
            lstOptions.SelectedItem = 2
        ElseIf frmMainMenu.blnDessert = True Then
            lstOptions.SelectedItem = 3
        Else
            lstOptions.Items.Add("More")
        End If


    End Sub


End Class