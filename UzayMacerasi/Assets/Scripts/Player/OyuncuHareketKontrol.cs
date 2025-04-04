using UnityEngine;

public class OyuncuHareketKontrol : MonoBehaviour
{
    Rigidbody2D _playerRigidbody;
    Animator _playerAnimator;
    [Header("Settings")]
    [SerializeField] float hiz = default;
    [SerializeField] float hizlanma = default;
    [SerializeField] float yavaslama = default;
    [SerializeField] float ziplamaKuvvet = default;
    [SerializeField] int anlikZiplamaSayisi = 0;
    [SerializeField] int maxZiplamaSayisi = 3;
    Joystick _joystick;
    ZiplaButonKontrol _ziplaButonKontrol;
    Vector2 velocity;
    bool ziplamis;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _joystick = FindFirstObjectByType<Joystick>();
        _ziplaButonKontrol = FindFirstObjectByType<ZiplaButonKontrol>();
        _playerAnimator = GetComponent<Animator>();
        _playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        KlavyedenKontrol();
#else
        KonsoldanKontrol();
#endif
    }

    void KlavyedenKontrol()
    {
        float hareketYon = Input.GetAxis("Horizontal");
        Vector2 scaleDeger = transform.localScale;

        if (hareketYon > 0) // sağ tarafa
        {
            scaleDeger.x = 0.4f;
            velocity.x = Mathf.MoveTowards(velocity.x, hareketYon * hiz, hizlanma * Time.deltaTime);
            _playerAnimator.SetBool("isWalking", true);
        }
        else if (hareketYon < 0) // sol tarafa
        {
            scaleDeger.x = -0.4f;
            velocity.x = Mathf.MoveTowards(velocity.x, hareketYon * hiz, hizlanma * Time.deltaTime);
            _playerAnimator.SetBool("isWalking", true);
        }
        else // durma
        {
            velocity.x = Mathf.MoveTowards(velocity.x, 0, yavaslama * Time.deltaTime);
            _playerAnimator.SetBool("isWalking", false);
        }
        transform.Translate(velocity * Time.deltaTime);
        transform.localScale = scaleDeger;

        if (Input.GetButtonDown("Jump"))
        {
            ZiplamayaBasladiginda();
        }
        if (Input.GetButtonUp("Jump"))
        {
            ZiplamaBittiginde();
        }
    }
    void KonsoldanKontrol()
    {
        float hareketYon = _joystick.Horizontal;
        Vector2 scaleDeger = transform.localScale;
        if (hareketYon > 0) // sağ tarafa
        {
            scaleDeger.x = 0.4f;
            velocity.x = Mathf.MoveTowards(velocity.x, hareketYon * hiz, hizlanma * Time.deltaTime);
            _playerAnimator.SetBool("isWalking", true);
        }
        else if (hareketYon < 0) // sol tarafa
        {
            scaleDeger.x = -0.4f;
            velocity.x = Mathf.MoveTowards(velocity.x, hareketYon * hiz, hizlanma * Time.deltaTime);
            _playerAnimator.SetBool("isWalking", true);
        }
        else // durma
        {
            velocity.x = Mathf.MoveTowards(velocity.x, 0, yavaslama * Time.deltaTime);
            _playerAnimator.SetBool("isWalking", false);
        }
        transform.Translate(velocity * Time.deltaTime);
        transform.localScale = scaleDeger;
        if (_ziplaButonKontrol.basildi == true && ziplamis == false)
        {
            ziplamis = true;
            ZiplamayaBasladiginda();

        }
        if (_ziplaButonKontrol.basildi == false && ziplamis == true)
        {
            ziplamis = false;
            ZiplamaBittiginde();
        }
    }
    void ZiplamayaBasladiginda()
    {
        if (anlikZiplamaSayisi < maxZiplamaSayisi)
        {
            FindFirstObjectByType<SesKontrol>().ZiplamaSesCal();
            _playerRigidbody.AddForce(Vector2.up * ziplamaKuvvet, ForceMode2D.Impulse);
            _playerAnimator.SetBool("isJumping", true);
            FindFirstObjectByType<SliderKontrol>().SliderDegerAyarla(maxZiplamaSayisi, anlikZiplamaSayisi);
        }
    }
    void ZiplamaBittiginde()
    {
        _playerAnimator.SetBool("isJumping", false);
        anlikZiplamaSayisi++;
        FindFirstObjectByType<SliderKontrol>().SliderDegerAyarla(maxZiplamaSayisi, anlikZiplamaSayisi);
    }
    public void ZiplamaSifirla()
    {
        anlikZiplamaSayisi = 0;
        FindFirstObjectByType<SliderKontrol>().SliderDegerAyarla(maxZiplamaSayisi, anlikZiplamaSayisi);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Olum")
        {
            FindFirstObjectByType<Olme>().Olunce();
        }
    }
    public void OyuncuYavasPlatformaBasinca()
    {
        _playerRigidbody.linearDamping = 8f;
    }
    public void OyuncuYavasPlatformdanCikinca()
    {
        _playerRigidbody.linearDamping = 4f;
    }
    public void OyunBittigindeKarakterDurumu()
    {
        Destroy(this.gameObject);
    }
}
