using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DataBase
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog folderBrowserDialog = null;
        DialogResult dialogResult;
        DataSet dataBase;
        TextReader reader;
        TabPage tabPage;
        DataGridView data;
        List<DataGridView> tables;


        public Form1()
        {
            InitializeComponent();
            tables = new List<DataGridView>();
        
    }


        public void SelectTheDatabase()
        {
            this.folderBrowserDialog = new FolderBrowserDialog();
            this.dialogResult = this.folderBrowserDialog.ShowDialog();
            this.DBName.Text = this.folderBrowserDialog.SelectedPath;
        }

        public void ReadSchemas()
        {
            foreach (DataTable table in this.dataBase.Tables)
            {
                CreateColums(table);

                InputData(table);
            }
        }


        public void ReadAllTables()
        {
            this.reader = new StreamReader(this.folderBrowserDialog.SelectedPath + @"\main.txt");

            string line = reader.ReadLine();
            while (line != null)
            {
                this.dataBase.Tables.Add(line);
                line = reader.ReadLine();
            }
            reader.Close();
        }

        public void CreateColums(DataTable table)
        {
            this.reader = new StreamReader(this.folderBrowserDialog.SelectedPath + @"\" + table.TableName + @"\main.txt");
            string column = reader.ReadLine();
            while (column != null)
            {
                table.Columns.Add(column);
                column = reader.ReadLine();
            }
            reader.Close();
        }

        public void InputData(DataTable table)
        {
            this.reader = new StreamReader(this.folderBrowserDialog.SelectedPath + @"\" + table.TableName + @"\data.txt");
            string data = reader.ReadLine();
            while (data != null)
            {
                table.Rows.Add(data.Split(' '));
                data = reader.ReadLine();
            }
            reader.Close();
        }


        public DataGridView CreateDataGridView()
        {
            data = new DataGridView();
            data.Width = 700;
            data.Height = 300;
            return data;
        }

        public void ShowData()
        {
            foreach (DataTable table in this.dataBase.Tables)
            {
                tabPage = new TabPage(table.TableName);
                tabControl1.TabPages.Add(tabPage);
                data = CreateDataGridView();
                data.DataSource = table;

                tabPage.Controls.Add(data);
                tables.Add(data);
            }
        }
        

        
        public int CurrentTabPageIndex()
        {
            tabPage = tabControl1.SelectedTab;
            bool find = false;
            int i = 0;
            while (!find && i < tabControl1.TabCount)
            {
                if (tabControl1.TabPages[i] == tabPage)
                {
                    find = true;
                }
                else
                {
                    i++;
                }
            }
            return i;
        }

        private void deleteRow_Click(object sender, EventArgs e)
        {
            int i = CurrentTabPageIndex();
            int j = tables[i].SelectedCells[0].RowIndex;
            dataBase.Tables[i].Rows.RemoveAt(j);
        }

        private void deleteColumn_Click(object sender, EventArgs e)
        {
            int i = CurrentTabPageIndex();
            int j = tables[i].SelectedCells[0].ColumnIndex;
            dataBase.Tables[i].Columns.RemoveAt(j);
        }

        private void deleteTable_Click(object sender, EventArgs e)
        {
            int i = CurrentTabPageIndex();
            dataBase.Tables.RemoveAt(i);
            tabControl1.TabPages.RemoveAt(i);
            tables.RemoveAt(i);
        }

        private void addColumn_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                int i = CurrentTabPageIndex();
                dataBase.Tables[i].Columns.Add(textBox2.Text);
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Введите имя!");
            }
        }

        private void addTable_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                dataBase.Tables.Add(textBox2.Text);
                tabPage = new TabPage(textBox2.Text);
                tabControl1.TabPages.Add(tabPage);
                data = CreateDataGridView();
                data.DataSource = dataBase.Tables[dataBase.Tables.Count - 1];
                tabPage.Controls.Add(data);
                tables.Add(data);
                textBox2.Clear();
                tabControl1.SelectedIndex = dataBase.Tables.Count - 1;
            }
            else
            {
                MessageBox.Show("Введите имя!");
            }
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            StreamWriter swMain = new StreamWriter(folderBrowserDialog.SelectedPath + @"\main.txt");
            StreamWriter sw;
            StreamWriter tablewrmain;
            

            foreach (DataTable table in dataBase.Tables)
            {
                swMain.WriteLine(table.TableName);
                Directory.CreateDirectory(this.folderBrowserDialog.SelectedPath + @"\" + table.TableName);

                sw = new StreamWriter(this.folderBrowserDialog.SelectedPath + @"\" + table.TableName + @"\data.txt");
                tablewrmain = new StreamWriter(this.folderBrowserDialog.SelectedPath + @"\" + table.TableName + @"\main.txt");

                int countColums = table.Columns.Count;
                int countR = table.Rows.Count;

                for (int i = 0; i < countColums; i++)
                {
                    tablewrmain.WriteLine(table.Columns[i].ColumnName);
                }
                tablewrmain.Close();

                for (int i = 0; i < countR; i++)
                {
                    string line = "";
                    for (int j = 0; j < countColums - 1; j++)
                    {
                        line += table.Rows[i][j].ToString() + " ";
                    }
                    line += table.Rows[i][countColums - 1].ToString();
                    sw.WriteLine(line);
                }
                sw.Close();
            }
            swMain.Close();
            MessageBox.Show("Сохранено!");
        }

        

        private void createDataBase_Click(object sender, EventArgs e)
        {
            saveChanges.Enabled = true;
            addTable.Enabled = true;
            addColumn.Enabled = true;
            deleteColumn.Enabled = true;
            deleteRow.Enabled = true;
            deleteTable.Enabled = true;
            dataBase = new DataSet();
            SelectTheDatabase();
            MessageBox.Show("Создано!");
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            saveChanges.Enabled = true;
            addTable.Enabled = true;
            addColumn.Enabled = true;
            deleteColumn.Enabled = true;
            deleteRow.Enabled = true;
            deleteTable.Enabled = true;

            this.dataBase = new DataSet();

            SelectTheDatabase();

            ReadAllTables();

            ReadSchemas();

            ShowData();
        }
    }
    
}
