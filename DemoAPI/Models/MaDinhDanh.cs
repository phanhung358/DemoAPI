using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    class MaDinhDanh
    {
        [JsonProperty("data")]
        public List<ValueSet> ValueSets { get; set; }
    }

    class ValueSet
    {
        [JsonProperty("DonViID")]
        public string DonViID { get; set; }
        [JsonProperty("TenDonVi")]
        public string TenDonVi   { get; set; }
        [JsonProperty("MaDinhDanh")]
        public string MaDinhDanh { get; set; }
        [JsonProperty("MaDinhDanhCapTren")]
        public string MaDinhDanhCapTren { get; set; }
        [JsonProperty("QuanHuyen")]
        public QuanHuyen QuanHuyen { get; set; }
        [JsonProperty("PhuongXa")]
        public PhuongXa PhuongXa { get; set; }
        [JsonProperty("DiaChi")]
        public string DiaChi { get; set; }
        [JsonProperty("Email")]
        public string Email { get; set; }
        [JsonProperty("SoDienThoai")]
        public string SoDienThoai { get; set; }
        [JsonProperty("Website")]
        public string Website { get; set; }
        [JsonProperty("NhomDonVi")]
        public NhomDonVi NhomDonVi { get; set; }
        [JsonProperty("HieuLuc")]
        public string HieuLuc { get; set; }
        [JsonProperty("NgayCapNhat")]
        public string NgayCapNhat { get; set; }
    }

    class QuanHuyen
    {
        [JsonProperty("MaQuanHuyen")]
        public string MaQuanHuyen { get; set; }
        [JsonProperty("TenQuanHuyen")]
        public string TenQuanHuyen { get; set; }
    }

    class PhuongXa
    {
        [JsonProperty("MaPhuongXa")]
        public string MaPhuongXa { get; set; }
        [JsonProperty("TenPhuongXa")]
        public string TenPhuongXa { get; set; }
    }

    class NhomDonVi
    {
        [JsonProperty("NhomID")]
        public string NhomID { get; set; }
        [JsonProperty("TenNhom")]
        public string TenNhom { get; set; }
    }
}