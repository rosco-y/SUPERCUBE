using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cUnknownButtons : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    cSudoCube _preCube;
    void Start()
    {
        
    }

    // Update is called once per frame

    public void OnClick(int numSelected)
    {
        try
        {
            _preCube.SudoValue = numSelected;
        }
        catch (System.Exception x)
        {
            Debug.LogError(x.Message);
        }
        
    }
}
