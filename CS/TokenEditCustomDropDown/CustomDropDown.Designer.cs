namespace TokenEditCustomDropDown {
    partial class CustomDropDown {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDropDown));
            this.customGallery1 = new TokenEditCustomDropDown.customGallery();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customGallery1)).BeginInit();
            this.customGallery1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // customGallery1
            // 
            this.customGallery1.Controls.Add(this.galleryControlClient1);
            this.customGallery1.DesignGalleryGroupIndex = 0;
            this.customGallery1.DesignGalleryItemIndex = 0;
            this.customGallery1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // galleryControlGallery1
            // 
            galleryItemGroup1.Caption = "Click an item to select it";
            galleryItemGroup1.CaptionAlignment = DevExpress.XtraBars.Ribbon.GalleryItemGroupCaptionAlignment.Center;
            this.customGallery1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.customGallery1.Gallery.HoverImageSize = new System.Drawing.Size(32, 32);
            this.customGallery1.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.customGallery1.Gallery.ShowItemText = true;
            this.customGallery1.Location = new System.Drawing.Point(0, 0);
            this.customGallery1.Name = "customGallery1";
            this.customGallery1.Size = new System.Drawing.Size(353, 186);
            this.customGallery1.TabIndex = 0;
            this.customGallery1.Text = "customGallery1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.customGallery1;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(332, 182);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("apply_32x32.png", "images/actions/apply_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_32x32.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "apply_32x32.png");
            this.imageCollection1.InsertGalleryImage("close_32x32.png", "images/actions/close_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/close_32x32.png"), 1);
            this.imageCollection1.Images.SetKeyName(1, "close_32x32.png");
            this.imageCollection1.InsertGalleryImage("show_32x32.png", "images/actions/show_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/show_32x32.png"), 2);
            this.imageCollection1.Images.SetKeyName(2, "show_32x32.png");
            this.imageCollection1.InsertGalleryImage("bubble_32x32.png", "images/chart/bubble_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/bubble_32x32.png"), 3);
            this.imageCollection1.Images.SetKeyName(3, "bubble_32x32.png");
            this.imageCollection1.InsertGalleryImage("pie_32x32.png", "images/chart/pie_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/pie_32x32.png"), 4);
            this.imageCollection1.Images.SetKeyName(4, "pie_32x32.png");
            this.imageCollection1.InsertGalleryImage("image_32x32.png", "images/content/image_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/content/image_32x32.png"), 5);
            this.imageCollection1.Images.SetKeyName(5, "image_32x32.png");
            this.imageCollection1.InsertGalleryImage("find_32x32.png", "images/find/find_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/find/find_32x32.png"), 6);
            this.imageCollection1.Images.SetKeyName(6, "find_32x32.png");
            this.imageCollection1.InsertGalleryImage("gaugestylefullcircular_32x32.png", "images/gauges/gaugestylefullcircular_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/gauges/gaugestylefullcircular_32x32.png"), 7);
            this.imageCollection1.Images.SetKeyName(7, "gaugestylefullcircular_32x32.png");
            this.imageCollection1.InsertGalleryImage("announcement_32x32.png", "images/mail/announcement_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/announcement_32x32.png"), 8);
            this.imageCollection1.Images.SetKeyName(8, "announcement_32x32.png");
            this.imageCollection1.InsertGalleryImage("attachment_32x32.png", "images/mail/attachment_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/attachment_32x32.png"), 9);
            this.imageCollection1.Images.SetKeyName(9, "attachment_32x32.png");
            // 
            // CustomDropDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customGallery1);
            this.Name = "CustomDropDown";
            this.Size = new System.Drawing.Size(353, 186);
            ((System.ComponentModel.ISupportInitialize)(this.customGallery1)).EndInit();
            this.customGallery1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private customGallery customGallery1;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private DevExpress.Utils.ImageCollection imageCollection1;


    }
}
