using UnityEngine;

public class KameraHareket : MonoBehaviour
{
    float hiz;
    float hizlanma;
    float maksimumHiz;
    bool hareketEdiyorMu = true; // deneme amacı
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hiz = 0.5f;
        hizlanma = 0.05f;
        maksimumHiz = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (hareketEdiyorMu)
        {
            KamerayiHareketEttir();
        }
    }
    void KamerayiHareketEttir()
    {
        transform.position += transform.up * hiz * Time.deltaTime;
        hiz += hizlanma * Time.deltaTime;
        if (hiz > maksimumHiz) { hiz = maksimumHiz; }
        Debug.Log(hiz);
    }
}
