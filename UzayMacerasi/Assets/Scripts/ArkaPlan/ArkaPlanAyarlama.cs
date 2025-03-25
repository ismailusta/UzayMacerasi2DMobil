using UnityEngine;

public class ArkaPlanAyarlama : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        Vector2 scaleDeger = transform.localScale;
        float spriteGenislik = spriteRenderer.size.x; // 512 ise 5,12 gibi oluyor
        float ekranYuksekligi = Camera.main.orthographicSize * 2f; // ikiyle çarpma sebebi kamera orta hem altında hem üstünde var
        float ekranGenisligi = ekranYuksekligi / Screen.height * Screen.width;
        scaleDeger.x = ekranGenisligi / spriteGenislik;
        transform.localScale = scaleDeger;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
