using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140027.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }

        [Required(ErrorMessage = "Tgl peminjaman wajib diisi")]
        public DateTime? TglPengembalian { get; set; }
        public int? Denda { get; set; }
        public int? IdPeminjaman { get; set; }

        [Required(ErrorMessage = "Denda wajib diisi")]
        public int? IdKondisi { get; set; }

        public KondisiKendaraan IdKondisiNavigation { get; set; }
        public Peminjaman IdPeminjamanNavigation { get; set; }
    }
}
