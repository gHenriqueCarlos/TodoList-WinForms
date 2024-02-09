using static System.Runtime.InteropServices.JavaScript.JSType;

namespace todoList_winForms
{
    public partial class Form1 : Form
    {
        private TodoListData todoData;
        public Form1() 
        {
            InitializeComponent();

            /* ColumnHeader todoName = new ColumnHeader();
            todoName.Text = "Tarefa";
            todoList.Columns.Add(todoName);

            ColumnHeader ch2 = new ColumnHeader();
            ch2.Text = "Descrição";
            todoList.Columns.Add(ch2);
            */

            todoData = new TodoListData(true);

            for (int i = 0; i < 5; i++)
            {
                todoData.SaveTodo("Tarefa_" + i.ToString(), "Descrição_" + i.ToString(), "08/02/2024", false);
            }
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void todoList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void todoList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            todoText.Clear();
            todoDescText.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*foreach (ListViewItem item in todoList.Items)
            {

                if (item.Selected == true)
                {
                    // Code Here...
                }

            }*/

            if(listViewTodo.SelectedItems.Count > 0) {
                todoData.DeleteTodo(listViewTodo.SelectedItems[0].Text);
                listViewTodo.Items.Remove(listViewTodo.SelectedItems[0]);
            }
        }

        private void btnDeleteList_Click(object sender, EventArgs e)
        {
            listViewTodo.Items.Clear();
            todoData.ClearTodoList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            foreach (var dataf in todoData.UserTodoList)
            {
                
                item = new ListViewItem
                {
                    Text = dataf.TodoName
                };

                item.SubItems.Add(dataf.TodoDescription);
                item.SubItems.Add(dataf.TodoDate);
                item.SubItems.Add(dataf.TodoFinished);
                listViewTodo.Items.Add(item);
            }
        }
    }
}
