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
        public static void writeToTextFromThread(frmTcpTest writeTo, TextBox t, string textToWrite, bool append = false)
        {
            if (writeTo.InvokeRequired)
            {
                IAsyncResult result = writeTo.BeginInvoke(new MethodInvoker(delegate ()
                {
                    if (append) t.Text = t.Text + textToWrite + "\r\n";
                    else t.Text = textToWrite;
                }));
            }
            else if (writeTo.IsHandleCreated)
            {
                if (append) t.Text = t.Text + textToWrite + "\r\n";
                else t.Text = textToWrite;
            }
        }

        // TODO: Find a way to abstract this method into the above; they're so dang similar
        public static void writeToLabelFromThread(frmTcpTest writeTo, Label l, string textToWrite, bool append = false)
        {
            if (writeTo.InvokeRequired)
            {
                IAsyncResult result = writeTo.BeginInvoke(new MethodInvoker(delegate ()
                {
                    if (append) l.Text = l.Text + textToWrite + "\r\n";
                    else l.Text = textToWrite;
                }));
            }
            else if (writeTo.IsHandleCreated)
            {
                if (append) l.Text = l.Text + textToWrite + "\r\n";
                else l.Text = textToWrite;
            }
        }
    }
}
