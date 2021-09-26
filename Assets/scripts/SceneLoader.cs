using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loadInGameWithIntro()
    {
        SceneManager.LoadScene(1);
    }

    public void loadHospitalIntro()
    {
        SceneManager.LoadScene(0);
    }

    public void loadSceneByName(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void loadSceneByBuildIndex(int index)
    {
        SceneManager.LoadScene(index);
    }
}
