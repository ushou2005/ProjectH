using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour
{
    [SerializeField] float ScrollSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-ScrollSpeed * Time.deltaTime, 0, 0);
        if (transform.position.x < -50)
        {
            Destroy(this.gameObject);
        }
    }
}
