using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GeriDonButonScript : MonoBehaviour
{
    Button _geriDonButon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _geriDonButon = GetComponent<Button>();
        _geriDonButon.onClick.AddListener(() => AnaMenuyeDon());
    }
    void AnaMenuyeDon()
    {
        SceneManager.LoadScene("Menu");
    }
}
