using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//using statements required for EF DB access
using COMP2007_S2016_MIDTERM_200264388.Models;
using System.Web.ModelBinding;

namespace COMP2007_S2016_MIDTERM_200264388
{
    public partial class TodoDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CancelButton_Click(object sender, EventArgs e)
        {
            //redirects back to ToDoList page
            Response.Redirect("~/ToDoList.aspx");
        }

        protected void Savebutton_Click(object sender, EventArgs e)
        {
            //use Ef to connect to server
            using (TodoConnection db = new TodoConnection())
            {
                //use the ToDoList model to create new toDoList object and save new record
                TodoList newTodoList = new TodoList();

      
                //add data to the new toDoList record
                newTodoList.TodoName = TodoNameTextBox.Text;
                newTodoList.TodoNotes = TodoNotesTextBox.Text;
                newTodoList.Completed = Completed.Text;

                //use linq and ADO.NET to add/insert a new ToDoListName into the DB
                db.Todos.Add(newTodoList);

                //save our changes
                db.SaveChanges();

                //redirect back to the updated ToDoList page
                Response.Redirect("~/ToDoList.aspx");


            }
        }
    }
}
   