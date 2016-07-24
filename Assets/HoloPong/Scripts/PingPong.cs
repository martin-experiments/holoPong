using UnityEngine;
using System.Collections;

public class PingPong : MonoBehaviour {
  private Rigidbody body;

  void Start () {
    this.body = GetComponent<Rigidbody>();
    Invoke("StartMoving", 5);
  }

  void Update () {
  }

  private void StartMoving() {
    this.body.velocity = new Vector3(1.0f, 0, 0);
  }
}