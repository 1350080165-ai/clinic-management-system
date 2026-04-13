using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ToaThuoc
    {
        [Key]
        public string MaToaThuoc { get; set; }

        public string MaBN { get; set; }

        public string MaBS { get; set; }

        public string TrieuChung { get; set; }

        public string BenhDuocChuanDoan { get; set; }

        public DateTime NgayKham { get; set; }

        [ForeignKey("BenhNhan")]
        public virtual BenhNhan BenhNhan { get; set; }

        [ForeignKey("BacSi")]
        public virtual BacSi BacSi { get; set; }
    }
}