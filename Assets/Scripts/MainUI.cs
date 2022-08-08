using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    public Text userName;
    public static string playerNamestr;
    // Start is called before the first frame update
    void Start()
    {
        userName.text = "Name: "+playerNamestr;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
