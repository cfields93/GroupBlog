using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GroupBlog.Models.Data
{
    public class BlogRepository : ApplicationDbContext
    {
        ApplicationDbContext repo = new ApplicationDbContext();
        public List<Blog> GetAll()
        {
            List<Blog> blogs = new List<Blog>();
            foreach (var blog in repo.Blogs)
            {
                blogs.Add(blog);
            }
            return blogs;

            //using (SqlConnection conn = new SqlConnection())
            //{
            //    conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = conn;
            //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //    cmd.CommandText = "GetAll";

            //    using (SqlDataReader reader = cmd.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            Blog blog = new Blog();
            //            blog.Id = int.Parse(reader[0].ToString());
            //            blog.Title = reader[1].ToString();
            //            blog.Body = reader[2].ToString();
            //            blog.Date = DateTime.Parse(reader[3].ToString());
            //            blogs.Add(blog);
            //        }
            //    }
            //    return blogs;
        }



        public void Add(Blog blog)
        {
            blog.Date = DateTime.Now;
            repo.Blogs.Add(blog);
            repo.SaveChanges();


            //using (SqlConnection conn = new SqlConnection())
            //{
            //    conn.ConnectionString = ConfigurationManager.ConnectionStrings["GroupBlog"].ConnectionString;
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = conn;
            //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //    cmd.CommandText = "Create";
            //    cmd.Parameters.AddWithValue("@Title", blog.Title);
            //    cmd.Parameters.AddWithValue("@Body", blog.Body);
            //    cmd.Parameters.AddWithValue("@Date", blog.Date);
            //    cmd.ExecuteNonQuery();

            //}
        }
    }
}