using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns.Observer
{
    class SubscriberTextBox : TextBox
    {
        public void Publisher_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                Text = Text.Insert(SelectionStart, e.KeyChar.ToString());
                SelectionStart = Text.Length;
            }
        }
    }
}
