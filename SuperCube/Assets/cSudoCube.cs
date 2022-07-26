using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class cSudoCube : MonoBehaviour
{
    [SerializeField]
    TMP_Text _sudoText;
    public int _sudoValue;

    public int SudoValue
    {
        get { return _sudoValue; }
        set
        {
            _sudoValue = value;
            _sudoText.text = _sudoValue.ToString();
        }
    }
}
