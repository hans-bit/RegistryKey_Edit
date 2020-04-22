using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace registry_edit
{
    public partial class 选项列表 : UserControl
    {
        private string _Title;
        private bool _State;
        private RegistryKey _RegKey;
        public 选项列表()
        {
            InitializeComponent();
            Title = "无";
            State = true;
        }

        public 选项列表(string title,bool state)
        {
            InitializeComponent();
            Title = title;
            State = state;
        }

        public string Title {
            set 
            {
                _Title = value;
                this.label1.Text = _Title;
            }
            get { return _Title; }
        }

        public bool State
        {
            set
            {
                _State = value;
                if(_State)
                    this.label2.Image = registry_edit.Properties.Resources.打开;
                else
                    this.label2.Image = registry_edit.Properties.Resources.关闭;
            }
            get { return _State; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]//设计器不会自动赋值
        public RegistryKey RegKey {
            set { _RegKey = value; }
            get { return _RegKey; }
        }


        public event EventHandler OpenOrClose;
        private void label2_Click(object sender, EventArgs e)
        {
            OpenOrClose?.Invoke(this, e);//不传入当前控件的对象,直接传入自定义控件的对象,方便事件延迟绑定时访问成员变量

        }

    }
}
