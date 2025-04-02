using UnityEngine;
using UnityEngine.UI;

public class SliderKontrol : MonoBehaviour
{
    Slider _slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.value = 1f;
    }
    public void SliderDegerAyarla(int maks, int current)
    {
        int sliderDeger = maks - current;
        _slider.maxValue = maks;
        _slider.value = sliderDeger;
    }
}
