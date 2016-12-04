using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject[] Asteroids;

    public float AsteroidColddown = 0.25f;

    public float MinDistance = 40;
    public float MaxDistance = 5;

    private Text _scoreText;
    private int _score;

	void Start ()
    {
        _scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
        _score = 0;

        UpdateScore();

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

    public void IncrementScore(int amount)
    {
        _score += amount;
        UpdateScore();
    }

    public void UpdateScore()
    {
        _scoreText.text = "S C O R E: " + _score;
    }
}
