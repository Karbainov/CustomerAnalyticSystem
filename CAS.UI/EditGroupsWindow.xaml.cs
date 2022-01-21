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
    public partial class EditGroupsWindow : Window
    {
        private MainWindow _mainWindow;

        public EditGroupsWindow(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
            FillingListViewEditGroupsWndw();
            //ListViewEditGroupsWndw
        }

        private void FillingListViewEditGroupsWndw()
        {
            ListViewEditGroupsWndw.Items.Clear();
            var Groups = new ProductTagGroupService();
            var listGroups = Groups.GetAllGroups();
            foreach (var t in listGroups)
            {
                ListViewEditGroupsWndw.Items.Add(t);
            }

        }

        private void ButtonAddGroup_Click(object sender, RoutedEventArgs e)
        {
            if (_mainWindow.GroupsIdAndGroups.ContainsKey(TextBoxNewGroup.Text) == false)
            {
                if (TextBoxNewGroup.Text != String.Empty)
                {
                    var group = new ProductTagGroupService();
                    group.AddGroup(TextBoxNewGroup.Text, TextBoxDescription.Text);
                    _mainWindow.FillingComboBoxGroups();
                    FillingListViewEditGroupsWndw();
                    _mainWindow.FillingDictGroups();
                    TextBoxNewGroup.Text = "";
                    TextBoxDescription.Text = "";
                }
                else
                {
                    MessageBox.Show("Введите наименование группы");
                }
            }
            else
            {
                MessageBox.Show("Такая группа уже существует");
            }
        }

        private void ButtonDeleteGroup_Click(object sender, RoutedEventArgs e)
        {
            //if (ListViewEditGroupsWndw.SelectedItem != null)
            //{
            //    это могло бы работать, но нет
            //    int id = -1;
            //    _mainWindow.GroupsIdAndGroups.TryGetValue(ListViewEditGroupsWndw.SelectedItem.ToString(), out id);
            //    var group = new ProductTagGroupService();
            //    group.DeleteGroupById(id);
            //    _mainWindow.FillingComboBoxGroups();
            //    FillingListViewEditGroupsWndw();
            //}
            //else
            //{
            //    MessageBox.Show("Выберите тэг для удаления");
            //}
        }

        private void ButtonEditGroup_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewEditGroupsWndw.SelectedItem != null)
            {
                if (_mainWindow.GroupsIdAndGroups.ContainsKey(TextBoxNewGroup.Text) == false)
                {
                    int id = -1;
                    GroupBaseModel model = (GroupBaseModel)ListViewEditGroupsWndw.SelectedItem;
                    _mainWindow.GroupsIdAndGroups.TryGetValue(model.Name, out id);
                    var group = new ProductTagGroupService();
                    group.UpdateGroupById(id, TextBoxEditGroup.Text, TextBoxDescription.Text);
                    _mainWindow.FillingDictGroups();
                    _mainWindow.FillingComboBoxGroups();
                    FillingListViewEditGroupsWndw();
                    TextBoxEditGroup.Text = "";
                    TextBoxDescription.Text = "";

                    //_mainWindow.GroupsIdAndGroups.Remove(ListViewEditGroupsWndw.SelectedItem.ToString());
                    //_mainWindow.GroupsIdAndGroups.Add(TextBoxEditGroup.Text, id);
                }
                else
                {
                    MessageBox.Show("Такая группа уже существует");
                }
            }
            else
            {
                MessageBox.Show("Выберите группу для редактирования");
            }
        }

        private void TextBoxEditGroup_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ListViewEditGroupsWndw.SelectedItem != null)
            {
                var group = (GroupBaseModel)ListViewEditGroupsWndw.SelectedItem;
                TextBoxEditGroup.Text = group.Name;
                TextBoxDescription.Text = group.Description;
            }
            else
            {
                MessageBox.Show("Выберите группу для редактирования");
            }
        }
    }
}
