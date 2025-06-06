using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonKnow : MonoBehaviour
{
    public void 小知識()
    {
        SceneManager.LoadScene("00_茶葉小知識");
    }
    // Start is called before the first frame update
}
