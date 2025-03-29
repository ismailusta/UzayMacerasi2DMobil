using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AyarlarKontrol : MonoBehaviour
{
    [SerializeField] Button _geriDonButon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _geriDonButon.onClick.AddListener(() => AnaMenuyeDon());
    }

    // Update is called once per frame
    void Update()
    {

    }
    void AnaMenuyeDon()
    {
        SceneManager.LoadScene("Menu");
    }
}
