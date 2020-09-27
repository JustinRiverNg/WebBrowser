using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            var items = BookmarkManager.getItems();
            bookmarkListBox.Items.Clear();

            foreach (var item in items)
            {
                bookmarkListBox.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
            }
        }

        private void BookmarkSearchButton_Click(object sender, EventArgs e)
        {
            var items = BookmarkManager.getItems();
            bookmarkListBox.Items.Clear();
            foreach (var item in items)
            {
                if (item.Title.Contains(bookmarkSearchTextBox.Text) || (item.URL.Contains(bookmarkSearchTextBox.Text)))
                {
                    bookmarkListBox.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
                }
            }
        }

        private void DeleteBookmarkButton_Click(object sender, EventArgs e)
        {
            var items = BookmarkManager.getItems();
            string bookmarkItemString = bookmarkListBox.SelectedItem.ToString();
            string bookmarkTitle = bookmarkItemString.Substring(0, ((bookmarkItemString.IndexOf('(') - 1)));
            items = BookmarkManager.deleteItem(bookmarkTitle);
            bookmarkListBox.Items.Clear();

            foreach (var item in items)
            {
                bookmarkListBox.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
            }
        }
    }
}
