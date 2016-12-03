using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] Asteroids;

    public float AsteroidColddown;

    public float MinDistance;
    public float MaxDistance;

	void Start ()
    {
        StartCoroutine(SpawnAsteroidCoroutine());
    }
	
	void Update ()
    {
        
    }

    private IEnumerator SpawnAsteroidCoroutine()
    {
        while(true)
        {
            SpawnAsteroid();

            yield return new WaitForSeconds(AsteroidColddown);
        }
    }

    private void SpawnAsteroid()
    {
        int asteroidIndex = (int) (Random.value * Asteroids.Length);

        float x = Camera.main.transform.position.x + (MinDistance + Random.Range(-1,1) * MaxDistance);
        float y = Camera.main.transform.position.y + (MinDistance + Random.Range(-1,1) * MaxDistance);
        float z = Camera.main.transform.position.z + (MinDistance + Random.Range(-1,1) * MaxDistance);
        Vector3 position = new Vector3(x,y,z);

        Instantiate(Asteroids[asteroidIndex], position, Quaternion.identity);
    }
}
