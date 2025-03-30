using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ZiplaButonKontrol : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool basildi;
    public void OnPointerDown(PointerEventData eventData)
    {
        basildi = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        basildi = false;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
