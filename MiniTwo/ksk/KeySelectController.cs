using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySelectController : MonoBehaviour
{
    public GameObject[] keyPrefabs; // 입력 키의 프리팹들
    public int numRows = 3; // 행의 개수
    public int numColumns = 5; // 열의 개수
    public float rowSpacing = 1.3f; // 행 간의 간격
    public float columnSpacing = 1.3f; // 열 간의 간격

    private void Start()
    {
        PlaceKeys();
    }

    private void PlaceKeys()
    {
        for (int row = 0; row < numRows; row++)
        {
            for (int column = 0; column < numColumns; column++)
            {
                float x = (column * columnSpacing)-2.58f;
                float y = (-row * rowSpacing)+0.55f;

                int randomKeyIndex = Random.Range(0, keyPrefabs.Length);
                GameObject keyPrefab = keyPrefabs[randomKeyIndex];
                GameObject keyObject = Instantiate(keyPrefab, new Vector3(x, y, 0), Quaternion.identity);
                //Quaternion.identity -> 오브젝트가 회전하지 않고 고정되도록 넣는 값
                keyObject.transform.SetParent(transform);

                // 키에 대한 추가 설정 (키에 문자 정보 전달 등)
            }
        }
    }
}
