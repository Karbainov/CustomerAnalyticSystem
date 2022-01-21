using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CustomerAnalyticSystem.BLL;

namespace CustomerAnalyticSystem.UI
{

    public partial class EditTagsWindow : Window
    {
        private MainWindow _mainWindow;

        public EditTagsWindow(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
            FillingListViewEditTagsWndw();
        }

        private void FillingListViewEditTagsWndw()
        {
            ListViewEditTagsWndw.Items.Clear();
            var tags = new ProductTagGroupService();
            var listTags = tags.GetAllTags();
            foreach (var t in listTags)
            {
                ListViewEditTagsWndw.Items.Add(t.Name);
            }

        }

        private void ButtonAddTag_Click(object sender, RoutedEventArgs e)
        {
            if (_mainWindow.TagsIdAndTags.ContainsKey(TextBoxNewTag.Text) == false)
            {
                if (TextBoxNewTag.Text != String.Empty)
                {
                    var tag = new ProductTagGroupService();
                    tag.AddTag(TextBoxNewTag.Text);
                    _mainWindow.FillingComboBoxTags();
                    FillingListViewEditTagsWndw();
                    _mainWindow.FillingDictTags();
                    TextBoxNewTag.Text = "";

                }
                else
                {
                    MessageBox.Show("Введите наименование тэга");
                }
            }
            else
            {
                MessageBox.Show("Такой тэг уже существует");
            }
        }

        private void ButtonDeleteTag_Click(object sender, RoutedEventArgs e)
        {
            //if (ListViewEditTagsWndw.SelectedItem != null)
            //{
            //    это могло бы работать, но нет
            //    int id = -1;
            //    _mainWindow.TagsIdAndTags.TryGetValue(ListViewEditTagsWndw.SelectedItem.ToString(), out id);
            //    var tag = new ProductTagGroupService();
            //    tag.DeleteTagById(id);
            //    _mainWindow.FillingComboBoxTags();
            //    FillingListViewEditTagsWndw();
            //}
            //else
            //{
            //    MessageBox.Show("Выберите тэг для удаления");
            //}
        }

        private void ButtonEditTag_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewEditTagsWndw.SelectedItem != null)
            {
                if (_mainWindow.TagsIdAndTags.ContainsKey(TextBoxNewTag.Text) == false)
                {
                    int id = -1;
                    _mainWindow.TagsIdAndTags.TryGetValue(ListViewEditTagsWndw.SelectedItem.ToString(), out id);
                    var tag = new ProductTagGroupService();
                    tag.UpdateTagById(id, TextBoxEditTag.Text);
                    _mainWindow.TagsIdAndTags.Remove(ListViewEditTagsWndw.SelectedItem.ToString());
                    _mainWindow.TagsIdAndTags.Add(TextBoxEditTag.Text, id);
                    _mainWindow.FillingComboBoxTags();
                    FillingListViewEditTagsWndw();
                    TextBoxEditTag.Text = "";
                }
                else
                {
                    MessageBox.Show("Такой тэг уже существует");
                }
            }
            else
            {
                MessageBox.Show("Выберите тэг для редактирования");
            }
        }

        private void TextBoxEditTag_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ListViewEditTagsWndw.SelectedItem != null)
            {
               TextBoxEditTag.Text = ListViewEditTagsWndw.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Выберите тэг для редактирования");
            }
        }
    }
}
