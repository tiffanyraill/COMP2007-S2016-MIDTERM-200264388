<%@ Page Title="Todo List" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TodoList.aspx.cs" Inherits="COMP2007_S2016_MIDTERM_200264388.TodoList" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
          <div class="container">
        <div class="row">
            <div class="col-md-offset-2 col-md-8">
                <h1>ToDo List</h1>
                <a href="ToDoDetails.aspx" class="btn btn-success btn-sm"><i class="fa fa-plus"></i> Add ToDo</a>
                <asp:GridView runat="server" CssClass="table table-bordered table-striped table-hover"
                     ID="ToDoGridView" AutoGenerateColumns="false" DataKeyNames="ToDoID" OnRowDeleting="ToDoGridView_RowDeleting"
                     OnRowEditing="ToDoGridView_RowEditing">
                    <Columns>
                        <asp:BoundField DataField="ToDoID" HeaderText="ToDo ID" Visible="false" />
                        <asp:BoundField DataField="ToDoName" HeaderText="ToDo" Visible="true" />
                        <asp:BoundField DataField="ToDoNotes" HeaderText="Notes" Visible="true" />
                        <asp:BoundField DataField="Completed" HeaderText="Completed" Visible="true" />
                        <asp:CommandField HeaderText="Edit" EditText="<i class='fa fa-pencil-o fa-lg'></i> Edit"
                             ShowEditButton="true" ButtonType="Link" ControlStyle-CssClass="btn btn-danger bt-sm" />
                        <asp:CommandField HeaderText="Delete" DeleteText="<i class='fa fa-trash-o fa-lg'></i> Delete"
                             ShowDeleteButton="true" ButtonType="Link" ControlStyle-CssClass="btn btn-danger bt-sm" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
