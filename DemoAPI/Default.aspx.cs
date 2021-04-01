using DemoAPI.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoAPI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            addData();
        }

        private void addData()
        {
            var client = new RestClient("https://danhmuc.thuathienhue.gov.vn/danhmuc/madinhdanh/thaydoi?thoigian=20/1/2021");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Token", "16863762887E24BC4C2DACD1D327D17AD99046E3");
            IRestResponse response = client.Execute(request);

            var items = JsonConvert.DeserializeObject<MaDinhDanh>(response.Content);

            main.Controls.Clear();
            Table table = new Table();
            table.Width = Unit.Percentage(100);
            table.CssClass = "Vien_Bang";
            table.CellPadding = 3;
            table.CellSpacing = 1;
            table.BorderWidth = 0;

            TableRow row = new TableRow();
            TableCell cell = new TableCell();

            row = new TableRow();
            row.CssClass = "Dong_TieuDe";

            cell = new TableCell();
            cell.CssClass = "Cot_TieuDe";
            cell.Width = 30;
            cell.Text = "STT";
            row.Controls.Add(cell);

            cell = new TableCell();
            cell.CssClass = "Cot_TieuDe";
            cell.Text = "DonViID";
            row.Controls.Add(cell);

            cell = new TableCell();
            cell.CssClass = "Cot_TieuDe";
            cell.Text = "TenDonVi";
            row.Controls.Add(cell);

            cell = new TableCell();
            cell.CssClass = "Cot_TieuDe";
            cell.Text = "MaDinhDanh";
            row.Controls.Add(cell);

            cell = new TableCell();
            cell.CssClass = "Cot_TieuDe";
            cell.Text = "MaDinhDanhCapTren";
            row.Controls.Add(cell);

            cell = new TableCell();
            cell.CssClass = "Cot_TieuDe";
            cell.Text = "MaQuanHuyen";
            row.Controls.Add(cell);

            cell = new TableCell();
            cell.CssClass = "Cot_TieuDe";
            cell.Text = "TenQuanHuyen";
            row.Controls.Add(cell);

            cell = new TableCell();
            cell.CssClass = "Cot_TieuDe";
            cell.Text = "MaPhuongXa";
            row.Controls.Add(cell);

            cell = new TableCell();
            cell.CssClass = "Cot_TieuDe";
            cell.Text = "TenPhuongXa";
            row.Controls.Add(cell);

            cell = new TableCell();
            cell.CssClass = "Cot_TieuDe";
            cell.Text = "DiaChi";
            row.Controls.Add(cell);

            cell = new TableCell();
            cell.CssClass = "Cot_TieuDe";
            cell.Text = "Email";
            row.Controls.Add(cell);

            cell = new TableCell();
            cell.CssClass = "Cot_TieuDe";
            cell.Text = "SoDienThoai";
            row.Controls.Add(cell);

            cell = new TableCell();
            cell.CssClass = "Cot_TieuDe";
            cell.Text = "Website";
            row.Controls.Add(cell);

            cell = new TableCell();
            cell.CssClass = "Cot_TieuDe";
            cell.Text = "NhomID";
            row.Controls.Add(cell);

            cell = new TableCell();
            cell.CssClass = "Cot_TieuDe";
            cell.Text = "TenNhom";
            row.Controls.Add(cell);

            cell = new TableCell();
            cell.CssClass = "Cot_TieuDe";
            cell.Text = "HieuLuc";
            row.Controls.Add(cell);

            cell = new TableCell();
            cell.CssClass = "Cot_TieuDe";
            cell.Text = "NgayCapNhat";
            row.Controls.Add(cell);

            table.Controls.Add(row);

            int i = 0;
            foreach (var value in items.ValueSets)
            {
                string css = "Dong_Chan";
                if (i % 2 == 1)
                    css = "Dong_Le";
                row = new TableRow();
                row.CssClass = css;

                cell = new TableCell();
                cell.Text = (++i).ToString();
                row.Controls.Add(cell);

                cell = new TableCell();
                cell.Text = value.DonViID;
                row.Controls.Add(cell);

                cell = new TableCell();
                cell.Text = value.TenDonVi;
                row.Controls.Add(cell);

                cell = new TableCell();
                cell.Text = value.MaDinhDanh;
                row.Controls.Add(cell);

                cell = new TableCell();
                cell.Text = value.MaDinhDanhCapTren;
                row.Controls.Add(cell);

                cell = new TableCell();
                cell.Text = value.QuanHuyen.MaQuanHuyen;
                row.Controls.Add(cell);

                cell = new TableCell();
                cell.Text = value.QuanHuyen.TenQuanHuyen;
                row.Controls.Add(cell);

                cell = new TableCell();
                cell.Text = value.PhuongXa.MaPhuongXa;
                row.Controls.Add(cell);

                cell = new TableCell();
                cell.Text = value.PhuongXa.TenPhuongXa;
                row.Controls.Add(cell);

                cell = new TableCell();
                cell.Text = value.DiaChi;
                row.Controls.Add(cell);

                cell = new TableCell();
                cell.Text = value.Email;
                row.Controls.Add(cell);

                cell = new TableCell();
                cell.Text = value.SoDienThoai;
                row.Controls.Add(cell);

                cell = new TableCell();
                cell.Text = value.Website;
                row.Controls.Add(cell);

                cell = new TableCell();
                cell.Text = value.NhomDonVi.NhomID;
                row.Controls.Add(cell);

                cell = new TableCell();
                cell.Text = value.NhomDonVi.TenNhom;
                row.Controls.Add(cell);

                cell = new TableCell();
                cell.Text = value.HieuLuc;
                row.Controls.Add(cell);

                cell = new TableCell();
                cell.Text = value.NgayCapNhat;
                row.Controls.Add(cell);

                table.Controls.Add(row);
            }

            main.Controls.Add(table);
        }
    }
}