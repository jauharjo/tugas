namespace Tugas_CRUD.ClassAnak
{
    class KaryawanTetap : ClassInduk.Karyawan
    {
        public double GajiBulanan { get; set; }

        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}
