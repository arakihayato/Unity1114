using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartController : MonoBehaviour
{
    public void OnStartButtonPressed()
    {
        //ゲームマネージャーを認識していない
        GameManager.Instance.StartGame();
    }
}
