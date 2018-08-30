using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PCPartCrawler.Entity
{
    [Table("cpu")]
    class Cpu
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Specifications
        public string Manufacturer { get; set; }
        public string PartNumber { get; set; }
        public string Socket { get; set; }
        public float OperatingFrequency { get; set; }
        public float BoostFrequency { get; set; }
        public int CoresCount { get; set; }
        public int L1DataCache { get; set; }
        public int L1InstructionCache { get; set; }
        public int L2Cache { get; set; }
        public int L3Cache { get; set; }
        public int Lithography { get; set; }
        public int TDP { get; set; }
        public int MaxMemorySupported { get; set; }
        public bool IsHyperthreaded { get; set; }
        public bool IsCpuCoolerIncluded { get; set; }
    }
}
