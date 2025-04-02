using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PuanHesapla : MonoBehaviour
{
    int puandegeri = 0;
    int altindegeri = 0;
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
        altindegeri++;
        _altinPuan.text = "X" + altindegeri;
    }
    public void OyunSonuDegerler()
    {
        PuanTopla = false;
        _textPuanOyunSonu.text = "Puan: " + puandegeri;
        _altinPuanOyunSonu.text = "X" + altindegeri;
    }
}
