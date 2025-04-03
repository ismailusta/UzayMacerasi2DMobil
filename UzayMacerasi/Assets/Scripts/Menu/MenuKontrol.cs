using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuKontrol : MonoBehaviour
{
    [SerializeField] List<Sprite> _muzikResimleri;
    [SerializeField] Button _baslatButton;
    [SerializeField] Button _enYuksekSkorButton;
    [SerializeField] Button _ayarlarButton;
    [SerializeField] Button _muzikButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _baslatButton.onClick.AddListener(() => OyunuBaslat());
        _enYuksekSkorButton.onClick.AddListener(() => EnYuksekSkor());
        _ayarlarButton.onClick.AddListener(() => Ayarlar());
        _muzikButton.onClick.AddListener(() => Muzik());
        if (SeceneklerGenel.KayitVarmi() == false)
        {
            SeceneklerGenel.KolayDegerAta(1);
        }
        if (SeceneklerGenel.MuzikKayitVarmi() == false)
        {
            SeceneklerGenel.MuzikAktifDegerAta(1);
        }
        MuzikDenetle();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OyunuBaslat()
    {
        SceneManager.LoadScene("OyunSahnesi");
    }
    void EnYuksekSkor()
    {
        SceneManager.LoadScene("EnYuksekSkorSahnesi");
    }
    void Ayarlar()
    {
        SceneManager.LoadScene("AyarlarSahnesi");
    }
    void Muzik()
    {
        Image varOlanResim = _muzikButton.GetComponent<Image>();
        if (SeceneklerGenel.MuzikAktifDegerAl() == 1)
        {
            SeceneklerGenel.MuzikAktifDegerAta(0);
            MuzikKontrol.instance.MuzikCalistir(false);
            varOlanResim.sprite = _muzikResimleri[1];
        }
        else
        {
            SeceneklerGenel.MuzikAktifDegerAta(1);
            MuzikKontrol.instance.MuzikCalistir(true);
            varOlanResim.sprite = _muzikResimleri[0];
        }
    }
    void MuzikDenetle()
    {
        Image varOlanResim = _muzikButton.GetComponent<Image>();
        if (SeceneklerGenel.MuzikAktifDegerAl() == 1)
        {
            MuzikKontrol.instance.MuzikCalistir(true);
            varOlanResim.sprite = _muzikResimleri[0];
        }
        if (SeceneklerGenel.MuzikAktifDegerAl() == 0)
        {
            MuzikKontrol.instance.MuzikCalistir(false);
            varOlanResim.sprite = _muzikResimleri[1];
        }
    }
}