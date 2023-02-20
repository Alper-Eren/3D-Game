using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game3D.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
       public void YesButton()
        {
            GameManager.Instance.LoadScene("Game");
        }

        public void NoButton()
        {
            GameManager.Instance.LoadScene("Menu");
        }
    }

}
