using TMPro;
using UnityEngine;

public class PuanHesapla : MonoBehaviour
{
    int puandegeri = 0;
    int altindegeri = 0;
    [SerializeField] TextMeshProUGUI _textPuan;
    [SerializeField] TextMeshProUGUI _altinPuan;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _textPuan.text = "Puan: " + puandegeri;
        _altinPuan.text = "X" + altindegeri;
    }

    // Update is called once per frame
    void Update()
    {
        puandegeri = (int)Camera.main.transform.position.y;
        _textPuan.text = "Puan: " + puandegeri;
    }
    public void AltinKazanildi()
    {
        altindegeri++;
        _altinPuan.text = "X" + altindegeri;
    }
}
