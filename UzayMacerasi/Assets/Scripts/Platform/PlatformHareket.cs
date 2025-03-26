using UnityEngine;

public class PlatformHareket : MonoBehaviour
{
    PolygonCollider2D _polygonCollider2D;
    bool hareketEdiyorMu = true; // deneme için
    float platformHareketHizRandom = default;

    public bool HareketEdiyorMu
    {
        get => hareketEdiyorMu;
        set => hareketEdiyorMu = value;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _polygonCollider2D = GetComponent<PolygonCollider2D>();
        platformHareketHizRandom = Random.Range(0.5f, 1.0f);
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
        float hareketYonX = Mathf.PingPong(Time.time * platformHareketHizRandom, 2.0f);
        Vector2 pinpong = new Vector2(hareketYonX, transform.position.y);
        transform.position = pinpong;
    }
}
