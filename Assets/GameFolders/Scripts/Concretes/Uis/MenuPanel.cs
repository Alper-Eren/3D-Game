using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game3D.Uis
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartButton()
        {
            GameManager.Instance.LoadScene("Game");
        }

        public void ExitButton()
        {
            GameManager.Instance.ExitGame();
        }
    }

}
