using UnityEngine;

public class YapiskanPlatformHareket : MonoBehaviour
{
    PolygonCollider2D _polygonCollider2D;
    bool hareketEdiyorMu; // deneme için
    float platformHareketHizRandom = default;

    public bool HareketEdiyorMu
    {
        get => hareketEdiyorMu;
        set => hareketEdiyorMu = value;
    }
    float min, max;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _polygonCollider2D = GetComponent<PolygonCollider2D>();
        platformHareketHizRandom = Random.Range(0.5f, 1.0f);
        if (transform.position.x > 0) // sağda kalanlar ekranın ortaya bolümünde
        {
            // _polygonCollider2D.bounds.extends.x bu da aynı değeri veriyo
            min = _polygonCollider2D.bounds.size.x / 2;
            max = EkranHesaplayicisi.instance.EkranGenisligi - _polygonCollider2D.bounds.size.x / 2;
        }
        else// solda kalanlar ekranın ortaya bolümunde
        {
            min = -EkranHesaplayicisi.instance.EkranGenisligi + _polygonCollider2D.bounds.size.x / 2;
            max = -_polygonCollider2D.bounds.size.x / 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hareketEdiyorMu)
        {
            PlatformHareketEttir();
        }
    }
    void PlatformHareketEttir()
    {
        float hareketYonX = Mathf.PingPong(Time.time * platformHareketHizRandom, max - min) + min;
        Vector2 pinpong = new Vector2(hareketYonX, transform.position.y);
        transform.position = pinpong;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ayak")
        {
            GameObject.FindGameObjectWithTag("Player").transform.parent = transform;
            GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<OyuncuHareketKontrol>().ZiplamaSifirla();
        }
    }
}
