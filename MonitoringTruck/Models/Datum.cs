using System;

namespace MonitoringTruck.Models
{
    public class Datum
    {
        public string NO_JOB { get; set; }
        public string STATUS_TERAKHIR { get; set; }
        public string STOWAGE_PLAN { get; set; }
        public double BERAT_IN { get; set; }
        public DateTime CREATION_DATE { get; set; }
        public string STOWAGE { get; set; }
        public DateTime LAST_UPDATE_DATE { get; set; }
        public string NO_PNTP { get; set; }
        public string LAST_UPDATE_BY { get; set; }
        public string NO_SPMK { get; set; }
        public string PLAT_NO { get; set; }
        public int? HARI { get; set; }
        public string SHIFT { get; set; }
        public string NO_PPK { get; set; }
        public string NM_KAPAL { get; set; }
        public double? NETTO { get; set; }
        public object? NM_SOPIR { get; set; }
        public string NM_PETUGAS_IN { get; set; }
        public string? NM_PETUGAS_OUT { get; set; }
        public int CETAK_KE { get; set; }
        public DateTime? GATE_IN_DATE { get; set; }
        public double? BERAT_OUT { get; set; }
        public string KD_KEGIATAN { get; set; }
        public DateTime? GATE_OUT_DATE { get; set; }
    }
}
