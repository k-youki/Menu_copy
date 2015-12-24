using UnityEngine;
using System.Collections;

public class ParticleCamera : MonoBehaviour {

    public GameObject particle;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonUp(0)) {
            Vector3 clickPosition;
            clickPosition = Input.mousePosition;
      			particle.transform.position = clickPosition;
						particle.SetActive(true);
        }
    }
}
