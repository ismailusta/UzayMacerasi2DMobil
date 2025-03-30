using UnityEngine;

public class Altin : MonoBehaviour
{
    [SerializeField] GameObject altinObjesi;
    public void AltinAc()
    {
        altinObjesi.SetActive(true);
    }
    public void AltinKapat()
    {
        altinObjesi.SetActive(false);
    }

}
