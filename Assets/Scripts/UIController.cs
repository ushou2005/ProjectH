using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    public Text signBoard;
    [SerializeField] float remainingDistance;
    int flooredValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        remainingDistance -= Time.deltaTime;
        flooredValue = Mathf.FloorToInt(remainingDistance); 
        signBoard.text = flooredValue.ToString() + "m";
    }
}
