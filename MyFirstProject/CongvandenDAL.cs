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
        //Attributes for gridview display
        public Nullable<int> intid { get; set; }
        public Nullable<int> intsoden { get; set; }
        public string strkyhieu { get; set; }
        public Nullable<DateTime> strngayden { get; set; }
        public string strnoigui { get; set; }
        public string strtrichyeu { get; set; }
        public string strDonvixuly { get; set; }
        public Nullable<int> intiddonvinhap { get; set; }
        public Nullable<int> intkhan { get; set; }
        //Full attributes for details display
        public string strdonvinhap { get; set; }
        public Nullable<DateTime> strngaytao { get; set; }
        public Nullable<int> intidnguoitao { get; set; }
        public string strnguoitao { get; set; }
        public Nullable<int> intidphanloaicongvanden { get; set; }
        public Nullable<DateTime> strngayky { get; set; }
        public string strkhan { get; set; }
        public string strmat { get; set; }
        public string strnguoiky { get; set; }
        public string strtenkhoi { get; set; }
        public string strNhomcoquan { get; set; }
        public string strnoiphathanh { get; set; }
        public string strdonviphoihop { get; set; }
        public string strhanxuly { get; set; }
        public Nullable<int> intsoban { get; set; }
        public string strykienlanhdao { get; set; }
        public Nullable<int> intidtinhtrangxuly { get; set; }
        public string strtinhtrangxuly { get; set; }
        public string strloaivb { get; set; }
        public Nullable<int> intsotraloi { get; set; }
        public Nullable<int> intSocongvantraloi { get; set; }
        public Nullable<int> intLinhvuc { get; set; }
        public string strLinhvuc { get; set; }
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
            using (SqlCommand cmd = new SqlCommand("SP_Congvanden_by_PageIndex_and_PageSize", con))
            {
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
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        Congvanden cvd = new Congvanden();
                        cvd.intid = Convert.ToInt32(rdr["intid"]);
                        cvd.intsoden = GetValue<int>(rdr["intsoden"]);
                        cvd.strkyhieu = GetText(rdr["strkyhieu"]);
                        cvd.strngayden = GetValue<DateTime>(rdr["strngayden"]);
                        cvd.strnoigui = GetText(rdr["strnoigui"]);
                        cvd.strtrichyeu = GetText(rdr["strtrichyeu"]);
                        cvd.strDonvixuly = GetText(rdr["strDonvixuly"]);
                        cvd.intiddonvinhap = GetValue<int>(rdr["intiddonvinhap"]);
                        cvd.intkhan = GetValue<int>(rdr["intkhan"]);

                        listCongVandens.Add(cvd);
                    }
                }
                totalRows = (int)cmd.Parameters["@TotalRows"].Value;
            }
            return listCongVandens;
        }

        public static Congvanden GetCongvanden(int intid)
        {
            Congvanden cvd = new Congvanden();
            string CS = ConfigurationManager.ConnectionStrings["NetOffice2013_VPCPConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            using (SqlCommand cmd = new SqlCommand("SP_Congvanden_Details", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramCongvandenID = new SqlParameter();
                paramCongvandenID.ParameterName = "@intid";
                paramCongvandenID.Value = intid;
                cmd.Parameters.Add(paramCongvandenID);

                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        cvd.intid = intid;
                        cvd.intsoden = GetValue<int>(rdr["intsoden"]);
                        cvd.strkyhieu = GetText(rdr["strkyhieu"]);
                        cvd.strngayden = GetValue<DateTime>(rdr["strngayden"]);
                        //cvd.strnoigui = GetText(rdr["strnoigui"]);
                        cvd.strtrichyeu = GetText(rdr["strtrichyeu"]);
                        cvd.strDonvixuly = GetText(rdr["strDonvixuly"]);
                        cvd.intiddonvinhap = GetValue<int>(rdr["intiddonvinhap"]);
                        cvd.intkhan = GetValue<int>(rdr["intkhan"]);
                        //More details
                        cvd.strngaytao = GetValue<DateTime>(rdr["strngaytao"]);
                        cvd.intidnguoitao = GetValue<int>(rdr["intidnguoitao"]);
                        cvd.intidphanloaicongvanden = GetValue<int>(rdr["intidphanloaicongvanden"]);
                        cvd.strngayky = GetValue<DateTime>(rdr["strngayky"]);
                        //cvd.strkhan = GetText(rdr["strkhan"]);
                        //cvd.strmat = GetText(rdr["strkhan"]);
                        cvd.strnguoiky = GetText(rdr["strnguoiky"]);
                        //cvd.strtenkhoi = GetText(rdr["strtenkhoi"]);
                        cvd.strNhomcoquan = GetText(rdr["strNhomcoquan"]);
                        cvd.strnoiphathanh = GetText(rdr["strnoiphathanh"]);
                        cvd.strdonviphoihop = GetText(rdr["strdonviphoihop"]);
                        cvd.strhanxuly = GetText(rdr["strhanxuly"]);
                        cvd.intsoban = GetValue<int>(rdr["intsoban"]);
                        cvd.strykienlanhdao = GetText(rdr["strykienlanhdao"]);
                        cvd.intidtinhtrangxuly = GetValue<int>(rdr["intidtinhtrangxuly"]);
                        //cvd.strloaivb = GetText(rdr["strloaivb"]);
                        cvd.intsotraloi = GetValue<int>(rdr["intsotraloi"]);
                        //cvd.intSocongvantraloi = GetValue<int>(rdr["intSocongvantraloi"]);
                        cvd.intLinhvuc = GetValue<int>(rdr["intLinhvuc"]);
                    }
                    //Muc do khan
                    if (rdr.NextResult())
                    {
                        while (rdr.Read())
                        {
                            cvd.strkhan = GetText(rdr["strtentinhchatvb"]);
                        }
                    }
                    //Muc do mat
                    if (rdr.NextResult())
                    {
                        while (rdr.Read())
                        {
                            cvd.strmat = GetText(rdr["strtentinhchatvb"]);
                        }
                    }
                    //Ten don vi nhap
                    if (rdr.NextResult())
                    {
                        while (rdr.Read())
                        {
                            cvd.strdonvinhap = GetText(rdr["strtendonvi"]);
                        }
                    }
                    //Ten nguoi tao
                    if (rdr.NextResult())
                    {
                        while (rdr.Read())
                        {
                            cvd.strnguoitao = GetText(rdr["strhoten"]);
                        }
                    }
                    //Linh vuc
                    if (rdr.NextResult())
                    {
                        while (rdr.Read())
                        {
                            cvd.strLinhvuc = GetText(rdr["strTenlinhvuc"]);
                        }
                    }
                    //Tinh trang xu ly
                    if (rdr.NextResult())
                    {
                        while (rdr.Read())
                        {
                            cvd.strtinhtrangxuly = GetText(rdr["strTenhinhthuc"]);
                        }
                    }

                }
            }
            return cvd;
        }

        public static T? GetValue<T>(object data) where T : struct
        {
            if (data == DBNull.Value)
                return default(T?);
            return data as T?;
        }

        public static string GetText(object data)
        {
            if (data == DBNull.Value)
                return default(string);
            return data as string;
        }
    }
}
