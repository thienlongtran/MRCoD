using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRKeyboard.Utils;

public class StartKeyboard : MonoBehaviour
{

    [SerializeField]
    InputField thisInput;

    [SerializeField]
    KeyboardManager keyboard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Outputs keyboard inputs to current InputField
    public void setKeyboardField()
    {
        keyboard.setCurrentInputField(thisInput);
    }
}
