using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using CMIS4API.Models;

namespace CMIS4API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DM_CPHI_KHAOSATController
    {
        private readonly IConfiguration _configuration;
        public DM_CPHI_KHAOSATController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                select MA_DVIQLY, MA_CPHI_KSAT, TEN_CPHI_KSAT, DVT, CPHI_KSAT, HE_SO_KSAT, NGAY_TAO, NGUOI_TAO, NGAY_SUA, NGUOI_SUA, TRANG_THAI";
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
        public JsonResult Post(DM_CPHI_KHAOSAT dm_cpks)
        {
            string query = @"
                insert into dbo.DM_CPHI_KHAOSAT (MA_DVIQLY, MA_CPHI_KSAT, TEN_CPHI_KSAT, DVT, CPHI_KSAT, HE_SO_KSAT, NGAY_TAO, NGUOI_TAO, NGAY_SUA, NGUOI_SUA, TRANG_THAI)
                values
                ('" + dm_cpks.MA_DVIQLY + @"' 
                ,'" + dm_cpks.MA_CPHI_KSAT + @"'
                ,'" + dm_cpks.TEN_CPHI_KSAT + @"'
                ,'" + dm_cpks.DVT + @"'
                ,'" + dm_cpks.CPHI_KSAT + @"'
                ,'" + dm_cpks.HE_SO_KSAT + @"'
                ,'" + dm_cpks.NGAY_TAO + @"'
                ,'" + dm_cpks.NGUOI_TAO + @"'
                ,'" + dm_cpks.NGAY_SUA + @"'
                ,'" + dm_cpks.NGUOI_SUA + @"'
                ,'" + dm_cpks.TRANG_THAI + @"')
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
        public JsonResult Put(DM_CPHI_KHAOSAT dm_cpks)
        {
            string query = @"
                update dbo.DM_CPHI_KHAOSAT set
                MA_DVIQLY = '" + dm_cpks.MA_DVIQLY + @"'
                ,MA_CPHI_KSAT = '" + dm_cpks.MA_CPHI_KSAT + @"'
                ,TEN_CPHI_KSAT = '" + dm_cpks.TEN_CPHI_KSAT + @"'
                ,DVT = '" + dm_cpks.DVT + @"'
                ,CPHI_KSAT = '" + dm_cpks.CPHI_KSAT + @"'
                ,HE_SO_KSAT = '" + dm_cpks.HE_SO_KSAT + @"'
                ,NGAY_TAO = '" + dm_cpks.NGAY_TAO + @"'
                ,NGUOI_TAO = '" + dm_cpks.NGUOI_TAO + @"'
                ,NGAY_SUA = '" + dm_cpks.NGAY_SUA + @"'
                ,NGUOI_SUA = '" + dm_cpks.NGUOI_SUA + @"'
                ,TRANG_THAI = '" + dm_cpks.TRANG_THAI + @"'                ";
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
                delete from dbo.DM_CPHI_KHAOSAT
                where MA_CPHI_KSAT = " + id + @"'
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
