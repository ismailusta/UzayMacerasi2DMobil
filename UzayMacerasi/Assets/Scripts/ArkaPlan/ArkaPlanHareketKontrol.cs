using UnityEngine;

public class ArkaPlanHareketKontrol : MonoBehaviour
{
    float arkaPlanKonumY;
    float mesafe = 10.24f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        arkaPlanKonumY = transform.position.y;
        FindFirstObjectByType<GezegenKontrol>().GezegenYerlestir(arkaPlanKonumY);
    }

    // Update is called once per frame
    void Update()
    {
        if (arkaPlanKonumY + mesafe < Camera.main.transform.position.y)
        {
            ArkaPlanHareketEttir();
        }

    }
    void ArkaPlanHareketEttir()
    {
        arkaPlanKonumY += mesafe * 2;
        FindFirstObjectByType<GezegenKontrol>().GezegenYerlestir(arkaPlanKonumY);
        Vector2 newPos = new Vector2(0, arkaPlanKonumY);
        transform.position = newPos;
    }
}
