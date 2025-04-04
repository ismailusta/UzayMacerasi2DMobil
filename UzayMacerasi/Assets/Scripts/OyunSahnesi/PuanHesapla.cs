using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PuanHesapla : MonoBehaviour
{
    int puandegeri = 0;
    int enYuksekPuan;
    int altindegeri = 0;
    int enYuksekAltin;
    bool PuanTopla = true;
    [SerializeField] TextMeshProUGUI _textPuan;
    [SerializeField] TextMeshProUGUI _altinPuan;
    [SerializeField] TextMeshProUGUI _textPuanOyunSonu;
    [SerializeField] TextMeshProUGUI _altinPuanOyunSonu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _textPuan.text = "Puan: " + puandegeri;
        _altinPuan.text = "X" + altindegeri;
    }

    // Update is called once per frame
    void Update()
    {
        if (PuanTopla == true)
        {
            puandegeri = (int)Camera.main.transform.position.y;
            _textPuan.text = "Puan: " + puandegeri;
        }
    }
    public void AltinKazanildi()
    {
        FindFirstObjectByType<SesKontrol>().AltinSesCal();
        altindegeri++;
        _altinPuan.text = "X" + altindegeri;
    }
    public void OyunSonuDegerler()
    {
        if (SeceneklerGenel.KolayDegerAl() == 1)
        {
            enYuksekPuan = SeceneklerGenel.KolayModDegerAlPuan();
            enYuksekAltin = SeceneklerGenel.KolayModDegerAlAltin();
            if (puandegeri > enYuksekPuan)
            {
                SeceneklerGenel.KolayModDegerAtaPuan(puandegeri);
            }
            if (altindegeri > enYuksekAltin)
            {
                SeceneklerGenel.KolayModDegerAtaAltin(altindegeri);
            }
        }
        if (SeceneklerGenel.OrtaDegerAl() == 1)
        {
            enYuksekPuan = SeceneklerGenel.OrtaModDegerAlPuan();
            enYuksekAltin = SeceneklerGenel.OrtaModDegerAlAltin();
            if (puandegeri > enYuksekPuan)
            {
                SeceneklerGenel.OrtaModDegerAtaPuan(puandegeri);
            }
            if (altindegeri > enYuksekAltin)
            {
                SeceneklerGenel.OrtaModDegerAtaAltin(altindegeri);
            }
        }
        if (SeceneklerGenel.ZorDegerAl() == 1)
        {
            enYuksekPuan = SeceneklerGenel.ZorModDegerAlPuan();
            enYuksekAltin = SeceneklerGenel.ZorModDegerAlAltin();
            if (puandegeri > enYuksekPuan)
            {
                SeceneklerGenel.ZorModDegerAtaPuan(puandegeri);
            }
            if (altindegeri > enYuksekAltin)
            {
                SeceneklerGenel.ZorModDegerAtaAltin(altindegeri);
            }
        }
        PuanTopla = false;
        _textPuanOyunSonu.text = "Puan: " + puandegeri;
        _altinPuanOyunSonu.text = "X" + altindegeri;
    }
}
