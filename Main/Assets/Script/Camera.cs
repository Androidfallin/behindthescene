using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Camera : MonoBehaviour
{
    public Transform target; //ī�޶� �ν����Ϳ��� Ÿ�����������ϰ�


    private void Awake()
    {
        var obj = FindObjectsOfType<Camera>();
        if (obj.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y + 3, -10f); //ī�޶� ��ġ ����

        if (SceneManager.GetActiveScene().name == "Stage")
        {
            transform.position = new Vector3(target.position.x, target.position.y, -10f); //ī�޶� ��ġ ����

        }
    }

}
