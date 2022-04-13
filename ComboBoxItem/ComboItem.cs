using System;

namespace ComboBoxItem
{
    public class ComboItem
    {
        public string Text { get; set; }
        public object Tag { get; set; }
        public string Id { get; set; }
        public ComboItem()
        {
        }

        public ComboItem(object tag)
        {
            Tag = tag;
        }
        public ComboItem(string text, object tag)
        {
            Text = text ?? throw new ArgumentNullException(nameof(text));
            this.Tag = tag;
        }

        public ComboItem(string text, object tag, string id)
        {
            Text = text ?? throw new ArgumentNullException(nameof(text));
            Tag = tag;
            Id = id ?? throw new ArgumentNullException(nameof(id));
        }

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(Text))
            {
                return Text;
            }

            return Tag.ToString();
        }
    }
}
