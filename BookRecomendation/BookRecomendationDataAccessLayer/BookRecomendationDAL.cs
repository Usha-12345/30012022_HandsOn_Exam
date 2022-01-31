using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookRecomendationDTO;

namespace BookRecomendationDataAccessLayer
{
    //DO NOT MODIFY THE METHOD NAMES : Adding of parameters / changing the return types of the given methods may be required.
    public class BookRecomendationDAL

    {

        SqlConnection conObj;
        SqlCommand cmdObj;
        private object deptFromReader;
        private SqlConnection authorname;

        public BookRecomendationDAL()
        {
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["str"].ConnectionString);
        }

        public int ConnectionToDB()
        {
            try
            {
                BookRecomendationDAL dalObj = new BookRecomendationDAL();
                return dalObj.ConnectionToDB();
            }
            catch (Exception)
            {
                return -1;
            }
        }



        public void FetchReviewsForBook()
        {
            
                
                {
                    try
                    {
                        cmdObj = new SqlCommand(@"SELECT authorname,authorId conObj);
                        conObj.Open();
                        SqlDataReader BookRecomendation = cmdObj.ExecuteReader();
                        
                        List<BookRecomendationDTO> lstBook = new List<BookRecomendationDTO>();
                        while (drBook.Read())
                        {
                        BookRecomendationDTO deptFromReader = new BookRecomendationDTO();
                            deptFromReader.authorname = drBook["authorname"].ToString();
                            deptFromReader.authorid = drBook["authorid"].ToString();
                            lstBook.Add(deptFromReader);
                            
                        }
                        return lstBook;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
        }

        public void SaveReviewForBookToDB()
        {
        }

        
    }
}
