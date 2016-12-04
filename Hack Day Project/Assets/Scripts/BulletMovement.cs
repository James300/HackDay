using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public GameObject Explosion;

    public float Movement = 10;

    private GameController _gameController;
    public AudioClip fire;
    public AudioClip bangSmall;
    AudioSource audio;

	// Use this for initialization
	void Start ()
    {
        audio = GetComponent<AudioSource>();
        audio.PlayOneShot(fire);
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
        //var explosion = Instantiate(Explosion, other.transform.position, Quaternion.identity);
        audio.PlayOneShot(bangSmall);
        Destroy(other.gameObject);
        Destroy(this.gameObject);

        //Destroy(explosion, 0.5f);

        _gameController.IncrementScore(10);
    }
}
