using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class MenuUI : MonoBehaviour
{
    public TMP_InputField playerName;
    
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Name is: " + playerName.text);
        MainUI.playerNamestr= playerName.text;
    }

    
}
