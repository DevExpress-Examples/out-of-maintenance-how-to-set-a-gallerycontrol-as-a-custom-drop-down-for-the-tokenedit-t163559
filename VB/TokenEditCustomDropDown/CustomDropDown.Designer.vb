Namespace TokenEditCustomDropDown
    Partial Public Class CustomDropDown
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CustomDropDown))
            Me.customGallery1 = New TokenEditCustomDropDown.customGallery()
            Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            DirectCast(Me.customGallery1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.customGallery1.SuspendLayout()
            DirectCast(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' customGallery1
            ' 
            Me.customGallery1.Controls.Add(Me.galleryControlClient1)
            Me.customGallery1.DesignGalleryGroupIndex = 0
            Me.customGallery1.DesignGalleryItemIndex = 0
            Me.customGallery1.Dock = System.Windows.Forms.DockStyle.Fill
            ' 
            ' galleryControlGallery1
            ' 
            galleryItemGroup1.Caption = "Click an item to select it"
            galleryItemGroup1.CaptionAlignment = DevExpress.XtraBars.Ribbon.GalleryItemGroupCaptionAlignment.Center
            Me.customGallery1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
            Me.customGallery1.Gallery.HoverImageSize = New System.Drawing.Size(32, 32)
            Me.customGallery1.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.customGallery1.Gallery.ShowItemText = True
            Me.customGallery1.Location = New System.Drawing.Point(0, 0)
            Me.customGallery1.Name = "customGallery1"
            Me.customGallery1.Size = New System.Drawing.Size(353, 186)
            Me.customGallery1.TabIndex = 0
            Me.customGallery1.Text = "customGallery1"
            ' 
            ' galleryControlClient1
            ' 
            Me.galleryControlClient1.GalleryControl = Me.customGallery1
            Me.galleryControlClient1.Location = New System.Drawing.Point(2, 2)
            Me.galleryControlClient1.Size = New System.Drawing.Size(332, 182)
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageSize = New System.Drawing.Size(32, 32)
            Me.imageCollection1.ImageStream = (DirectCast(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.imageCollection1.InsertGalleryImage("apply_32x32.png", "images/actions/apply_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_32x32.png"), 0)
            Me.imageCollection1.Images.SetKeyName(0, "apply_32x32.png")
            Me.imageCollection1.InsertGalleryImage("close_32x32.png", "images/actions/close_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/close_32x32.png"), 1)
            Me.imageCollection1.Images.SetKeyName(1, "close_32x32.png")
            Me.imageCollection1.InsertGalleryImage("show_32x32.png", "images/actions/show_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/show_32x32.png"), 2)
            Me.imageCollection1.Images.SetKeyName(2, "show_32x32.png")
            Me.imageCollection1.InsertGalleryImage("bubble_32x32.png", "images/chart/bubble_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/bubble_32x32.png"), 3)
            Me.imageCollection1.Images.SetKeyName(3, "bubble_32x32.png")
            Me.imageCollection1.InsertGalleryImage("pie_32x32.png", "images/chart/pie_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/pie_32x32.png"), 4)
            Me.imageCollection1.Images.SetKeyName(4, "pie_32x32.png")
            Me.imageCollection1.InsertGalleryImage("image_32x32.png", "images/content/image_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/content/image_32x32.png"), 5)
            Me.imageCollection1.Images.SetKeyName(5, "image_32x32.png")
            Me.imageCollection1.InsertGalleryImage("find_32x32.png", "images/find/find_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/find/find_32x32.png"), 6)
            Me.imageCollection1.Images.SetKeyName(6, "find_32x32.png")
            Me.imageCollection1.InsertGalleryImage("gaugestylefullcircular_32x32.png", "images/gauges/gaugestylefullcircular_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/gauges/gaugestylefullcircular_32x32.png"), 7)
            Me.imageCollection1.Images.SetKeyName(7, "gaugestylefullcircular_32x32.png")
            Me.imageCollection1.InsertGalleryImage("announcement_32x32.png", "images/mail/announcement_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/announcement_32x32.png"), 8)
            Me.imageCollection1.Images.SetKeyName(8, "announcement_32x32.png")
            Me.imageCollection1.InsertGalleryImage("attachment_32x32.png", "images/mail/attachment_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/attachment_32x32.png"), 9)
            Me.imageCollection1.Images.SetKeyName(9, "attachment_32x32.png")
            ' 
            ' CustomDropDown
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.customGallery1)
            Me.Name = "CustomDropDown"
            Me.Size = New System.Drawing.Size(353, 186)
            DirectCast(Me.customGallery1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.customGallery1.ResumeLayout(False)
            DirectCast(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private customGallery1 As customGallery
        Private galleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
        Private imageCollection1 As DevExpress.Utils.ImageCollection


    End Class
End Namespace
