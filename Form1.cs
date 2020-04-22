using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading;

namespace registry_edit
{
    public partial class Form1 : Form
    {
        private const string DesktopBackground = @"\HKEY_LOCAL_MACHINE\SOFTWARE\Classes\DesktopBackground\Shell\"; //桌面关联菜单
        private const string Directory = @"\HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Directory\shell\"; //文件夹关联菜单
        private const string DirectoryBackground = @"\HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Directory\Background\shell\";//文件夹空白处关联菜单
        private const string Drive = @"\HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Drive\shell\";//盘符关联菜单
        private string[] reg_key = { "MUIVerb", "Icon" , "Subcommands" };
        private const int time = 30;//横幅移动速度 每timer Location.X减1
        public Form1()
        {
            InitializeComponent();
            Flush();
            timer1.Interval = time;
        }

        private void Flush()//刷新一次
        {
            this.选项列表框1.Controls.Clear();
            this.选项列表框2.Controls.Clear();
            this.选项列表框3.Controls.Clear();
            this.选项列表框4.Controls.Clear();
            
            this.选项列表框1.Field.Clear();
            this.选项列表框2.Field.Clear();
            this.选项列表框3.Field.Clear();
            this.选项列表框4.Field.Clear();

            this.选项列表框1.Field.AddRange(Search(DesktopBackground, reg_key));//桌面右键菜单列表
            this.选项列表框2.Field.AddRange(Search(Directory, reg_key));//文件夹右键菜单列表
            this.选项列表框3.Field.AddRange(Search(DirectoryBackground, reg_key));//文件夹空白处右键菜单列表
            this.选项列表框4.Field.AddRange(Search(Drive, reg_key));//盘符右键菜单列表
        }

        private List<选项列表的状态> Search(string path, string[] reg_key) {
            //参数1为搜索的注册表路径.
            //参数2为特征键集合,一般关联菜单都有这些键.
            List<RegistryKey>  reg=RegEdit.Context_meun(RegEdit.Reg_edit(path,false), reg_key);
            选项列表的状态 tmp=new 选项列表的状态();
            List<选项列表的状态> Field=new List<选项列表的状态>();
            for (int i = 0; i < reg.Count; i++)
            {
                if (reg[i].GetValue("MUIVerb") != null)
                    tmp.title = reg[i].GetValue("MUIVerb").ToString();
                else if (reg[i].GetValue("") != null)
                    tmp.title = reg[i].GetValue("").ToString();
                else
                    tmp.title = reg[i].Name.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).Last();
                tmp.state = true;//刷新时永远为真
                tmp.OpenOrClose = new EventHandler(this.Process);
                tmp.RegKey = reg[i];
                Field.Add(tmp);
            }
            return Field;
        }

        private void Process(object sender,EventArgs e)//点击启用或者禁用的处理函数
        { 
            选项列表 tmp = (选项列表)sender;
            if (tmp.State)
            {
                if (RegEdit.MyDeleteSubKeyTree(tmp.RegKey)) { //删除此tmp的注册表路径
                    tmp.State = !tmp.State;
                }
                else {
                    MessageBox.Show("删除失败!","Warning:",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("①必须以管理员权限打开!\n\n②删除无法恢复, 请备份注册表后谨慎操作!\n\n③桌面右键菜单可能与文件夹空白处右键菜单相同\n\n2020年03月31日21: 33:09制作");
        }

        private void 网页版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.jiying180102.cn/");//打开默认浏览器并进入指定网址
        }


        private void 搜索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            搜索框 搜索框1 = new 搜索框(@"HKEY_LOCAL_MACHINE\SOFTWARE\Classes\*\shell\", "Icon");
            DialogResult Result =搜索框1.ShowDialog();
            if (Result == DialogResult.OK)
            {
                清空ToolStripMenuItem_Click(sender,e);
                //Path去掉前后空白字符,Keys用','分割并且抛弃空白字符
                this.选项列表框5.Field.AddRange(Search(搜索框1.Path.Trim(), 搜索框1.Keys.Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries)));//自定义搜索路径和特征Key

            }
            搜索框1.Dispose();

        }


        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            搜索框 搜索框1 = new 搜索框(@"HKEY_LOCAL_MACHINE\SOFTWARE\Classes\*\shell\","Icon");
            DialogResult Result = 搜索框1.ShowDialog();
            if (Result == DialogResult.OK)
            {
                //添加搜索不用清空ToolStripMenuItem;
                //Path去掉前后空白字符,Keys用','分割并且抛弃空白字符
                this.选项列表框5.Field.AddRange(Search(搜索框1.Path.Trim(), 搜索框1.Keys.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)));//自定义搜索路径和特征Key

            }
            搜索框1.Dispose();
        }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.选项列表框5.Controls.Clear();
            this.选项列表框5.Field.Clear();
        }


        private void 刷新F5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flush();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }



        private void 置顶ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (置顶ToolStripMenuItem.Text.Equals("置顶")) {
                this.TopMost = true;
                置顶ToolStripMenuItem.Text = "取消置顶";
            }
            else {
                this.TopMost = false;
                置顶ToolStripMenuItem.Text = "置顶";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hover();
        }

        private void Hover()
        {//横幅移动方法 
         //label的位置是相对与panel面板的
            if ((banner.Location.X + banner.Size.Width) > 0)
            {
                banner.Location = new Point(banner.Location.X - 1, banner.Location.Y);
            }
            else
            {
                banner.Location = new Point(main_panel.Size.Width, banner.Location.Y);
            }
        }

        private void main_panel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("①必须以管理员权限打开!\n\n②删除无法恢复,请备份注册表后谨慎操作!\n\n③桌面右键菜单可能与文件夹空白处右键菜单相同\n\n2020年04月18日00:27:32制作");
        }
    }
}
