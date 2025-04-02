using Unity.VisualScripting;
using UnityEngine;

public static class SeceneklerGenel
{
    public static string _kolay = "Kolay";
    public static string _orta = "Orta";
    public static string _zor = "Zor";

    public static string _kolayModPuan = "KolayModPuan";
    public static string _ortaModPuan = "OrtaModPuan";
    public static string _zorModPuan = "ZorModPuan";

    public static string _kolayModAltin = "KolayModAltin";
    public static string _ortaModAltin = "OrtaModAltin";
    public static string _zorModAltin = "ZorModAltin";

    public static string _muzikAktif = "MuzikAktif";

    public static void KolayDegerAta(int kolay)
    {
        PlayerPrefs.SetInt(_kolay, kolay);
    }
    public static int KolayDegerAl()
    {
        return PlayerPrefs.GetInt(_kolay);
    }

    public static void OrtaDegerAta(int orta)
    {
        PlayerPrefs.SetInt(_orta, orta);
    }
    public static int OrtaDegerAl()
    {
        return PlayerPrefs.GetInt(_orta);
    }

    public static void ZorDegerAta(int zor)
    {
        PlayerPrefs.SetInt(_zor, zor);
    }
    public static int ZorDegerAl()
    {
        return PlayerPrefs.GetInt(_zor);
    }
    public static bool KayitVarmi()
    {
        return PlayerPrefs.HasKey(_kolay) || PlayerPrefs.HasKey(_orta) || PlayerPrefs.HasKey(_zor);
    }

    public static void KolayModDegerAtaPuan(int KolayModPuan)
    {
        PlayerPrefs.SetInt(_kolayModPuan, KolayModPuan);
    }
    public static int KolayModDegerAlPuan()
    {
        return PlayerPrefs.GetInt(_kolayModPuan);
    }

    public static void OrtaModDegerAtaPuan(int OrtaModPuan)
    {
        PlayerPrefs.SetInt(_ortaModPuan, OrtaModPuan);
    }
    public static int OrtaModDegerAlPuan()
    {
        return PlayerPrefs.GetInt(_ortaModPuan);
    }

    public static void ZorModDegerAtaPuan(int ZorModPuan)
    {
        PlayerPrefs.SetInt(_zorModPuan, ZorModPuan);
    }
    public static int ZorModDegerAlPuan()
    {
        return PlayerPrefs.GetInt(_zorModPuan);
    }

    public static void KolayModDegerAtaAltin(int KolayModAltin)
    {
        PlayerPrefs.SetInt(_kolayModAltin, KolayModAltin);
    }
    public static int KolayModDegerAlAltin()
    {
        return PlayerPrefs.GetInt(_kolayModAltin);
    }

    public static void OrtaModDegerAtaAltin(int OrtaModAltin)
    {
        PlayerPrefs.SetInt(_ortaModAltin, OrtaModAltin);
    }
    public static int OrtaModDegerAlAltin()
    {
        return PlayerPrefs.GetInt(_ortaModAltin);
    }

    public static void ZorModDegerAtaAltin(int ZorModAltin)
    {
        PlayerPrefs.SetInt(_zorModAltin, ZorModAltin);
    }
    public static int ZorModDegerAlAltin()
    {
        return PlayerPrefs.GetInt(_zorModAltin);
    }

    public static void MuzikAktifDegerAta(int MuzikAktif)
    {
        PlayerPrefs.SetInt(_muzikAktif, MuzikAktif);
    }
    public static int MuzikAktifDegerAl()
    {
        return PlayerPrefs.GetInt(_muzikAktif);
    }

    public static bool MuzikKayitVarmi()
    {
        return PlayerPrefs.HasKey(_muzikAktif);
    }
}
