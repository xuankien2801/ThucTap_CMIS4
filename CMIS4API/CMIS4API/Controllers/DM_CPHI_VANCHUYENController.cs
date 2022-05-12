using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using CMIS4API.Models;

namespace CMIS4API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DM_CPHI_VANCHUYENController
    {
        private readonly IConfiguration _configuration;
        public DM_CPHI_VANCHUYENController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                select MA_DVIQLY, MA_CPHI_VCHUYEN, TEN_CPHI_VCHUYEN, DON_GIA, HE_SO, NGAY_TAO, NGUOI_TAO, NGAY_SUA, NGUOI_SUA, TRANG_THAI";
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
        public JsonResult Post(DM_CPHI_VANCHUYEN dm_cpvc)
        {
            string query = @"
                insert into dbo.DM_CPHI_VANCHUYEN (MA_DVIQLY, MA_CPHI_VCHUYEN, TEN_CPHI_VCHUYEN, DON_GIA, HE_SO, NGAY_TAO, NGUOI_TAO, NGAY_SUA, NGUOI_SUA, TRANG_THAI)
                values
                ('" + dm_cpvc.MA_DVIQLY + @"'
                ,'"+  dm_cpvc.MA_CPHI_VCHUYEN + @"'
                ,'" + dm_cpvc.TEN_CPHI_VCHUYEN + @"'                
                ,'" + dm_cpvc.DON_GIA + @"'
                ,'" + dm_cpvc.HE_SO + @"'
                ,'" + dm_cpvc.NGAY_TAO + @"'
                ,'" + dm_cpvc.NGUOI_TAO + @"'
                ,'" + dm_cpvc.NGAY_SUA + @"'
                ,'" + dm_cpvc.NGUOI_SUA + @"'
                ,'" + dm_cpvc.TRANG_THAI + @"')
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
        public JsonResult Put(DM_CPHI_VANCHUYEN dm_cpvc)
        {
            string query = @"
                update dbo.DM_CPHI_VANCHUYEN set
                ,MA_DVIQLY = '" + dm_cpvc.MA_DVIQLY + @"'
                ,MA_CPHI_VCHUYEN = '" + dm_cpvc.MA_CPHI_VCHUYEN + @"'
                ,TEN_CPHI_VCHUYEN = '" + dm_cpvc.TEN_CPHI_VCHUYEN + @"'
                ,DON_GIA = '" + dm_cpvc.DON_GIA + @"'
                ,HE_SO = '" + dm_cpvc.HE_SO + @"'                
                ,NGAY_TAO = '" + dm_cpvc.NGAY_TAO + @"'
                ,NGUOI_TAO = '" + dm_cpvc.NGUOI_TAO + @"'
                ,NGAY_SUA = '" + dm_cpvc.NGAY_SUA + @"'
                ,NGUOI_SUA = '" + dm_cpvc.NGUOI_SUA + @"'
                ,TRANG_tHAI = '" + dm_cpvc.TRANG_THAI + @"'
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
                delete from dbo.DM_CPHI_VANCHUYEN
                where MA_CPHI_VCHUYEN = " + id + @"'
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
