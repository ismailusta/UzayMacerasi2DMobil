using System.Collections.Generic;
using UnityEngine;

public class GezegenKontrol : MonoBehaviour
{
    List<GameObject> gezegenler = new List<GameObject>();
    List<GameObject> kullanilanGezegenler = new List<GameObject>();
    void Awake()
    {
        Object[] gezegenSprites = Resources.LoadAll("Gezegenler");
        for (int i = 1; i < gezegenSprites.Length; i++)
        {
            GameObject gezegen = new GameObject();
            SpriteRenderer _spriteRenderer = gezegen.AddComponent<SpriteRenderer>();
            _spriteRenderer.sprite = gezegenSprites[i] as Sprite;
            Color _spriteColor = _spriteRenderer.color;
            _spriteColor.a = 0.7f;
            _spriteRenderer.color = _spriteColor;
            gezegen.name = gezegenSprites[i].name;
            _spriteRenderer.sortingLayerName = "Gezegen";
            Vector2 pos = gezegen.transform.position;
            pos.x = -10;
            gezegen.transform.position = pos;
            gezegenler.Add(gezegen);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GezegenYerlestir(float refY)
    {
        float yukseklik = EkranHesaplayicisi.instance.EkranYuksekligi;
        float genislik = EkranHesaplayicisi.instance.EkranGenisligi;
        //1.Bolge
        float genislik1 = Random.Range(0, genislik);
        float yukseklik1 = Random.Range(refY, refY + yukseklik);
        GameObject gezegen = GetRandomGezegen();
        gezegen.transform.position = new Vector2(genislik1, yukseklik1);
        //2.Bolge
        float genislik2 = Random.Range(-genislik, 0);
        float yukseklik2 = Random.Range(refY, refY + yukseklik);
        GameObject gezegen2 = GetRandomGezegen();
        gezegen2.transform.position = new Vector2(genislik2, yukseklik2);
        //3.Bolge
        float genislik3 = Random.Range(-genislik, 0);
        float yukseklik3 = Random.Range(refY - yukseklik, refY);
        GameObject gezegen3 = GetRandomGezegen();
        gezegen2.transform.position = new Vector2(genislik3, yukseklik3);
        //4.Bolge
        float genislik4 = Random.Range(0, genislik);
        float yukseklik4 = Random.Range(refY - yukseklik, refY);
        GameObject gezegen4 = GetRandomGezegen();
        gezegen4.transform.position = new Vector2(genislik4, yukseklik4);
    }
    GameObject GetRandomGezegen()
    {
        if (gezegenler.Count > 0)
        {
            int random;
            if (gezegenler.Count == 1)
            {
                random = 0;
            }
            else
            {
                random = Random.Range(0, gezegenler.Count - 1);
            }
            GameObject gezegen = gezegenler[random];
            gezegenler.Remove(gezegen);
            kullanilanGezegenler.Add(gezegen);
            return gezegen;
        }
        else
        {
            for (int i = 0; i < 8; i++)
            {
                gezegenler.Add(kullanilanGezegenler[i]);
            }
            kullanilanGezegenler.RemoveRange(0, 8);
            int random = Random.Range(0, 8);
            GameObject gezegen = gezegenler[random];
            gezegenler.Remove(gezegen);
            kullanilanGezegenler.Add(gezegen);
            return gezegen;
        }
    }
}
