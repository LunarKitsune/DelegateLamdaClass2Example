using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSalesDemo
{
    //class inherits what Iprojected requires. What is in an interface is considered abstract
    //meaning that what is in an interface is *required*
    class ProjectedSales : IProjected
    {
        double sales,
               percent,
               increase;

        public double Sales { set { sales = value; } }
        public double Percent { set { percent = value; } }
        public double Increase { set { increase = value; } }

        #region Delegates
        //This delegate will delegate our sales increase method(s) shortening our code
        //and making code more readable

        //First use in line 50
        //Second use in line 
        delegate double delgSaleIncrease(double saleValue, double percentValue);

        //This will be used with our string Message() Method on line 64
        delegate bool salesGoal(double percentGoal);


        #endregion Delegates

        #region Class Methods
        //this is the interface method that was implemented when
        //this class inherited the interface itself. 
        public double salesIncrease()
        {
            double salesIncrease = (sales * percent / 100) + sales;
            return salesIncrease;
        }

        //this is the overriden method. Does same thing as last method, just parameters
        public double salesIncrease(double sales, double percent)
        {
            return increase = (sales * percent / 100) + sales;
        }



        public override string ToString()
        {
            //we hand over sales increase to a variable delegate of delgSaleincrease
            delgSaleIncrease results = salesIncrease;

            //result is return where we have results[parameter 1, parameter 2]

            //The parameters are what the sales increase method had required
            return $"Projected Sales increase: is {results(sales, percent):C}";

        }

        public string message()
        {
            string output = string.Empty;

            //A boolean goal as we recall from the salesGoal Delegate from line 29
            //takes a parameter of a percent passed to it. 

            //It takes the percent and determines if the answer is true or false is the percentage
            //is greater than 10
            salesGoal goal = ans => percent > 10;

            output = $"Goal is {.10:P}\r\n";

            //The result comes from line 71 in this method 
            output += $"Goal Met: {goal(percent)}";


            return output;
        }

        public string IncreaseResults()
        {
            string output = string.Empty;

            //Here from the delegate that was created on line 27 instead of just throwing the method in,
            //the delegate instead is being given parameters (a double sale, and a double percent);
            
            // after the lamda expression "=>" and expression must be given.

            //the expression (sale * percent/100) + sale uses the parameters given in the parenthesis giving the results later
            //we still throw in the variables to the delegate we will have in the curly braces
            delgSaleIncrease increasedby = (double saleProvided, double percentProvided) => (saleProvided * percentProvided / 100) + saleProvided;

            output = $"Projected sales are {increasedby(sales, percent)}";

            return output;
        }


        public string validateInput(string inputString)
        {
            string output = string.Empty;


            //substring looks at a start index of a string (remember indexing starts at 0 which is the first character)

            //substring then looks at the length of string from that starting point. 

            //In this case the boolean is declared instead of doing an if else statement to reduce scope/use of curly brackets
            bool InputIsVald = (inputString.StartsWith("P") && inputString.Substring(2, 1) == "3");

            //output is a result of if input being valid or not
            output = InputIsVald ? "Is Valid!" : "Not Valid!";

            return output;
        }
        #endregion Class Methods

    }
}
