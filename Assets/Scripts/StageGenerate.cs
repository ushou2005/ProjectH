using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGenerate : MonoBehaviour
{
    [SerializeField] GameObject Ground;
    [SerializeField] GameObject Hole;
    [SerializeField] GameObject Hole2;

    [SerializeField] Vector3 GeneratePos;

    [SerializeField]int[] array = {0,1,0,1,0,1,0,1,0,0,0,0};
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < array.Length; i++)
        {
            GeneratePos.x += 18.2f;
            if (array[i] == 0)
            {
                Instantiate(Ground, GeneratePos, Quaternion.identity);
            }
            if (array[i] == 1)
            {
                Instantiate(Hole, GeneratePos, Quaternion.identity);
            }
            if (array[i] == 2)
            {
                Instantiate(Hole2, GeneratePos, Quaternion.identity);
            }
            if (i == array.Length)
            {
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
