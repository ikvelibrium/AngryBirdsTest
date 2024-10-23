using UnityEngine.SceneManagement;

public static class SceneLoader
{
    public static void LoadFirstLvl()
    {
        SceneManager.LoadScene(0);
    }
    public static void LoadSecondLvl()
    {
        SceneManager.LoadScene(1);
    }
}
