using UnityEngine;

public class EkranHesaplayicisi : MonoBehaviour
{
    // Singleton bir classtan sadece bir örnek yaratmak farklı bi nesne varsa yok etme 
    // diğer tüm classlar bu classa örnek üzerinden erişecek. 
    public static EkranHesaplayicisi instance;
    float ekranGenisligi, ekranYuksekligi;

    public float EkranGenisligi
    {
        get => ekranGenisligi;
    }
    public float EkranYuksekligi
    {
        get => ekranYuksekligi;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        ekranYuksekligi = Camera.main.orthographicSize;
        ekranGenisligi = ekranYuksekligi * Camera.main.aspect;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
