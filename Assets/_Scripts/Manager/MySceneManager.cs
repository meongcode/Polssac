using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // Scene ������ ���� ���ӽ����̽� �߰�

public class MySceneManager : MonoBehaviour
{
    // �� �޼ҵ�� ��ư�� Ŭ���� �� ȣ��˴ϴ�
    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");  // "MainScene"�� ���� ���� ���� �̸����� �ٲ��ּ���
    }
}
