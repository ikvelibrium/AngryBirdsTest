using UnityEngine;
using UnityEngine.SceneManagement;

namespace Core
{
    public class SceneLoader : MonoBehaviour
    {
        public void loadMenu()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(0);
        }
        public void LoadFirstLvl()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(1);
        }
        public void LoadSecondLvl()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(2);
        }
    }
}
