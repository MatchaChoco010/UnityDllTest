using System;
using UnityEngine;

public class DllTest : MonoBehaviour {
  void Start () {
    int f (int n) {
      if (n == 1) return 1;

      return n * f (n - 1);
    }

    Debug.Log (f (5));
  }
}
