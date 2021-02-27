using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbeddedSystemsTest
{
    public class Utilities
    {
        public static void WriteToGUIFromThread(frmTcpTest writeTo, Action codeBlock)
        {
            if (writeTo.InvokeRequired)
            {
                IAsyncResult result = writeTo.BeginInvoke(new MethodInvoker(delegate ()
                {
                    codeBlock();
                }));
            }
            else if (writeTo.IsHandleCreated)
            {
                codeBlock();
            }
        }

        public static string getCurrDate()
        {
            return DateTime.Now.ToString("dd MMMM yyyy; hh:mm:ss");
        }
    }
}
