using UnityEngine;

public class Olme : MonoBehaviour
{
    UIKontrol uIKontrol;
    PuanHesapla _puanHesapla;
    void Start()
    {
        uIKontrol = FindFirstObjectByType<UIKontrol>();
        _puanHesapla = FindFirstObjectByType<PuanHesapla>();
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void Olunce()
    {
        uIKontrol.OyunBittiUI.SetActive(true);
        FindFirstObjectByType<OyuncuHareketKontrol>().OyunBittigindeKarakterDurumu();
        FindFirstObjectByType<KameraHareket>().HareketiDurdur();
        uIKontrol.UIKapat();
        _puanHesapla.OyunSonuDegerler();
    }
}
