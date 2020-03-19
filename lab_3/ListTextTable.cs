using System.Windows.Forms;

namespace lab_3
{
    internal class ListTextTable
    {
        private readonly ListBox _listBox;
        private readonly int _tableWidth;

        public ListTextTable(int tableWidth, ref ListBox listBox)
        {
            _tableWidth = tableWidth;
            _listBox = listBox;
        }

        internal void PrintLine()
        {
            _listBox.Items.Add(new string('-', _tableWidth));
        }

        internal void PrintRow(params string[] columns)
        {
            var width = (_tableWidth - columns.Length) / columns.Length;
            var row = "|";

            foreach (var column in columns) row += AlignCentre(column, width) + "|";

            _listBox.Items.Add(row);
        }

        private string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text)) return new string(' ', width);

            return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
        }
    }
}