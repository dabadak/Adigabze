using System.ComponentModel.DataAnnotations;

namespace Adigabze.DAL.Enums
{
    /// <summary>
    /// SozcukTuru  
    /// 1		İsim
    /// 2		Sıfat
    /// 3       Zamir
    /// 4       Zarf
    /// 5       Edat
    /// 6       Bağlaç
    /// 7       Ünlem
    /// 8       Fiil
    /// 9       Fiilimsi
    /// </summary>
    public enum SozcukTuru
    {
        [Display(Name = "İsim")]
        Isim = 1,
        [Display(Name = "Sıfat")]
        Sıfat = 2,
        [Display(Name = "Zamir")]
        Zamir = 3,
        [Display(Name = "Zarf")]
        Zarf = 4,
        [Display(Name = "Edat")]
        Edat = 5,
        [Display(Name = "Bağlaç")]
        Baglac = 6,
        [Display(Name = "Ünlem")]
        Unlem = 7,
        [Display(Name = "Fiil")]
        Fiil = 8,
        [Display(Name = "Fiilimsi")]
        Fiilimsi = 9,
    }

    /// <summary>
    /// Avrupa Dilleri Ortak Çerçeve Programı
    /// Öğrenim Seviyeleri
    /// </summary>
    public enum OgrenimSeviyesi
    {
        [Display(Name = "A1")]
        A1 = 1,
        [Display(Name = "A2")]
        A2 = 2,
        [Display(Name = "B1")]
        B1 = 3,
        [Display(Name = "B2")]
        B2 = 4,
        [Display(Name = "C1")]
        C1 = 5,
        [Display(Name = "C2")]
        C2 = 6,
    }

    public enum SozcukTipi
    {
        [Display(Name = "Sözcük")]
        Sozcuk = 1,
    }

    /// <summary>
    /// 1   Geçişli
    /// 2   Geçişsiz
    /// </summary>
    public enum FiilCatisi
    {
        [Display(Name = "Geçişli")]
        Gecisli = 1,
        [Display(Name = "Geçişsiz")]
        Gecissiz = 2,
    }

    /// <summary>
    /// 1   Ön Ek
    /// 2   Son Ek
    /// </summary>
    public enum SozcukEkTipi
    {
        [Display(Name = "Ön Ek")]
        OnEk = 1,
        [Display(Name = "Son Ek")]
        SonEk = 2,
    }

    /// <summary>
    /// 1   Yapım Eki
    /// 2   Çekim Eki
    /// </summary>
    public enum SozcukEkTuru
    {
        [Display(Name = "Yapım Eki")]
        YapimEki = 1,
        [Display(Name = "Çekim Eki")]
        CekimEki = 2,
    }
}
