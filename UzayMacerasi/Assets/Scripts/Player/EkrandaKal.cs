using UnityEngine;

public class EkrandaKal : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -EkranHesaplayicisi.instance.EkranGenisligi)
        {
            Vector2 temp = transform.position;
            temp.x = -EkranHesaplayicisi.instance.EkranGenisligi;
            transform.position = temp;
        }
        else if (transform.position.x > EkranHesaplayicisi.instance.EkranGenisligi)
        {
            Vector2 temp = transform.position;
            temp.x = EkranHesaplayicisi.instance.EkranGenisligi;
            transform.position = temp;
        }
    }
}
