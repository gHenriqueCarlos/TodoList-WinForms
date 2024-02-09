using static System.Runtime.InteropServices.JavaScript.JSType;

namespace todoList_winForms
{
    public partial class Form1 : Form
    {
        private TodoListData todoData;
        public Form1() 
        {
            InitializeComponent();

            todoData = new TodoListData(true);

            /*
            for (int i = 0; i < 50; i++)
            {
                todoData.SaveTodo("Tarefa_" + i.ToString(), "Descrição_" + i.ToString(), "08/02/2024", false);
            }
            */
        }

        private void ClearTodoFields()
        {
            todoText.Clear();
            todoDescText.Clear();
            todoCheckBox.Checked = false;
        }
        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string todoName = todoText.Text;
            string todoDesc = todoDescText.Text;

            string todoDate = DateTime.Now.ToString("dd/MM/yyyy");
            bool todoFinished = todoCheckBox.Checked;

            todoData.SaveTodo(todoName, todoDesc, todoDate, todoFinished);
            listViewTodo.Items.Add(new ListViewItem(new[] { todoName, todoDesc, todoDate, todoFinished ? "Sim" : "Não" }));

            ClearTodoFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTodoFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(listViewTodo.SelectedItems.Count > 0) {
                todoData.DeleteTodo(listViewTodo.SelectedItems[0].Text);
                listViewTodo.Items.Remove(listViewTodo.SelectedItems[0]);
            }
        }

        private void btnDeleteList_Click(object sender, EventArgs e)
        {
            listViewTodo.Items.Clear();
            todoData.ClearTodoList();
            ClearTodoFields();
        }
    }
}
