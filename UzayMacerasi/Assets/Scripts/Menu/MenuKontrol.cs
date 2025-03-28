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

    bool muzikAcikMi = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _baslatButton.onClick.AddListener(() => OyunuBaslat());
        _enYuksekSkorButton.onClick.AddListener(() => EnYuksekSkor());
        _ayarlarButton.onClick.AddListener(() => Ayarlar());
        _muzikButton.onClick.AddListener(() => Muzik());
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
        if (muzikAcikMi)
        {
            muzikAcikMi = false;
            varOlanResim.sprite = _muzikResimleri[1];
        }
        else
        {
            muzikAcikMi = true;
            varOlanResim.sprite = _muzikResimleri[0];
        }
    }
}