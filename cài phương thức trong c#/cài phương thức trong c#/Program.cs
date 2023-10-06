using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace cai_dat_phuong_thuc
{
    public class HocPhan
    {
        public String MaHP = "023092004";
        public String GetMaHP()
        {
            return MaHP;
        }
        public void SetMaHP(String MaHP_moi)
        {
            MaHP = MaHP_moi;
        }
        public String TenHP = "Co So Du Lieu";
        public String GetTenHP()
        {
            return TenHP;
        }
        public void SetTenHP(String TenHP_moi)
        {
            TenHP = TenHP_moi;
        }
        protected UInt32 SoTCHP = 4;
        public UInt32 GetSoTCHP()
        {
            return SoTCHP;
        }
        public void SetSoTCHP(UInt32 SoTc_moi)
        {
            SoTCHP = SoTc_moi;
        }

        protected String MotaHP = "Rat la nhuc dau nha";
        private UInt32 SoTietLT = 15;
        private UInt32 SoTietTH = 30;
        
        
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            HocPhan hp = new HocPhan();
            Console.WriteLine("MaHP = {0}; \n TenHP = {1}", hp.MaHP, hp.TenHP);
            hp.SetMaHP("12345");
            hp.SetTenHP("Lap Trinh Huong Doi Tuong");
            Console.WriteLine("MaHP = {0}; \n TenHP = {1}", hp.MaHP, hp.TenHP);
            Console.ReadKey();
        }
    }
}