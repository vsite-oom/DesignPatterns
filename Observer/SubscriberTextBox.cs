namespace DesignPatterns.Observer
{
    class SubscriberTextBox : TextBox
    {
        public void Publisher_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            if (textBox != null)
            {
                Text = Text.Insert(SelectionStart, e.KeyChar.ToString());
                SelectionStart = Text.Length;
            }
        }
    }
}
