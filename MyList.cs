using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registry_edit
{
    public class MyList<选项列表的状态> : List<选项列表的状态>
    {
        //写这个类的意义在于 当MyList实例调用AddRange事件时,可以触发自定义事件.
        public delegate void Draw(List<选项列表的状态> e);
        public Draw Plot;
        public new void AddRange(IEnumerable<选项列表的状态> collection) {
            base.AddRange(collection);
            Plot(this);
        }
    }
}
