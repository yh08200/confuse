using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mySystem;
using BT.Preservation;
using System.Reflection;
using SetMethod;

namespace Confuse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Singleton.GetInstance().mainFrom = this;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvokeMethod("ShowElementsSettingsForm"); //菜单可以写在配置文件中，读取配置文件为List<T>
            //在T中定义触发事件，进行统一处理
        }

        public object InvokeMethod(string methodName, params object[] sender)
        {
            var d = typeof(MethodHelper).InvokeMember(methodName,
                BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, sender);
            return d;
        }
    }
}
