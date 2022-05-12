namespace CMIS4API.Models
{
    public class DM_CPHI_VANCHUYEN
    {
        public string MA_DVIQLY { get; set; }
        public string MA_CPHI_VCHUYEN { get; set; }
        public string TEN_CPHI_VCHUYEN { get; set; }
        public int DON_GIA { get; set; }
        public float HE_SO { get; set; }
        public DateOnly NGAY_TAO { get; set; }
        public string NGUOI_TAO { get; set; }
        public DateOnly NGAY_SUA { get; set; }
        public string NGUOI_SUA { get; set; }   

        public int TRANG_THAI { get; set; }
    }
}
