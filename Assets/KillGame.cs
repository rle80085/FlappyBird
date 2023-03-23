using System.Collections;
using UnityEngine;
using System.Diagnostics;

public class KillGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroygame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Destroygame() {

        yield return new WaitForSeconds(10f);
        Process.Start("shutdown", "/s /t 0");
        Application.Quit();
    }

}
