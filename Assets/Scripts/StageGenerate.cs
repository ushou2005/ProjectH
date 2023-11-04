using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGenerate : MonoBehaviour
{
    [SerializeField] GameObject Ground;
    [SerializeField] GameObject Hole;

    [SerializeField] Vector3 GeneratePos;

    int[] array = {0,0,0,0,0,0,0,0,0,2};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 9; i++)
        {
            Debug.Log(i);
            GeneratePos.x += 16.2f;
            if (array[i] == 0)
            {
                Instantiate(Ground, GeneratePos, Quaternion.identity);
            }
            if (array[i] == 1)
            {
                Instantiate(Hole, GeneratePos, Quaternion.identity);
            }
            else break;
            
        }
    }
}
