using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MezunTakipSistemi.Models
{
    public class Ogrenci
    {
        public int OgrenciID { get; set; }

        [Display(Name ="Adınız Soyadınız")]
        public string AdSoyad { get; set; }

        [Display(Name ="Mezun Olduğunuz Bölüm")]
        public string MezunOlduguBolum { get; set; }

        [Display(Name ="Şifre")]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }

        [Display(Name ="Şifre Tekrarı")]
        [DataType(DataType.Password)]
        public string SifreTekrari { get; set; }

        [DataType(DataType.Date)]
        public DateTime DogumTarihi { get; set; }

        public string DogumYeri { get; set; }
        public string Cinsiyet { get; set; }
        public string Uyruk { get; set; }
        public string MedeniDurum { get; set; }
        public string CepNo { get; set; }
        public string Adres { get; set; }
        public string LinkedinAdresi { get; set; }
    }
}