using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIKontrol : MonoBehaviour
{
    public GameObject OyunBittiUI;
    public GameObject joystick;
    public GameObject slider;
    public GameObject ziplaButon;
    public GameObject geriDon;
    public Button AnaMenuyeDon;
    public Button TekrarOyna;
    public GameObject tabela;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OyunBittiUI.SetActive(false);
        UIAc();
        AnaMenuyeDon.onClick.AddListener(() => SceneManager.LoadScene("Menu"));
        TekrarOyna.onClick.AddListener(() => SceneManager.LoadScene("OyunSahnesi"));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UIAc()
    {
        joystick.SetActive(true);
        slider.SetActive(true);
        ziplaButon.SetActive(true);
        geriDon.SetActive(true);
        tabela.SetActive(true);
    }
    public void UIKapat()
    {
        joystick.SetActive(false);
        slider.SetActive(false);
        ziplaButon.SetActive(false);
        geriDon.SetActive(false);
        tabela.SetActive(false);
    }
}
