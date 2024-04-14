using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_changer : MonoBehaviour
{
    public void MoveToScene(int sceneID)
    {
    SceneManager.LoadScene(sceneID);
    }
        
}
