using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float Movement = 10;

    private GameController _gameController;
    public AudioClip fire;
    public AudioClip bangSmall;
    AudioSource audio;

	// Use this for initialization
	void Start ()
    {
        audio = GetComponent<AudioSource>();
        _gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>(); 
	}

    void FixedUpdate()
    {
        audio.PlayOneShot(fire);
        Vector3 forward = new Vector3(transform.forward.x, transform.forward.y, transform.forward.z);
        transform.position += Movement * forward * Time.deltaTime;
    }
    // Update is called once per frame
    void Update () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        audio.PlayOneShot(bangSmall);
        Destroy(other.gameObject);
        Destroy(gameObject);

        _gameController.IncrementScore(10);
    }
}
