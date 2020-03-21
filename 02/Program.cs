using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  tugas2
{
    public class Taxi
    {
        public string NamaDriver { get; set;}
        public string OnDuty { get; set;}
        public string JumlahPenumpang { get; set;}

        public void InfoTaxi()
        {
            Console.WriteLine("Nama Driver : {0}", NamaDriver);
            if (OnDuty == true){
                status == "Yes";
            }else{
                status == "No";
            }
            Console.WriteLine("OnDuty : {0}", status);
            Console.WriteLine("Jumlah Penumpang : {0}", JumlahPenumpang);
        }
        public void JemputPenumpang()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void AntarPenumpang()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}