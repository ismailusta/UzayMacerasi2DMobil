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
        if (SeceneklerGenel.KolayDegerAl() == 1)
        {
            hiz = 0.3f;
            hizlanma = 0.03f;
            maksimumHiz = 1.5f;
        }
        if (SeceneklerGenel.OrtaDegerAl() == 1)
        {
            hiz = 0.5f;
            hizlanma = 0.05f;
            maksimumHiz = 2f;
        }
        if (SeceneklerGenel.ZorDegerAl() == 1)
        {
            hiz = 0.8f;
            hizlanma = 0.08f;
            maksimumHiz = 2.5f;
        }

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
    }
    public void HareketiDurdur() { hareketEdiyorMu = false; }
}
