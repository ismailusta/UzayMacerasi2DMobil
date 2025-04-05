using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    public AudioClip _ziplamaSes;
    public AudioClip _altinSes;
    public AudioClip _oyunBittiSes;
    AudioSource _audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();

    }
    public void ZiplamaSesCal()
    {
        _audioSource.clip = _ziplamaSes;
        _audioSource.Play();
    }

    public void AltinSesCal()
    {
        _audioSource.clip = _altinSes;
        _audioSource.Play();
    }
    public void OyunBittiSesCal()
    {
        _audioSource.clip = _oyunBittiSes;
        _audioSource.Play();
    }
}
