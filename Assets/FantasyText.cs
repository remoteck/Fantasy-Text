using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FantasyText : MonoBehaviour {

    [SerializeField] Text textComponent;

    // Start is called before the first frame update
    void Start() {
        textComponent.text = ("The code is working");
    }

    // Update is called once per frame
    void Update() {

    }
}
