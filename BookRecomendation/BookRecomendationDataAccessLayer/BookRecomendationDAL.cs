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
        public AdvWorksDataAccessLayer()
        {
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["AdvWorksConnectionStr"].ConnectionString);
            //contextObj = new AdventureWorks2012Context();
        }

        public int ConnectionToDB()
        {
            try
            {
                AdvWorksDataAccessLayer dalObj = new AdvWorksDataAccessLayer();
                return dalObj.ConnectionToDB();
            }
            catch (Exception )
            {
                return -1;
            }
        }

        public List<DeptDetailsDTO> FetchAllDept()
        {
            try
            {
                cmdObj = new SqlCommand(@"SELECT Name,GroupName FROM HumanResources.Department", conObj);
                conObj.Open();
                
                List<DeptDetailsDTO> lstDept = new List<DeptDetailsDTO>();
                while (drDept.Read())
                {
                    DeptDetailsDTO deptFromReader = new DeptDetailsDTO();
                    deptFromReader.DeptName = drDept["Name"].ToString();
                    deptFromReader.DeptGroupName = drDept["GroupName"].ToString();
                    lstDept.Add(deptFromReader);
                    
                }
                return lstDept;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conObj.Close();
            }
        }

        public int InsertAddnewdept(DeptDetailsDTO newdeptobj, out int newdeptid)
        {
            throw new NotImplementedException();
        }
    }
}



       



        public void FetchReviewsForBook()
        {
        }

        public void SaveReviewForBookToDB()
        {
        }

}
}
