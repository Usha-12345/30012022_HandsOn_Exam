using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookDTO;
using BookRecomendationDataAccessLayer;


namespace BookRecomendationBusinessLayer
{
    //DO NOT MODIFY THE METHOD NAMES : Adding of parameters / changing the return types of the given methods may be required. 
    public class BookRecomendationBL
    {
         BookRecomendationDAL dalobj;
       

        public BookRecomendationBL()
        {
            dalobj = new BookRecomendationDAL();
        }
        public int ConnectToDB()
        {
            try
            {
                BookRecomendationDAL dalObj = new BookRecomendationDAL();
                return dalObj.ConnectionToDB();
            }
            catch (Exception)
            {
                return -89;
            }
        }


        public void ShowReviewsForBook()
        {
            BookRecomendationDAL dalObj = new BookRecomendationDAL();
            List<BookRecomendationDTO> lstOfBooks = dalObj.FetchAllBooks();
           
            return lstOfBooks;
        }


        public int AddReviewForBook(BookRecomendationDTO newauthorname,out int  newauthorID )
        {
        throw new NotImplementedException;
          
        }
      
    }
}
