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
    public partial class TodoList : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //if loading page for the first time, populate ToDoList grid
            if (!IsPostBack)
            {
                //Get the ToDoList data
                this.GetToDoList();
            }
        }

        /**
         * <summary>
         * This method gets the ToDoList data from the DB
         * </summary>
         * 
         * @method GetToDoList
         * @returns {void}
         */

        protected void GetToDoList()
        {
            //connect to EF
            using (TodoConnection db = new TodoConnection())
            {
                //query the todos table using EF and LINQ
                var ToDoList = (from allToDoList in db.Todos
                                select allToDoList);
                //bind the results to the gridview
                ToDoGridView.DataSource = ToDoList.ToList();
                ToDoGridView.DataBind();
            }
        }

        /**
         * <summary>
         * This event handler deletes a ToDoList from the DB using EF
         * </summary>
         * 
         * @method ToDoGridView_RowDeleting
         * @param {object} sender
         * @param {GridViewDeleteEventArgs} e
         * @returns {void}
         */

        protected void ToDoGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //store which row was clicked
            int selectedRow = e.RowIndex;

            //Get the selected StudentID using the grids datakey collection
            int ToDoListID = Convert.ToInt32(ToDoGridView.DataKeys[selectedRow].Values["ToDoListID"]);

            //use EF to find the selected ToDoList in the Db and remove it
            using (TodoConnection db = new TodoConnection())
            {
                //create object of the ToDoList class and store the query string inside of it
                Todo deletedTodos = (from ToDoListRecords in db.Todos
                                            where ToDoListRecords.TodoID == ToDoListID
                                            select ToDoListRecords).FirstOrDefault();
                //remove the selected ToDoList from the database
                db.Todos.Remove(deletedTodos);

                //save changes back to the database
                db.SaveChanges();

                //refresh the grid
                this.GetToDoList();

            }
        }

        protected void ToDoGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}
