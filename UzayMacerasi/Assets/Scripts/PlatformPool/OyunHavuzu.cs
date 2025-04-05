using System.Collections.Generic;
using UnityEngine;

public class OyunHavuzu : MonoBehaviour
{
    [SerializeField] GameObject _platformPrefab;
    [SerializeField] GameObject _olumculPlatformPrefab;
    [SerializeField] GameObject _yapiskanPlatformPrefab;
    [SerializeField] GameObject _playerPrefab;
    List<GameObject> _platformsList = new List<GameObject>();

    Vector2 platformPosition;
    Vector2 playerPosition;
    [SerializeField] float _platformArasiMesafe = default;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlatformOlustur();
    }

    // Update is called once per frame
    void Update()
    {
        if (_platformsList[_platformsList.Count - 1].transform.position.y <
            Camera.main.transform.position.y + EkranHesaplayicisi.instance.EkranYuksekligi)
        {
            AlttanUstePlatformGetir();
        }

    }
    void PlatformOlustur()
    {
        platformPosition = new Vector2(0, 0);
        playerPosition = new Vector2(0, 0.5f);
        GameObject player = Instantiate(_playerPrefab, playerPosition, Quaternion.identity);

        GameObject ilkPlatform = Instantiate(_platformPrefab, platformPosition, Quaternion.identity);
        _platformsList.Add(ilkPlatform);
        ilkPlatform.GetComponent<PlatformHareket>().HareketEdiyorMu = false;
        PlatformYeriniDegis();

        GameObject yapiskanPlatform = Instantiate(_yapiskanPlatformPrefab, platformPosition, Quaternion.identity);
        _platformsList.Add(yapiskanPlatform);
        yapiskanPlatform.GetComponent<YapiskanPlatformHareket>().HareketEdiyorMu = true;
        PlatformYeriniDegis();

        for (int i = 0; i < 7; i++)
        {
            GameObject platform = Instantiate(_platformPrefab, platformPosition, Quaternion.identity);
            _platformsList.Add(platform);
            platform.GetComponent<PlatformHareket>().HareketEdiyorMu = true;
            if (i % 2 == 0)
            {
                platform.GetComponent<Altin>().AltinAc();
            }
            PlatformYeriniDegis();
        }
        GameObject olumculPlatform = Instantiate(_olumculPlatformPrefab, platformPosition, Quaternion.identity);
        _platformsList.Add(olumculPlatform);
        olumculPlatform.GetComponent<OlumculPlatformHareket>().HareketEdiyorMu = true;
        PlatformYeriniDegis();
    }
    void AlttanUstePlatformGetir()
    {
        for (int i = 0; i < 5; i++)
        {
            // Ekranda en son platforma gelince kamera en son gösterilen 5 platformu geçmişe atıp bu 5 den once gösterilen
            // 5 platform diziniyle yer degistiriyor. 
            GameObject _temp;
            _temp = _platformsList[i + 5];
            _platformsList[i + 5] = _platformsList[i];
            _platformsList[i] = _temp;
            _platformsList[i + 5].transform.position = platformPosition;
            if (_platformsList[i + 5].tag == "Platform" || _platformsList[i + 5].tag == "YapiskanPlatform")
            {
                _platformsList[i + 5].GetComponent<Altin>().AltinKapat();
                float rastgeleRandom = Random.Range(0f, 1f);
                if (rastgeleRandom > 0.5f)
                {
                    _platformsList[i + 5].GetComponent<Altin>().AltinAc();
                }
            }
            PlatformYeriniDegis();
        }

    }
    void PlatformYeriniDegis()
    {
        platformPosition.y += _platformArasiMesafe;
        SiraliYerDegis();
        RandomYerDegis();

    }
    void RandomYerDegis()
    {
        float randomKey = Random.Range(0f, 1f);
        if (randomKey < 0.5f)
        {
            platformPosition.x = EkranHesaplayicisi.instance.EkranGenisligi / 2;
        }
        else if (randomKey > 0.5f)
        {
            platformPosition.x = -EkranHesaplayicisi.instance.EkranGenisligi / 2;
        }
    }
    bool yon = true;
    void SiraliYerDegis()
    {
        if (yon)
        {
            platformPosition.x = EkranHesaplayicisi.instance.EkranGenisligi / 2;
            yon = false;
        }
        else
        {
            platformPosition.x = -EkranHesaplayicisi.instance.EkranGenisligi / 2;
            yon = true;
        }
    }
}
