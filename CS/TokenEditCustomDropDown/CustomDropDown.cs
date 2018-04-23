using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;

namespace TokenEditCustomDropDown {
    public partial class CustomDropDown : CustomTokenEditDropDownControlBase  {

        List<TokenEditToken> tokenList = new List<TokenEditToken>();
        GalleryItem clickedItem;

        public CustomDropDown() {
            InitializeComponent();
            customGallery1.Gallery.ShowItemText = true;
            customGallery1.Gallery.ItemClick += Gallery_ItemClick;
        }

        void Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e) {
            clickedItem = e.Item;
            if ((OwnerEdit as TokenEdit).EditValue != null && (OwnerEdit as TokenEdit).EditValue.ToString().Contains(e.Item.Description))
                return;
            this.OwnerEdit.ClosePopup(PopupCloseMode.Normal);
        }

        public override int GetItemCount() {
            return tokenList.Count;
        }

        public override void SetDataSource(object dataSource) {
            if (customGallery1.Gallery.Groups[0].Items.Count != 10) createData();
        }

        public override int CalcFormHeight(int itemCount) {
            return 130;
        }

        public override int CalcFormWidth() {
            return base.CalcFormWidth();
        }

        public override object GetResultValue() {
            int index = customGallery1.Gallery.Groups[0].Items.IndexOf(clickedItem);
            return tokenList[index];
        }

        public IEnumerable<TokenEditToken> createData() {
            for (int i = 0; i < 10; i++) {
                tokenList.Add(new TokenEditToken("Token " + i.ToString(), "Token " + i.ToString()));
                customGallery1.Gallery.Groups[0].Items.Add(new GalleryItem(imageCollection1.Images[i], tokenList[i].Description, tokenList[i].Description));
            }
            return tokenList;
        }
    }

    [ToolboxItem(true)]
    public class customGallery : GalleryControl {
        public customGallery() {
            //SetStyle(ControlStyles.UserMouse, false);
        }
        protected override bool AllowFocus {
            get {
                return false;
            }
        }
    }
}
