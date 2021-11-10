using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger game over")]
    [SerializeField] string triggeringTag;
    static int life = 3;
    public GameObject[] hearts;

        
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            if (life == 0)
            {
                Debug.Log("Game over!");
                Application.Quit();
                //UnityEditor.EditorApplication.isPlaying = false;
            }
            else
            {
                Destroy(other.gameObject);
                Vector3 vec = new Vector3(0,-6, 0);
                this.gameObject.transform.position = vec;
                life--;
                FindObjectOfType<audiomanager>().Play("destroy");
            }
            
        }
        else if (other.tag == "boss")
        {
            Vector3 vec = new Vector3(0, -6, 0);
            this.gameObject.transform.position = vec;
            life--;
            FindObjectOfType<audiomanager>().Play("destroy");
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
        if (life < 3) Destroy(hearts[2].gameObject);
        if (life < 2) Destroy(hearts[1].gameObject);
        if (life < 1) Destroy(hearts[0].gameObject);
    }

}
