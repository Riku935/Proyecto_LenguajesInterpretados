using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput2 : MonoBehaviour
{
    private string input;
    public void ReadRegisterUsernameString(string s)
    {
        input = s;
        Debug.Log(input);
        GameManager.obj.addRegUser(input);
    }

    public void ReadRegisterPasswordString(string s)
    {
        input = s;
        Debug.Log(input);
        GameManager.obj.addRegPass(input);
    }

    public void ReadLoginUsernameString(string s)
    {
        input = s;
        Debug.Log(input);
        GameManager.obj.addLogUser(input);
    }
    public void ReadLoginPasswordString(string s)
    {
        input = s;
        Debug.Log(input);
        GameManager.obj.addLogPass(input);
    }
}
