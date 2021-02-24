using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
    public InputField name;
    public InputField age;
    // Start is called before the first frame update
    private void Update()
    {
        if (name || age)
        {
            TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, true);
        }
        name.keyboardType = TouchScreenKeyboardType.Default;
        age.keyboardType = TouchScreenKeyboardType.Default;

    }
    public void Initiate()
    {
        StartCoroutine(MenuManager.instance.reg.Register(name.text, age.text));

    }


}
