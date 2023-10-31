using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageSelectManager : MonoBehaviour
{
    [SerializeField] Button[] stageButton;
    private void Start()
    {
        int stageUnlock = PlayerPrefs.GetInt("StageUnlock", 1);
        for(int i = 0; i < stageButton.Length; i++)
        {
            if (i < stageUnlock)
            {
                stageButton[i].interactable = true;
            }
            else
            {
                stageButton[i].interactable =false;
            }
        }
    }
    public void StageSelect(int stage)
    {
        SceneManager.LoadScene(stage);
    }
}
