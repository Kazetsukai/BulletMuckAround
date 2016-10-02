using UnityEngine;
using System.Collections;
using BulletUnity;

public class Boost : MonoBehaviour {

    bool _boost = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (!_boost)
        {
            _boost = true;
            var rigidBody = GetComponent<BRigidBody>();
            rigidBody.AddImpulse(Vector3.back * 20);
        }
    }
}
