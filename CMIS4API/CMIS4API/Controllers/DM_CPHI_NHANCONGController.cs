using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using CMIS4API.Models;

namespace CMIS4API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DM_CPHI_NHANCONGController
    {
        private readonly IConfiguration _configuration;
        public DM_CPHI_NHANCONGController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                select MA_DVIQLY, MA_HIEU, TEN_CONG_VIEC, DVT, DON_GIA_NC, DON_GIA_MAY_NC, TRANG_THAI, NGAY_TAO, NGUOI_TAO, NGAY_SUA, NGUOI_SUA, SO_PHA, ID, HE_SO_NC, HE_SO_MAY_NC, DON_GIA_VLP";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("CMIS4AppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(table);
        }

        [HttpPost]
        public JsonResult Post(DM_CPHI_NHANCONG dm_cpnc)
        {
            string query = @"
                insert into dbo.DM_CPHI_NHANCONG (MA_DVIQLY, MA_HIEU, TEN_CONG_VIEC, DVT, DON_GIA_NC, DON_GIA_MAY_NC, TRANG_THAI, NGAY_TAO, NGUOI_TAO, NGAY_SUA, NGUOI_SUA, SO_PHA, ID, HE_SO_NC, HE_SO_MAY_NC, DON_GIA_VLP)
                values
                ('" + dm_cpnc.MA_DVIQLY + @"'
                ,'" + dm_cpnc.MA_HIEU + @"'
                ,'" + dm_cpnc.TEN_CONG_VIEC + @"' 
                ,'" + dm_cpnc.DVT + @"'
                ,'" + dm_cpnc.DON_GIA_NC + @"'
                ,'" + dm_cpnc.DON_GIA_MAY_NC + @"'
                ,'" + dm_cpnc.TRANG_THAI + @"'
                ,'" + dm_cpnc.NGAY_TAO + @"'
                ,'" + dm_cpnc.NGUOI_TAO + @"'
                ,'" + dm_cpnc.NGAY_SUA + @"'
                ,'" + dm_cpnc.NGUOI_SUA + @"'
                ,'" + dm_cpnc.SO_PHA + @"'
                ,'" + dm_cpnc.ID + @"'
                ,'" + dm_cpnc.HE_SO_NC + @"'
                ,'" + dm_cpnc.HE_SO_MAY_TC + @"'
                ,'" + dm_cpnc.DON_GIA_VLP + @"')
                ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("CMIS4AppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Added Successfully");
        }

        [HttpPut]
        public JsonResult Put(DM_CPHI_NHANCONG dm_cpnc)
        {
            string query = @"
                update dbo.DM_CPHI_NHANCONG set
                MA_DVIQLY = '" + dm_cpnc.MA_DVIQLY + @"'
                ,MA_HIEU = '" + dm_cpnc.MA_HIEU + @"'
                ,TEN_CONG_VIEC = '" + dm_cpnc.TEN_CONG_VIEC + @"'
                ,DVT = '" + dm_cpnc.DVT + @"'
                ,DON_GIA_NC = '" + dm_cpnc.DON_GIA_NC + @"'
                ,DON_GIA_MAY_NC = '" + dm_cpnc.DON_GIA_MAY_NC + @"'
                ,TRANG_THAI = '" + dm_cpnc.TRANG_THAI + @"'
                ,NGAY_TAO = '" + dm_cpnc.NGAY_TAO + @"'
                ,NGUOI_TAO = '" + dm_cpnc.NGUOI_TAO + @"'
                ,NGAY_SUA = '" + dm_cpnc.NGAY_SUA + @"'
                ,NGUOI_SUA = '" + dm_cpnc.NGUOI_SUA + @"'
                ,SO_PHA = '" + dm_cpnc.SO_PHA + @"'
                ,ID = '" + dm_cpnc.ID + @"'
                ,HE_SO_NC = '" + dm_cpnc.HE_SO_NC + @"'
                ,HE_SO_MAY_TC = '" + dm_cpnc.HE_SO_MAY_TC + @"'
                ,DON_GIA_VLP = '" + dm_cpnc.DON_GIA_VLP + @"'
                ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("CMIS4AppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Update Successfully");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(String id)
        {
            string query = @"
                delete from dbo.DM_CPHI_NHANCONG
                where ID = " + id + @"'
                ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("CMIS4AppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Deleted Successfully");
        }
    }
}
