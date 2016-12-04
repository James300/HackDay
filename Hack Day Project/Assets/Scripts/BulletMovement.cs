using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float Movement = 10;

    private GameController _gameController;

	// Use this for initialization
	void Start ()
    {
        _gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>(); 
	}

    void FixedUpdate()
    {
        Vector3 forward = new Vector3(transform.forward.x, transform.forward.y, transform.forward.z);
        transform.position += Movement * forward * Time.deltaTime;
    }
    // Update is called once per frame
    void Update () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);

        _gameController.IncrementScore(10);
    }
}
