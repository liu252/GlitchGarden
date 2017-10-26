using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour 
{
    public float autoLoadNextLevelAfter;

    private void Start()
    {
        Invoke("LoadNextLevel", autoLoadNextLevelAfter);
    }

    public void LoadLevel(string name)
	{
		Debug.Log("Level Load Requested for: " + name);
		Application.LoadLevel(name);
	}
	public void QuitRequest()
	{
		Debug.Log("Quit Game");
		Application.Quit();
	}
	public void LoadNextLevel()
	{
		Application.LoadLevel(Application.loadedLevel+1);
	}
	
}
