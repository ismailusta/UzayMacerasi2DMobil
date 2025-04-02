using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnYuksekSkorKontrol : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _kolayPuan, _kolayAltin, _ortaPuan, _ortaAltin, _zorPuan, _zorAltin;
    [SerializeField] Button _geriDonButon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _geriDonButon.onClick.AddListener(() => AnaMenuyeDon());

        _kolayPuan.text = "Puan:" + SeceneklerGenel.KolayModDegerAlPuan();
        _kolayAltin.text = "X" + SeceneklerGenel.KolayModDegerAlAltin();

        _ortaPuan.text = "Puan:" + SeceneklerGenel.OrtaModDegerAlPuan();
        _ortaAltin.text = "X" + SeceneklerGenel.OrtaModDegerAlAltin();

        _zorPuan.text = "Puan:" + SeceneklerGenel.ZorModDegerAlPuan();
        _zorAltin.text = "X" + SeceneklerGenel.ZorModDegerAlAltin();
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
