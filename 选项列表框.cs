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



    public partial class 选项列表框 : UserControl
    {
        //传入的数据项是列表,列表中的值是 选项列表的状态 这个结构的集合.
        private MyList<选项列表的状态> _Field= new MyList<选项列表的状态>();
        private const int 选项列表默认高度 = 50;

        public 选项列表框()
        {
            InitializeComponent();
            _Field.Plot = this.Draw;//MyList实例调用AddRange时触发的事件(根据列表元素数量,绘制相同数量的控件).
        }

        [Browsable(false)]//不显示在属性编辑面板里
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]//代码生成器不自动生成代码
        //Field是注册表中右键的注册表项,选项列表框的 选项列表 控件 根据此属性绘制相对应的个数.但绘制控件的不是根据Field属性实时更新的
        public MyList<选项列表的状态> Field
        {
            set
            {
                _Field = value;
                this.Draw(_Field);//赋值时,列表中有多项,就生成多少个 选项列表 (list.Add或list.AddRange无法触发)
            }
            get
            {
                return _Field;
            }
        }
        protected  void Draw(List<选项列表的状态> e)
        {//将选项列表的属性赋值,并绘制选项列表.
            选项列表 Tmp;
            for (int i = 0; i < e.Count; i++) {
                Tmp = new 选项列表(e[i].title,e[i].state);
                Tmp.Size = new Size(this.Size.Width-20, 选项列表默认高度);//生成的 选项列表 宽度为 选项列表框的宽度-20(右侧滑动条宽度)  这样不会出现底侧的滑动条
                Tmp.Location = new Point(0,i* 选项列表默认高度);//生成的 选项列表 在 选项列表框 的左上角,x=0 y=i*50
                Tmp.OpenOrClose += new EventHandler(e[i].OpenOrClose);
                Tmp.RegKey = e[i].RegKey;
                this.Controls.Add(Tmp);
            }
            
        }

        public object LocationIndex(MouseEventArgs e)
        {
            MessageBox.Show(e.Location.ToString());
            return this;
        }

        private void 选项列表框_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//左键根据位置,使选项列表底色变色
            {
                LocationIndex(e);
            }
            else if (e.Button == MouseButtons.Right)//右键根据位置 弹出关联菜单
            {
                LocationIndex(e);
            }
        }
    }
}
