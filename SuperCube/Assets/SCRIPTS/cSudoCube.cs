using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class cSudoCube : MonoBehaviour
{
    
    public TMP_Text _sudoText;
    int _sudoValue;

    public int SudoValue
    {
        get { return _sudoValue; }
        set
        {
            try
            {
                _sudoValue = value;
                _sudoText.text = value.ToString();
            }
            catch (System.Exception x)
            {
                Debug.LogError(x.Message);
            }
        }
    }
}
