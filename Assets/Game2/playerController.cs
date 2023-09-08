using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    KeySelectController keyIndex;
    int nowIndex;
    GameObject slCont;

    void Start()
    {
        nowIndex = 0;
        keyIndex = GameObject.Find("KeySelectController").GetComponent<KeySelectController>();
        slCont = GameObject.Find("SliderController");
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            check(0);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            check(1);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            check(2);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            check(3);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            check(4);
        }

        //입력 체크 메소드
        void check(int i)
        {
            //배열 개수를 다 채우면 return 
            if (nowIndex >= 15)
            {
                if(i == 4)
                {
                    slCont.GetComponent<SliderController>().OnClickButtonS();
                }
                else
                {
                    //키를 잘못 입력 했을 때 시간이 깎임
                    TimerTwo timeBar = GameObject.Find("Timer").GetComponent<TimerTwo>();
                    timeBar.currentTime -= 5f; // 5초 감소
                    timeBar.UpdateTimeBar();   // 시간바 업데이트
                    return;
                }
            }
            else  //15개 다 못 채웠을 때
            {
                // key index랑 i랑 비교
                if (keyIndex.keyIndex[nowIndex] == i)
                {
                    Vector3 pos = keyIndex.keys[nowIndex].transform.position;
                    transform.position = pos;
                    keyIndex.keys[nowIndex].SetActive(false);

                    //15개 다 못채웠을 때만 증가
                    if (nowIndex < 15)
                    {
                        nowIndex++;
                    }
                }
                else
                {
                    //키를 잘못 입력 했을 때 시간이 깎임
                    TimerTwo timeBar = GameObject.Find("Timer").GetComponent<TimerTwo>();
                    timeBar.currentTime -= 5f; // 5초 감소
                    timeBar.UpdateTimeBar();   // 시간바 업데이트
                }
            }

            
            
        }
    }
}
