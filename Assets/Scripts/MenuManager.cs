using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;
    public RegisterUser reg;
    public Text scoreText;
    // Start is called before the first frame update

    void Start()
    {
        instance = this;
        reg = GetComponent<RegisterUser>();
        scoreText.text = "Score: "+Constants.conScore;
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
