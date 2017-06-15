using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    [SerializeField]
    [Range(-10,-1000)]
    private float movepower=-100;

	// Use this for initialization
	void Start () {
        Move();
    }
	
	// Update is called once per frame
	void Update () {

    }

    private void Move()
    {
        transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(movepower, 0));
    }
}
