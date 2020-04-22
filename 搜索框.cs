using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registry_edit
{
    public partial class 搜索框 : Form
    {
        private string _pathDefault;
        private string _keysDefault;
        public string Path;
        public string Keys;
        public 搜索框()
        {
            InitializeComponent();
        }
        public 搜索框(string PathDefault,string KeysDefault)
        {
            InitializeComponent();
            this.PathDefault = PathDefault;
            this.KeysDefault = KeysDefault;
        }
        public string PathDefault { get => _pathDefault; set { _pathDefault = value; this.textBoxPath.Text = _pathDefault; } }
        public string KeysDefault { get => _keysDefault; set { _keysDefault = value; this.textBoxKeys.Text = _keysDefault; } }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!this.textBoxPath.Text.Equals("") && !this.textBoxKeys.Text.Equals(""))
            {
                Path = this.textBoxPath.Text;
                Keys = this.textBoxKeys.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("请输入Path或Keys");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBoxPath_Enter(object sender, EventArgs e)
        {
            textBoxPath.Text = "";
            textBoxPath.ForeColor =Color.Black;
        }

        private void textBoxKeys_Enter(object sender, EventArgs e)
        {
            textBoxKeys.Text = "";
            textBoxKeys.ForeColor = Color.Black;
        }
    }
}
