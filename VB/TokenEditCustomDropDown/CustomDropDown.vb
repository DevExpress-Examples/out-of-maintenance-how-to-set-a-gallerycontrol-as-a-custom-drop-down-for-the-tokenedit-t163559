Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Ribbon

Namespace TokenEditCustomDropDown
    Partial Public Class CustomDropDown
        Inherits CustomTokenEditDropDownControlBase

        Private tokenList As New List(Of TokenEditToken)()
        Private clickedItem As GalleryItem

        Public Sub New()
            InitializeComponent()
            customGallery1.Gallery.ShowItemText = True
            AddHandler customGallery1.Gallery.ItemClick, AddressOf Gallery_ItemClick
        End Sub

        Private Sub Gallery_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs)
            clickedItem = e.Item
            If TryCast(OwnerEdit, TokenEdit).EditValue IsNot Nothing AndAlso TryCast(OwnerEdit, TokenEdit).EditValue.ToString().Contains(e.Item.Description) Then
                Return
            End If
            Me.OwnerEdit.ClosePopup(PopupCloseMode.Normal)
        End Sub

        Public Overrides Function GetItemCount() As Integer
            Return tokenList.Count
        End Function

        Public Overrides Sub SetDataSource(ByVal dataSource As Object)
            If customGallery1.Gallery.Groups(0).Items.Count <> 10 Then
                createData()
            End If
        End Sub

        Public Overrides Function CalcFormHeight(ByVal itemCount As Integer) As Integer
            Return 130
        End Function

        Public Overrides Function CalcFormWidth() As Integer
            Return MyBase.CalcFormWidth()
        End Function

        Public Overrides Function GetResultValue() As Object
            Dim index As Integer = customGallery1.Gallery.Groups(0).Items.IndexOf(clickedItem)
            Return tokenList(index)
        End Function

        Public Function createData() As IEnumerable(Of TokenEditToken)
            For i As Integer = 0 To 9
                tokenList.Add(New TokenEditToken("Token " & i.ToString(), "Token " & i.ToString()))
                customGallery1.Gallery.Groups(0).Items.Add(New GalleryItem(imageCollection1.Images(i), tokenList(i).Description, tokenList(i).Description))
            Next i
            Return tokenList
        End Function
    End Class

    <ToolboxItem(True)> _
    Public Class customGallery
        Inherits GalleryControl

        Public Sub New()
            'SetStyle(ControlStyles.UserMouse, false);
        End Sub
        Protected Overrides ReadOnly Property AllowFocus() As Boolean
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
