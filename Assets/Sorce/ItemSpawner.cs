using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject itemPrefab;  // �z�u����I�u�W�F�N�g�̃v���n�u
    public GameObject enemyPrefab;
    public int numberOfObjects,numberOfEnemy;      // �z�u����I�u�W�F�N�g�̐�
    public GameObject targetObject;

    private void Start()
    {
        PlaceObjects();
    }

    private void PlaceObjects()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            Vector3 area = GetComponent<Renderer>().bounds.size;
            Vector3 newPos = this.transform.position;
            // �����_���ȍ��W�𐶐�
            newPos.x += Random.Range(-area.x / 2 -1, area.x / 2 - 1);
            newPos.z += Random.Range(-area.z / 2 -1, area.z / 2 - 1);
            newPos.y = 1;
            // �I�u�W�F�N�g�𐶐����Ĕz�u
            if (CheckForCube(newPos))
            {
                i--;
            }
            else
            {
                GameObject newObject = Instantiate(itemPrefab, newPos, Quaternion.Euler(-90,0,0));

            }
            
        }

        for (int i = 0; i < numberOfEnemy; i++)
        {
            Vector3 area = GetComponent<Renderer>().bounds.size;
            Vector3 newPos = this.transform.position;
            // �����_���ȍ��W�𐶐�
            newPos.x += Random.Range(-area.x / 2 - 1, area.x / 2 - 1);
            newPos.z += Random.Range(-area.z / 2 - 1, area.z / 2 - 1);
            newPos.y = 1;
            // �I�u�W�F�N�g�𐶐����Ĕz�u
            if (CheckForCube(newPos))
            {
                i--;
            }
            else
            {
                GameObject newObject = Instantiate(enemyPrefab, newPos, Quaternion.Euler(-90, 0, 0));

            }

        }


    }


    private bool CheckForCube(Vector3 position)
    {
        Collider[] colliders = Physics.OverlapSphere(position, 1f);  // ���肷��͈͂�����ɐݒ�

        foreach (Collider collider in colliders)
        {
            if (collider.gameObject.CompareTag("Cube"))
            {
                Debug.Log("�w�肵���ʒu��Cube�����݂��܂��B");
                return true;
            }
        }

        Debug.Log("�w�肵���ʒu��Cube�͑��݂��܂���B");
        return false;
    }

}


