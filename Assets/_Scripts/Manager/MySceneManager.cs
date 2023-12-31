using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // Scene 관리를 위한 네임스페이스 추가

public class MySceneManager : MonoBehaviour
{
    // 이 메소드는 버튼이 클릭될 때 호출됩니다
    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene("StartScene");
        GameManager.Instance.endPopUp.SetActive(false);
    }
}
