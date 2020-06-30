using mySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SetMethod.FormShow;

namespace SetMethod
{
    public class MethodHelper
    {
       
        [System.Reflection.Obfuscation(Exclude = true)]
        public static void ShowElementsSettingsForm()
        {
            var esf = new Test();
            esf.ShowDialog(Singleton.GetInstance().mainFrom);
        }


    }
}
