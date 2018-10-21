using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace QLKSdemo1
{
    public partial class MenuAnUong : MetroForm
    {
        public MenuAnUong()
        {
            InitializeComponent();
        }

        private int yeuCauSang = 0;

        public int YeuCauSang
        {
            get { return yeuCauSang; }
            set { yeuCauSang = value; }
        }

        private int yeuCauTrua = 0;

        public int YeuCauTrua
        {
            get { return yeuCauTrua; }
            set { yeuCauTrua = value; }
        }

        private int yeuCauToi = 0;

        public int YeuCauToi
        {
            get { return yeuCauToi; }
            set { yeuCauToi = value; }
        }

        private string yeuCauDon = "";

        public string YeuCauDon
        {
            get { return yeuCauDon; }
            set { yeuCauDon = value; }
        }
        private string yeuCauHanhLy = "";

        public string YeuCauHanhLy
        {
            get { return yeuCauHanhLy; }
            set { yeuCauHanhLy = value; }
        }

        private string yeuCauMatXa = "";

        public string YeuCauMatXa
        {
            get { return yeuCauMatXa; }
            set { yeuCauMatXa = value; }
        }

        private void NutNext_Click(object sender, EventArgs e)
        {
            if (SangCheckBox.Checked)
            {
                yeuCauSang = Convert.ToInt32(SangTextBox.Text);
            }
            if (TruaCheckBox.Checked)
            {
                yeuCauTrua = Convert.ToInt32(TruaTextBox.Text);
            }
            if (ToiCheckBox.Checked)
            {
                yeuCauToi = Convert.ToInt32(ToiTextBox.Text);
            }
            if (DonCheckBox.Checked)
            {
                yeuCauDon = DonCheckBox.Text;
            }
            if (HanhLyCheckBox.Checked)
            {
                yeuCauHanhLy = HanhLyCheckBox.Text;
            }
            if (MatXaCheckBox.Checked)
            {
                yeuCauMatXa = MatXaCheckBox.Text;
            }

            this.Hide();
        }

        private void SangCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(SangCheckBox.Checked)
            {
                SangTextBox.Enabled = true;
            }
        }

        private void TruaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TruaCheckBox.Checked)
            {
                TruaTextBox.Enabled = true;
            }
        }

        private void ToiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ToiCheckBox.Checked)
            {
                ToiTextBox.Enabled = true;
            }
        }
    }
}
