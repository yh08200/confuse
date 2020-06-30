using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mySystem
{
    public class Singleton
    {
        private static Singleton _singleton;
        private static readonly object Locker = new object();

        public  Form mainFrom { get; set; }

        private Singleton()
        {

        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            if (_singleton == null)
                lock (Locker)
                    if (_singleton == null)
                        _singleton = new Singleton();

            return _singleton;
        }
    }
}
