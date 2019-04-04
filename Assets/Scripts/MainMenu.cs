using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public Animator anim;

    public void SetMenu() {
        anim.SetTrigger("In");
    }
    public void UnsetMenu() {
        anim.SetTrigger("Out");
    }
}
