using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;

namespace TokenEditCustomDropDown {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            CustomDropDown dropDownGallery = new CustomDropDown();
            tokenEdit1.Properties.CustomDropDownControl = new CustomDropDown();
        }

        private void tokenEdit1_ValidateToken(object sender, DevExpress.XtraEditors.TokenEditValidateTokenEventArgs e) {
            e.IsValid = true;
        }
    }
}
