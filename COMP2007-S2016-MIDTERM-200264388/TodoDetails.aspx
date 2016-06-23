<%@ Page Title="Todo Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TodoDetails.aspx.cs" Inherits="COMP2007_S2016_MIDTERM_200264388.TodoDetails" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container">
        <div class="row">
            <div class="col-md-offset-3 col-md-6">
                <h1>ToDo List Details</h1>
                <br />
                <div class="form-group">
                    <label class="control-label" for="ToDoNameTextBox">ToDo Name</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="ToDoNameTextBox" placeholder="ToDo Name" required="true"></asp:TextBox>
                </div>   
                <div class="form-group">
                    <label class="control-label" for="ToDoNotesTextBox">ToDo Notes</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="FirstNameTextBox" placeholder="First Name" required="true"></asp:TextBox>
                 
                <asp:TextBox id="TextBox1" style="Z-INDEX: 101; LEFT: 56px; OVERFLOW: hidden; POSITION: absolute; TOP: 72px" runat="server" TextMode="MultiLine"></asp:TextBox> 
                    </div>
                <div class="form-group">
                    <label class="control-label" for="EnrollmentDateTextBox">Enrollment Date</label>
                    <asp:TextBox runat="server" TextMode="Date" CssClass="form-control" ID="EnrollmentDateTextBox" placeholder="mm/dd/yyyy" required="true"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Invalid Date! Format is MM/DD/YYYY"
                        ControlToValidate="EnrollmentDateTextBox" MinimumValue="01/01/2000" MaximumValue="01/01/2999"
                        Type="Date" Display="Dynamic" BackColor="Red" ForeColor="White"  Font-Size="Large"></asp:RangeValidator>
                     </div>   
                <div class="text-right">
                    <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-warning btn-lg" runat="server"
                         UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click" />
                    <asp:Button Text="Save" ID="Savebutton" CssClass="btn btn-primary btn-lg" runat="server" OnClick="Savebutton_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
