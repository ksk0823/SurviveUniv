using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSFX : MonoBehaviour
{
    static ButtonSFX Instance;
    // Start is called before the first frame update
    void Awake()
    {
        // var objs = FindObjectsOfType<DontDestroyObject>();
        if (Instance != this && Instance != null)
        {
            Destroy(transform.gameObject);
            return;
        }
        else
        {
            
            Instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
        
    }
}
