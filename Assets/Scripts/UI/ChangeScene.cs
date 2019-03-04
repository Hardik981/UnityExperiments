using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class ChangeScene : MonoBehaviour
    {

        public void Change()
        {
            SceneManager.LoadScene("Animation", LoadSceneMode.Single);
        }
    }
}
