using Game3D.Abstracts.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game3D
{
    public class GameManager : SingletonBehaviorObject<GameManager>
    {
        public event System.Action OnGameStop;

        void Awake()
        {
            SingletonThisObject(this);  
        }

        public void StopGame()
        {
            Time.timeScale = 0f;
            OnGameStop?.Invoke();
        }

        public void LoadScene(string sceneName)
        {
            StartCoroutine(LoadSceneAsync(sceneName));
        }

        private IEnumerator LoadSceneAsync(string sceneName)
        {
            Time.timeScale = 1f;
            yield return SceneManager.LoadSceneAsync(sceneName);
        }

        public void ExitGame()
        {
            Debug.Log("Exit on clicked");
            Application.Quit();
        }
    }

}
