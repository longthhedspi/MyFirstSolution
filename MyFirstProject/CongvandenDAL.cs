using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MyFirstProject
{
    public class Congvanden
    {
        public int intid { get; set; }
        public int intsoden { get; set; }
        public string strkyhieu { get; set; }
        public DateTime strngayden { get; set; }
        public string strnoigui { get; set; }
        public string strtrichyeu { get; set; }
        public string strDonvixuly { get; set; }
        public int intiddonvinhap { get; set; }
        public int intkhan { get; set; }
    }
    class CongvandenDAL
    {
        public static List<Congvanden> GetCongvandens(string userName, int pageIndex, int pageSize, out int totalRows, int bittrangthai = 0, int filterData = 0)
        {
            List<Congvanden> listCongVandens = new List<Congvanden>();
            string CS = ConfigurationManager.ConnectionStrings["NetOffice2013_VPCPConnectionString"].ConnectionString;
            int intiddonvinhap = 0;
            int intkhan = 0;

            // Filter theo bittrangthai:
            // 1: Don vi nhap
            // 2: Tinh chat van ban
            switch (bittrangthai)
            {
                case 1:
                    intiddonvinhap = filterData;
                    break;
                case 2:
                    intkhan = filterData;
                    break;
                default:
                    break;
            }

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("SP_Congvanden_by_PageIndex_and_PageSize", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramUserName = new SqlParameter();
                paramUserName.ParameterName = "@strtaikhoan";
                paramUserName.Value = userName;
                cmd.Parameters.Add(paramUserName);

                SqlParameter paramStartIndex = new SqlParameter();
                paramStartIndex.ParameterName = "@PageIndex";
                paramStartIndex.Value = pageIndex;
                cmd.Parameters.Add(paramStartIndex);

                SqlParameter paramMaximumRows = new SqlParameter();
                paramMaximumRows.ParameterName = "@PageSize";
                paramMaximumRows.Value = pageSize;
                cmd.Parameters.Add(paramMaximumRows);

                SqlParameter paramOutputTotalRows = new SqlParameter();
                paramOutputTotalRows.ParameterName = "@TotalRows";
                paramOutputTotalRows.Direction = ParameterDirection.Output;
                paramOutputTotalRows.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(paramOutputTotalRows);
                
                SqlParameter paramIntiddonvinhap = new SqlParameter();
                paramIntiddonvinhap.ParameterName = "@intiddonvinhap";
                paramIntiddonvinhap.Value = intiddonvinhap;
                cmd.Parameters.Add(paramIntiddonvinhap);

                SqlParameter paramIntkhan = new SqlParameter();
                paramIntkhan.ParameterName = "@intkhan";
                paramIntkhan.Value = intkhan;
                cmd.Parameters.Add(paramIntkhan);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Congvanden cvd = new Congvanden();
                    cvd.intid = Convert.ToInt32(rdr["intid"]);
                    var intsodenValue = rdr["intsoden"];
                    cvd.intsoden = (intsodenValue == DBNull.Value) ? 0 : Convert.ToInt32(intsodenValue);
                    var strkyhieuValue = rdr["strkyhieu"];
                    cvd.strkyhieu = (strkyhieuValue == DBNull.Value) ? String.Empty : strkyhieuValue.ToString();
                    var strngaydenValue = rdr["strngayden"];
                    cvd.strngayden = (strngaydenValue == DBNull.Value) ? DateTime.MinValue : Convert.ToDateTime(strngaydenValue);
                    var strnoiguiValue = rdr["strnoigui"];
                    cvd.strnoigui = (strnoiguiValue == DBNull.Value) ? String.Empty : strnoiguiValue.ToString();
                    var strtrichyeuValue = rdr["strtrichyeu"];
                    cvd.strtrichyeu = (strtrichyeuValue == DBNull.Value) ? String.Empty : strtrichyeuValue.ToString();
                    var strDonvixulyValue = rdr["strDonvixuly"];
                    cvd.strDonvixuly = (strDonvixulyValue == DBNull.Value) ? String.Empty : strDonvixulyValue.ToString();
                    var intiddonvinhapValue = rdr["intiddonvinhap"];
                    cvd.intiddonvinhap = (intiddonvinhapValue == DBNull.Value) ? 0 : Convert.ToInt32(intiddonvinhapValue);
                    var intkhanValue = rdr["intkhan"];
                    cvd.intkhan = (intkhanValue == DBNull.Value) ? 0 : Convert.ToInt32(intkhanValue);

                    listCongVandens.Add(cvd);
                }

                rdr.Close();
                totalRows = (int)cmd.Parameters["@TotalRows"].Value;

            }
            return listCongVandens;

        }
    }
}
