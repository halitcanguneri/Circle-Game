using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    public GameObject circlePrefab; // Daire prefab'ýný buraya sürükleyip býrakýn
    public float spawnTime = 30f; // Dairelerin oluþturulma süresi
    public float randomx, randomy;

    private void Start()
    {
        StartCoroutine(SpawnCircleRoutine());
    }

    private IEnumerator SpawnCircleRoutine()
    {
        while (true) // Sonsuza dek devam et
        {
            yield return new WaitForSeconds(spawnTime);
            SpawnCircle();
        }
    }

    private void SpawnCircle()
    {
        // Daireyi rastgele bir konumda oluþtur. Bu örnek için ekranýn sýnýrlarýný göz önünde bulundurmanýz gerekecek.
        Instantiate(circlePrefab, new Vector3(Random.Range(-randomx, randomy), Random.Range(-randomx, randomy), 0), Quaternion.identity);
    }

}
