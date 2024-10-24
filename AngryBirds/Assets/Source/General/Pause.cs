using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class PauseScript : MonoBehaviour
    {
        public void PauseGame()
        {
            Time.timeScale = 0;
        }
        public void ResumeGame()
        {
            Time.timeScale = 1;
        }
    }
}
