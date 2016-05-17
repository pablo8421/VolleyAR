using UnityEngine;
using System.Collections;

public class Sphere_movement : MonoBehaviour {

    Vector3 tVector;
    float boxLimit = 1.0f;
    float delta = 0.01f;

	// Use this for initialization
	void Start () {
        tVector = new Vector3(Random.Range(-delta, delta),
                              Random.Range(-delta, delta),
                              Random.Range(-delta, delta));
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 t = gameObject.transform.position;
        if (Mathf.Abs(t.x) > boxLimit 
         || Mathf.Abs(t.y) > boxLimit 
         || Mathf.Abs(t.z) > boxLimit)
        {
            tVector = new Vector3(Random.Range(-delta, delta),
                                  Random.Range(-delta, delta),
                                  Random.Range(-delta, delta));
        }
        gameObject.transform.Translate(tVector);
	}
}
