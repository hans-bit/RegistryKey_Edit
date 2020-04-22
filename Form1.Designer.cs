using System.Collections.Generic;

namespace registry_edit
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新F5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.网页版ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.置顶ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义检索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dial = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.备份ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.banner = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.选项列表框1 = new registry_edit.选项列表框();
            this.选项列表框2 = new registry_edit.选项列表框();
            this.选项列表框3 = new registry_edit.选项列表框();
            this.选项列表框4 = new registry_edit.选项列表框();
            this.选项列表框5 = new registry_edit.选项列表框();
            this.menuStrip1.SuspendLayout();
            this.Dial.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选项ToolStripMenuItem,
            this.自定义检索ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新F5ToolStripMenuItem,
            this.网页版ToolStripMenuItem,
            this.置顶ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.选项ToolStripMenuItem.Text = "选项";
            // 
            // 刷新F5ToolStripMenuItem
            // 
            this.刷新F5ToolStripMenuItem.Name = "刷新F5ToolStripMenuItem";
            this.刷新F5ToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.刷新F5ToolStripMenuItem.Text = "刷新(F5)";
            this.刷新F5ToolStripMenuItem.Click += new System.EventHandler(this.刷新F5ToolStripMenuItem_Click);
            // 
            // 网页版ToolStripMenuItem
            // 
            this.网页版ToolStripMenuItem.Name = "网页版ToolStripMenuItem";
            this.网页版ToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.网页版ToolStripMenuItem.Text = "网页版";
            this.网页版ToolStripMenuItem.Click += new System.EventHandler(this.网页版ToolStripMenuItem_Click);
            // 
            // 置顶ToolStripMenuItem
            // 
            this.置顶ToolStripMenuItem.Name = "置顶ToolStripMenuItem";
            this.置顶ToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.置顶ToolStripMenuItem.Text = "置顶";
            this.置顶ToolStripMenuItem.Click += new System.EventHandler(this.置顶ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 自定义检索ToolStripMenuItem
            // 
            this.自定义检索ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.搜索ToolStripMenuItem,
            this.添加ToolStripMenuItem,
            this.清空ToolStripMenuItem});
            this.自定义检索ToolStripMenuItem.Name = "自定义检索ToolStripMenuItem";
            this.自定义检索ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.自定义检索ToolStripMenuItem.Text = "自定义检索";
            // 
            // 搜索ToolStripMenuItem
            // 
            this.搜索ToolStripMenuItem.Name = "搜索ToolStripMenuItem";
            this.搜索ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.搜索ToolStripMenuItem.Text = "搜索";
            this.搜索ToolStripMenuItem.Click += new System.EventHandler(this.搜索ToolStripMenuItem_Click);
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.添加ToolStripMenuItem.Text = "添加搜索";
            this.添加ToolStripMenuItem.Click += new System.EventHandler(this.添加ToolStripMenuItem_Click);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.清空ToolStripMenuItem.Text = "清空搜索";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.清空ToolStripMenuItem_Click);
            // 
            // Dial
            // 
            this.Dial.Controls.Add(this.tabPage1);
            this.Dial.Controls.Add(this.tabPage2);
            this.Dial.Controls.Add(this.tabPage3);
            this.Dial.Controls.Add(this.tabPage4);
            this.Dial.Controls.Add(this.tabPage5);
            this.Dial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dial.Location = new System.Drawing.Point(0, 28);
            this.Dial.Name = "Dial";
            this.Dial.SelectedIndex = 0;
            this.Dial.Size = new System.Drawing.Size(525, 304);
            this.Dial.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.选项列表框1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(517, 275);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "桌面";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑ToolStripMenuItem,
            this.添加ToolStripMenuItem1,
            this.备份ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 76);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.编辑ToolStripMenuItem.Text = "添加";
            // 
            // 添加ToolStripMenuItem1
            // 
            this.添加ToolStripMenuItem1.Name = "添加ToolStripMenuItem1";
            this.添加ToolStripMenuItem1.Size = new System.Drawing.Size(108, 24);
            this.添加ToolStripMenuItem1.Text = "编辑";
            // 
            // 备份ToolStripMenuItem
            // 
            this.备份ToolStripMenuItem.Name = "备份ToolStripMenuItem";
            this.备份ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.备份ToolStripMenuItem.Text = "备份";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.选项列表框2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(517, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "文件夹";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.选项列表框3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(517, 273);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "文件夹空白处";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.选项列表框4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(517, 273);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "驱动器(盘符图标)";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.选项列表框5);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(517, 273);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "自定义检索";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // banner
            // 
            this.banner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.banner.AutoSize = true;
            this.banner.ForeColor = System.Drawing.Color.Red;
            this.banner.Location = new System.Drawing.Point(11, 9);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(444, 15);
            this.banner.TabIndex = 3;
            this.banner.Text = "必须以管理员权限打开!  目录路径或乱码请谨慎的备份后再删除!";
            this.banner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // main_panel
            // 
            this.main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.main_panel.BackColor = System.Drawing.Color.Transparent;
            this.main_panel.Controls.Add(this.banner);
            this.main_panel.Location = new System.Drawing.Point(235, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(290, 28);
            this.main_panel.TabIndex = 4;
            this.main_panel.Click += new System.EventHandler(this.main_panel_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 选项列表框1
            // 
            this.选项列表框1.AutoScroll = true;
            this.选项列表框1.BackColor = System.Drawing.Color.Wheat;
            this.选项列表框1.ContextMenuStrip = this.contextMenuStrip1;
            this.选项列表框1.Location = new System.Drawing.Point(0, 0);
            this.选项列表框1.Name = "选项列表框1";
            this.选项列表框1.Size = new System.Drawing.Size(520, 280);
            this.选项列表框1.TabIndex = 3;
            // 
            // 选项列表框2
            // 
            this.选项列表框2.AutoScroll = true;
            this.选项列表框2.BackColor = System.Drawing.Color.Wheat;
            this.选项列表框2.ContextMenuStrip = this.contextMenuStrip1;
            this.选项列表框2.Location = new System.Drawing.Point(0, 0);
            this.选项列表框2.Name = "选项列表框2";
            this.选项列表框2.Size = new System.Drawing.Size(520, 280);
            this.选项列表框2.TabIndex = 2;
            // 
            // 选项列表框3
            // 
            this.选项列表框3.AutoScroll = true;
            this.选项列表框3.BackColor = System.Drawing.Color.Wheat;
            this.选项列表框3.ContextMenuStrip = this.contextMenuStrip1;
            this.选项列表框3.Location = new System.Drawing.Point(0, 0);
            this.选项列表框3.Name = "选项列表框3";
            this.选项列表框3.Size = new System.Drawing.Size(520, 280);
            this.选项列表框3.TabIndex = 0;
            // 
            // 选项列表框4
            // 
            this.选项列表框4.AutoScroll = true;
            this.选项列表框4.BackColor = System.Drawing.Color.Wheat;
            this.选项列表框4.ContextMenuStrip = this.contextMenuStrip1;
            this.选项列表框4.Location = new System.Drawing.Point(0, 0);
            this.选项列表框4.Name = "选项列表框4";
            this.选项列表框4.Size = new System.Drawing.Size(520, 280);
            this.选项列表框4.TabIndex = 0;
            // 
            // 选项列表框5
            // 
            this.选项列表框5.AutoScroll = true;
            this.选项列表框5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.选项列表框5.Location = new System.Drawing.Point(0, 0);
            this.选项列表框5.Name = "选项列表框5";
            this.选项列表框5.Size = new System.Drawing.Size(520, 280);
            this.选项列表框5.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(525, 332);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.Dial);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Dial.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新F5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 网页版ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.TabControl Dial;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private 选项列表框 选项列表框2;
        private 选项列表框 选项列表框3;
        private 选项列表框 选项列表框4;
        private System.Windows.Forms.TabPage tabPage1;
        private 选项列表框 选项列表框1;
        private System.Windows.Forms.ToolStripMenuItem 自定义检索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage5;
        private 选项列表框 选项列表框5;
        private System.Windows.Forms.Label banner;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.ToolStripMenuItem 置顶ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 备份ToolStripMenuItem;
    }
}

