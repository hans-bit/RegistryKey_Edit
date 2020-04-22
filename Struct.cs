using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace registry_edit
{

    [Serializable] //可以序列化
    public struct 选项列表的状态
    {
        public string title;//键名
        public bool state;//键的状态,一般默认都是true,不是true也扫描不到
        public EventHandler OpenOrClose;//这个键的处理事件 一般是删除
        public RegistryKey RegKey;

    }
}
