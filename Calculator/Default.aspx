<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div class="container">
        <h1>Calculator</h1>
        
        <form id="form1" runat="server">
            <div class="form-group">
                <input type="number" class="form-control"  name="number1" step="any" />

                <select name="Operation">
                    <option>---</option>
                    <option>+</option>
                    <option>-</option>
                    <option>/</option>
                    <option>x</option>
                </select>

                <input type="number" class="form-control" name="number2" step="any" />

                


                <div>
                    <input type="submit" class="btn btn-default" value="Calculate" />
                </div>
                <div>
                    <h2><%= message %></h2>
                    <h2><%= Equation %></h2>
                    <h2><%= Calculation %></h2>
                </div>
            </div>
        </form>
    </div>

</body>
</html>
