using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public double Calculation;
    public string operation;
    public double number2;
    public double number1;
    public string message;
    public string Equation;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack)
        {
            operation = Request.Form["Operation"];
            number2 = double.Parse(Request.Form["number2"]);
            number1 = double.Parse(Request.Form["number1"]);

            

            switch(operation)
            {
                case "+":
                    Calculation = (double.Parse(Request.Form["number1"])) + (double.Parse(Request.Form["number2"]));
                    break;
                case "-":
                    Calculation = (double.Parse(Request.Form["number1"])) - (double.Parse(Request.Form["number2"]));
                    break;
                case "/":
                    if (number2 == 0)
                    {
                        message = "You cannot divide by zero!";
                        break;
                    }
                    else
                    {
                        Calculation = (double.Parse(Request.Form["number1"])) / (double.Parse(Request.Form["number2"]));
                        break;
                    }
                case "x":
                    Calculation = (double.Parse(Request.Form["number1"])) * (double.Parse(Request.Form["number2"]));
                    break;
                default:
                    break;
            }

            Equation = $"{number1} {operation} {number2} = {Calculation}";



        }
    }
}