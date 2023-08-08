using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySelectController : MonoBehaviour
{
    public GameObject[] keyPrefabs; // �Է� Ű�� �����յ�
    public int numRows = 3; // ���� ����
    public int numColumns = 5; // ���� ����
    public float rowSpacing = 1.3f; // �� ���� ����
    public float columnSpacing = 1.3f; // �� ���� ����

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
                //Quaternion.identity -> ������Ʈ�� ȸ������ �ʰ� �����ǵ��� �ִ� ��
                keyObject.transform.SetParent(transform);

                // Ű�� ���� �߰� ���� (Ű�� ���� ���� ���� ��)
            }
        }
    }
}
