Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList

Namespace TokenEditCustomDropDown
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            Dim dropDownGallery As New CustomDropDown()
            tokenEdit1.Properties.CustomDropDownControl = New CustomDropDown()
        End Sub

        Private Sub tokenEdit1_ValidateToken(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.TokenEditValidateTokenEventArgs) Handles tokenEdit1.ValidateToken
            e.IsValid = True
        End Sub
    End Class
End Namespace
