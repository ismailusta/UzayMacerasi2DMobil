using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AyarlarKontrol : MonoBehaviour
{
    [SerializeField] Button _geriDonButon;
    [SerializeField] Button _kolayButton;
    [SerializeField] Button _ortaButton;
    [SerializeField] Button _zorButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _geriDonButon.onClick.AddListener(() => AnaMenuyeDon());
        _kolayButton.onClick.AddListener(() => DenemeKolay());
        _ortaButton.onClick.AddListener(() => DenemeOrta());
        _zorButton.onClick.AddListener(() => DenemeZor());
        if (SeceneklerGenel.KolayDegerAl() == 1)
        {
            _kolayButton.interactable = false;
            _ortaButton.interactable = true;
            _zorButton.interactable = true;
        }
        if (SeceneklerGenel.OrtaDegerAl() == 1)
        {
            _kolayButton.interactable = true;
            _ortaButton.interactable = false;
            _zorButton.interactable = true;
        }
        if (SeceneklerGenel.ZorDegerAl() == 1)
        {
            _kolayButton.interactable = true;
            _ortaButton.interactable = true;
            _zorButton.interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void AnaMenuyeDon()
    {
        SceneManager.LoadScene("Menu");
    }
    public void SeviyeBelirle(string seviye)
    {
        switch (seviye)
        {
            case "Kolay":
                SeceneklerGenel.KolayDegerAta(1);
                SeceneklerGenel.OrtaDegerAta(0);
                SeceneklerGenel.ZorDegerAta(0);
                _kolayButton.interactable = false;
                _ortaButton.interactable = true;
                _zorButton.interactable = true;
                break;
            case "Orta":
                SeceneklerGenel.KolayDegerAta(0);
                SeceneklerGenel.OrtaDegerAta(1);
                SeceneklerGenel.ZorDegerAta(0);
                _kolayButton.interactable = true;
                _ortaButton.interactable = false;
                _zorButton.interactable = true;
                break;
            case "Zor":
                SeceneklerGenel.KolayDegerAta(0);
                SeceneklerGenel.OrtaDegerAta(0);
                SeceneklerGenel.ZorDegerAta(1);
                _kolayButton.interactable = true;
                _ortaButton.interactable = true;
                _zorButton.interactable = false;
                break;
        }
    }
    void DenemeKolay()
    {
        SeviyeBelirle("Kolay");
    }
    void DenemeOrta()
    {
        SeviyeBelirle("Orta");
    }
    void DenemeZor()
    {
        SeviyeBelirle("Zor");
    }
}
