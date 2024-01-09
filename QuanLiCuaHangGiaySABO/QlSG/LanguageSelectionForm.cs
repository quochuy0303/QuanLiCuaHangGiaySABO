using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCuaHangGiaySABO.QlSG
{
    public partial class LanguageSelectionForm : DevExpress.XtraEditors.XtraForm
    {
        public LanguageSelectionForm()
        {
            InitializeComponent();
            InitializeComboBox();
        }
        private void InitializeComboBox()
        {
            // Thêm các ngôn ngữ bạn hỗ trợ vào ComboBox
            comboBoxEdit1.Properties.Items.Add("Tiếng Việt");
            comboBoxEdit1.Properties.Items.Add("English");

            // Chọn ngôn ngữ mặc định (có thể là ngôn ngữ hiện tại của ứng dụng)
            comboBoxEdit1.SelectedItem = GetLanguageName(LanguageManager.GetCurrentCultureName());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GetLanguageCode(comboBoxEdit1.SelectedItem.ToString());
            LanguageManager.Initialize(new CultureInfo(selectedLanguage));
            DialogResult = DialogResult.OK;
            Close();
        }
        private string GetLanguageCode(string languageName)
        {
            switch (languageName)
            {
                case "Tiếng Việt":
                    return "vi-VN";
                case "English":
                    return "en-US";
                // Thêm các ngôn ngữ khác nếu cần
                default:
                    return "en-US"; // Ngôn ngữ mặc định
            }
        }

        private string GetLanguageName(string languageCode)
        {
            switch (languageCode)
            {
                case "vi-VN":
                    return "Tiếng Việt";
                case "en-US":
                    return "English";
                // Thêm các ngôn ngữ khác nếu cần
                default:
                    return "English"; // Ngôn ngữ mặc định
            }
        }
    }

       
}
