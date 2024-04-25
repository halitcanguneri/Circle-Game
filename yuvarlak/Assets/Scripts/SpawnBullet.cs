using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    public GameObject circlePrefab; // Daire prefab'�n� buraya s�r�kleyip b�rak�n
    public float spawnTime = 30f; // Dairelerin olu�turulma s�resi
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
        // Daireyi rastgele bir konumda olu�tur. Bu �rnek i�in ekran�n s�n�rlar�n� g�z �n�nde bulundurman�z gerekecek.
        Instantiate(circlePrefab, new Vector3(Random.Range(-randomx, randomy), Random.Range(-randomx, randomy), 0), Quaternion.identity);
    }

}
