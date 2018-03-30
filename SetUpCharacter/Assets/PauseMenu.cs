
using UnityEngine;
using UnityEngine.Networking;

public class PauseMenu : NetworkBehaviour {

    public Transform Player;
    public Transform canvas;

    private void Update()
    {if (Input.GetKey(KeyCode.Escape))
            {

                if (canvas.gameObject.activeInHierarchy == false)
                {
                    Player.GetComponent<PlayerControllerSolo>().enabled = false;
                    canvas.gameObject.SetActive(true);
                    Cursor.visible = true;
                    Time.timeScale = 0;
                }
                else
                {
                    Player.GetComponent<PlayerControllerSolo>().enabled = true;
                    canvas.gameObject.SetActive(false);
                    Cursor.visible = false;
                    Time.timeScale = 1;
                }
            
        }
    }
}
