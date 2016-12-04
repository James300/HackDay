using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float Movement = 10;
	// Use this for initialization
	void Start () {
		
	}
	
    void FixedUpdate()
    {
        Vector3 forward = new Vector3(transform.forward.x, transform.forward.y, transform.forward.z);
        transform.position += Movement * forward * Time.deltaTime;
    }

	// Update is called once per frame
	void Update ()
    {

	}

    
    void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene(1);
        Destroy(other.gameObject);
    }
}
