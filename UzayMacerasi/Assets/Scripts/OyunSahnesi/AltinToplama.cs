using UnityEngine;

public class AltinToplama : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == "Ayak")
        {
            GetComponentInParent<Altin>().AltinKapat();
            FindFirstObjectByType<PuanHesapla>().AltinKazanildi();
        }
    }
}
