using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;


namespace RetrivingDataFromSqlDataBase2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand();
               
                //SqlCommand cmd = new SqlCommand("spGetDataFromtblPersons3", con);
                //cmd.CommandType = CommandType.StoredProcedure;

                StringBuilder builder = new StringBuilder("select * from tblPersons3 where 1=1");

                if (txtFirstName.Value.Trim() != "")
                {
                    builder.Append(" AND FirstName = @FirstName");
                    SqlParameter param = new SqlParameter("@FirstName ", txtFirstName.Value);
                    cmd.Parameters.Add(param);
                }

                if (txtLastName.Value.Trim() != "")
                {
                    builder.Append("AND LastName = @LastName ");
                    SqlParameter param = new SqlParameter("@LastName ", txtLastName.Value);
                    cmd.Parameters.Add(param);
                }
                if (txtGender.Value.Trim() != "")
                {
                    builder.Append("AND Gender = @Gender ");
                    SqlParameter param = new SqlParameter("@Gender ", txtGender.Value);
                    cmd.Parameters.Add(param);
                }
                if (txtSalary.Value.Trim() != "")
                {
                    builder.Append("AND Salary = @Salary ");
                    SqlParameter param = new SqlParameter("@Salary ", txtSalary.Value);
                    cmd.Parameters.Add(param);
                }
                cmd.Connection = con;
                cmd.CommandText = builder.ToString();
                cmd.CommandType = CommandType.Text;
                    
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();
            }
        }
    }
}
