using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
   // [SerializeField] NumberField lives;
    //int life = 3;
    int laser = 20;
    //lives newObjectlives = newObject.GetComponent<lives>();
    // newObjectlives.
    

private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            if (this.tag == "boss")
                {
                 if (laser != 0)
                 {
                    laser--;
                    Destroy(other.gameObject);
                    Debug.Log("laser-" + laser);
                }   
                 else
                 {
                     Destroy(this.gameObject);
                     Destroy(other.gameObject);
                     FindObjectOfType<audiomanager>().Play("destroy");
                }               
            }
            if (this.tag == "Enemy")
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
                FindObjectOfType<audiomanager>().Play("destroy");
            }
            /*else if (life > 0)
            {
                life--;
            }
                
            else
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
                Debug.Log("3");
            }*/
                        
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }
}
