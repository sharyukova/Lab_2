
using Google.Apis.Compute.v1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_2
{
    public partial class TotalCommander : Form
    {
        private string currentDirectory;


        public TotalCommander()
        {
            InitializeComponent();
            InitializeListView(listView1);
            InitializeListView(listView2);
            LoadFilesFromDirectory1(@"C:\"); // Загружаем файлы из корневой директории C:\
            LoadFilesFromDirectory2(@"C:\");
        }


        private void InitializeListView(System.Windows.Forms.ListView listView)
        {
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.Columns.Add("Имя", 200);
            listView.Columns.Add("Размер", 100);
            listView.Columns.Add("Тип", 100);
        }

        private void LoadFilesFromDirectory1(string directoryPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

            listView1.Items.Clear();
            pathField1.Text = directoryPath;

            foreach (var file in directoryInfo.GetFiles())
            {
                string[] row = { file.Name, file.Length.ToString(), file.Extension };
                ListViewItem item = new ListViewItem(row);
                item.Tag = file.FullName;
                listView1.Items.Add(item);
            }

            foreach (var dir in directoryInfo.GetDirectories())
            {
                string[] row = { dir.Name, "", "Folder" };
                ListViewItem item = new ListViewItem(row);
                item.Tag = dir.FullName;
                listView1.Items.Add(item);
            }
        }

        private void LoadFilesFromDirectory2(string directoryPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

            listView2.Items.Clear();
            pathField2.Text = directoryPath;

            foreach (var file in directoryInfo.GetFiles())
            {
                string[] row = { file.Name, file.Length.ToString(), file.Extension };
                ListViewItem item = new ListViewItem(row);
                item.Tag = file.FullName;
                listView2.Items.Add(item);
            }

            foreach (var dir in directoryInfo.GetDirectories())
            {
                string[] row = { dir.Name, "", "Folder" };
                ListViewItem item = new ListViewItem(row);
                item.Tag = dir.FullName;
                listView2.Items.Add(item);
            }
        }


        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                string selectedPath = listView2.SelectedItems[0].Tag.ToString();

                if (System.IO.File.Exists(selectedPath))
                {
                    System.Diagnostics.Process.Start(selectedPath); // Открываем файл
                }
                else if (Directory.Exists(selectedPath))
                {
                    LoadFilesFromDirectory2(selectedPath); // Загружаем файлы из выбранной директории
                    currentDirectory = selectedPath;
                }
            }
        }

        private void listView1_DoubleClick_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedPath = listView1.SelectedItems[0].Tag.ToString();

                if (System.IO.File.Exists(selectedPath))
                {
                    System.Diagnostics.Process.Start(selectedPath); // Открываем файл
                }
                else if (Directory.Exists(selectedPath))
                {
                    LoadFilesFromDirectory1(selectedPath); // Загружаем файлы из выбранной директории
                }
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                pathField1.Text = e.Item.Tag.ToString();
            }
        }

        private void backBtn1_Click(object sender, EventArgs e)
        {
            string currentPath = pathField1.Text;
            DirectoryInfo parentDirectory = Directory.GetParent(currentPath);
            if (parentDirectory != null)
            {
                pathField1.Text = parentDirectory.FullName;
                LoadFilesFromDirectory1(parentDirectory.FullName);
            }
        }

       

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) 
            {
                DialogResult dialogResult = MessageBox.Show("Удалить выбранный объект?", "Удаление", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string selectedFile = listView1.SelectedItems[0].Text;
                    string selectedPath = Path.Combine(listView1.SelectedItems[0].Text, selectedFile);

                    if (System.IO.File.Exists(selectedPath))
                    {
                        System.IO.File.Delete(selectedPath);
                    }
                    else if (Directory.Exists(selectedPath))
                    {
                        Directory.Delete(selectedPath, true);
                    }

                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
                
                
            }
            else if (listView2.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Удалить выбранный объект?", "Удаление", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string selectedFile = listView2.SelectedItems[0].Text;
                    string selectedPath = Path.Combine(listView2.SelectedItems[0].Text, selectedFile);

                    if (System.IO.File.Exists(selectedPath))
                    {
                        System.IO.File.Delete(selectedPath);
                    }
                    else if (Directory.Exists(selectedPath))
                    {
                        Directory.Delete(selectedPath, true);
                    }

                    listView2.Items.Remove(listView2.SelectedItems[0]);
                }
            }
        }

        private void pathField1_Leave(object sender, EventArgs e)
        {
            string currentPath = pathField1.Text;

            try
            {
                LoadFilesFromDirectory1(currentPath);
            }
            catch
            {
                MessageBox.Show("Этот путь невозможно открыть. Он введен неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pathField2_Leave(object sender, EventArgs e)
        {
            string currentPath = pathField2.Text;

            try
            {
                LoadFilesFromDirectory2(currentPath);
            }
            catch
            {
                MessageBox.Show("Этот путь невозможно открыть. Он введен неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backBtn2_Click(object sender, EventArgs e)
        {
            string currentPath = pathField2.Text;
            DirectoryInfo parentDirectory = Directory.GetParent(currentPath);
            if (parentDirectory != null)
            {
                pathField1.Text = parentDirectory.FullName;
                LoadFilesFromDirectory2(parentDirectory.FullName);
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string selectedPath = listView1.SelectedItems[1].Text;
            NamingFilesForm namingFilesForm = new NamingFilesForm();
            namingFilesForm.ShowDialog();

            string newFileName = namingFilesForm.GetTextFromTextBox();

            if (!string.IsNullOrEmpty(newFileName))
            {
                string newFilePath = pathField1.Text + "/" + newFileName;
                System.IO.File.Create(newFilePath).Close();
                LoadFilesFromDirectory1(newFilePath);
                LoadFilesFromDirectory2(newFilePath);
            }
        }

        private void переименоватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Переименовать выбранный объект?", "Переименовать", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string selectedPath = pathField1.Text;
                    
                    //string currentPath = pathField1.Text;
                    //DirectoryInfo needinDirectory = Directory.GetParent(currentPath);

                    NamingFilesForm namingFilesForm = new NamingFilesForm();
                    namingFilesForm.ShowDialog();

                    string newName = namingFilesForm.GetTextFromTextBox();

                    if (!string.IsNullOrEmpty(newName))
                    {
                        string newPath = Path.Combine(Path.GetDirectoryName(selectedPath), newName);
                        System.IO.File.Move(selectedPath, newPath);

                        listView1.SelectedItems[0].Text = newName;
                    }
                }                   
            }
            if (listView2.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Переименовать выбранный объект?", "Переименовать", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string selectedPath = pathField2.Text;

                    string currentPath = pathField2.Text;
                    DirectoryInfo needinDirectory = Directory.GetParent(currentPath);

                    NamingFilesForm namingFilesForm = new NamingFilesForm();
                    namingFilesForm.ShowDialog();

                    string newName = namingFilesForm.GetTextFromTextBox();

                    if (!string.IsNullOrEmpty(newName))
                    {
                        string newPath = Path.Combine(Path.GetDirectoryName(needinDirectory.FullName), newName);
                        System.IO.File.Move(selectedPath, newPath);

                        listView2.SelectedItems[0].Text = newName;
                    }
                }

            }
        }

        private void размерОтображаемогоШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создаем диалог выбора шрифта
            FontDialog fontDialog = new FontDialog();

            // Если пользователь выбрал шрифт и нажал OK
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                // Применяем новый размер шрифта к элементам управления на форме
                this.Font = fontDialog.Font;
                foreach (Control control in this.Controls)
                {
                    control.Font = fontDialog.Font;
                }
            }

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение NotePad \n\nРазработано программой Microsoft Visual Studio Community 2022 (64-разрядная версия) - Current\r\nВерсия 17.7.3\r\n\nШарюкова Алина, группа 09-322 ", "Сведения (О программе)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void цветФормыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создаем диалог выбора цвета
            ColorDialog colorDialog = new ColorDialog();

            // Если пользователь выбрал цвет и нажал OK
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Применяем новый цвет фона к форме
                this.BackColor = colorDialog.Color;
            }
        }
    }
}
