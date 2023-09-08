using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StartButton : MonoBehaviour, IPointerClickHandler
    , IPointerEnterHandler
    , IPointerExitHandler
{

    public Image nowImg;

    public Sprite[] spr;

    // Start is called before the first frame update
    void Start()
    {
        nowImg = GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Enter");
        nowImg.sprite = spr[1];
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        nowImg.sprite = spr[0];
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene("HTP1", LoadSceneMode.Single);
    }
    
}
