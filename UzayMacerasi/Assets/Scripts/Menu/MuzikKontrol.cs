using UnityEngine;

public class MuzikKontrol : MonoBehaviour
{
    public static MuzikKontrol instance;

    AudioSource audioSource;
    void Awake()
    {
        Singleton();
        audioSource = GetComponent<AudioSource>();
    }
    void Singleton()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    public void MuzikCalistir(bool play)
    {
        if (play)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
