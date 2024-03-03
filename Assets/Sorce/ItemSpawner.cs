using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject itemPrefab;  // 配置するオブジェクトのプレハブ
    public GameObject enemyPrefab;
    public int numberOfObjects,numberOfEnemy;      // 配置するオブジェクトの数
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
            // ランダムな座標を生成
            newPos.x += Random.Range(-area.x / 2 -1, area.x / 2 - 1);
            newPos.z += Random.Range(-area.z / 2 -1, area.z / 2 - 1);
            newPos.y = 1;
            // オブジェクトを生成して配置
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
            // ランダムな座標を生成
            newPos.x += Random.Range(-area.x / 2 - 1, area.x / 2 - 1);
            newPos.z += Random.Range(-area.z / 2 - 1, area.z / 2 - 1);
            newPos.y = 1;
            // オブジェクトを生成して配置
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
        Collider[] colliders = Physics.OverlapSphere(position, 1f);  // 判定する範囲を球状に設定

        foreach (Collider collider in colliders)
        {
            if (collider.gameObject.CompareTag("Cube"))
            {
                Debug.Log("指定した位置にCubeが存在します。");
                return true;
            }
        }

        Debug.Log("指定した位置にCubeは存在しません。");
        return false;
    }

}


