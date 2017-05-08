using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {


        protected void Button1_Click(object sender, EventArgs e)
        {
         
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(value1.Text);
            int num2 = Int32.Parse(value2.Text);
            int sum = num1 + num2;
            value3.Text = sum.ToString();

        }

        protected void value3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
        
    
}