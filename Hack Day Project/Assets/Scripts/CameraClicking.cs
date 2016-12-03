using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraClicking : MonoBehaviour
{
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 fwd = transform.forward;

            RaycastHit hit;
            if (Physics.Raycast(transform.position, fwd, out hit))
            {
                if (hit.collider != null)
                {
                    Button button = hit.collider.GetComponentInParent<Button>();
                    if (button != null)
                        button.onClick.Invoke();
                }

            }
        }
    }
}
