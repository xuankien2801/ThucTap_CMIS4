using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using CMIS4API.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace CMIS4API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DM_VATTUController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public DM_VATTUController (IConfiguration configuration) 
        {
            _configuration = configuration; 
        }
        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                select MA_DVIQLY, ID_VT_ERP, MA_VT_ERP, TEN_VT_ERP, DVT_ERP, SO_PHA, TRANG_THAI";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("CMIS4AppCon");
            SqlDataReader myReader;
            using(SqlConnection myCon = new SqlConnection(sqlDataSource))
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
        public JsonResult Post(DM_VATTU dm_vattu)
        {
            string query = @"
                insert into dbo.DM_VATTU (MA_DVIQLY, ID_VT_ERP, MA_VT_ERP, TEN_VT_ERP, DVT_ERP, SO_PHA, TRANG_THAI)
                values
                ('" + dm_vattu.MA_DVIQLY + @"'
                ,'" + dm_vattu.ID_VT_ERP + @"'
                ,'" + dm_vattu.MA_VT_ERP + @"'
                ,'" + dm_vattu.TEN_VT_ERP + @"'
                ,'" + dm_vattu.DVT_ERP + @"'
                ,'" + dm_vattu.SO_PHA + @"'
                ,'" + dm_vattu.TRANG_THAI + @"')
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
        public JsonResult Put(DM_VATTU dm_vattu)
        {
            string query = @"
                update dbo.DM_VATTU set
                MA_DVIQLY = '" + dm_vattu.MA_DVIQLY + @"'
                ,ID_VT_ERP = '" + dm_vattu.ID_VT_ERP + @"'
                ,MA_VT_ERP = '" + dm_vattu.MA_VT_ERP + @"'
                ,TEN_VT_ERP = '" + dm_vattu.TEN_VT_ERP + @"'
                ,DVT_ERP = '" + dm_vattu.DVT_ERP + @"'
                ,SO_PHA = '" + dm_vattu.SO_PHA + @"'
                ,TRANG_THAI = '" + dm_vattu.TRANG_THAI + @"'
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
        public JsonResult Delete(int id)
        {
            string query = @"
                delete from dbo.DM_VATTU
                where ID_VT_ERP = " + id + @"'
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
