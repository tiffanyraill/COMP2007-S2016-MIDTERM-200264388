using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            using (ToDoConnection db = new ToDoConnectionConnection())
            {
                //use the Student model to create new student object and save new record
                TodoList newToDoList = new TodoList();

                //add data to the new student record
                newToDoList.ToDoID = ToDoIDTextBox.Text;
                newToDoList.ToDoName = ToDoNameTextBox.Text;
                newToDoList.ToDoNotes = ToDoNotesTextBox.Text;
                newToDoList.Completed = CompletedCheckBox.

                //use linq and ADO.NET to add/insert a new student into the DB
                db.Students.Add(newStudent);

                //save our changes
                db.SaveChanges();

                //redirect back to the updated students page
                Response.Redirect("~/ToDoList.aspx");


            }
        }
    }
}
   