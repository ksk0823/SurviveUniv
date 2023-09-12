using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextHTPOneSFX : MonoBehaviour
{
    // Start is called before the first frame update
    static NextHTPOneSFX Instance;

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
