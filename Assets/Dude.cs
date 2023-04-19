using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dude : MonoBehaviour
{
    float speed = 10;

    // Update is called once per frame
    void Update()
    {
        var direction = Input.GetAxis("Horizontal");

        var pos = transform.position;
        pos.x += direction * speed * Time.deltaTime;
        transform.position = pos;

        if (Input.GetMouseButtonDown(0))
            AudioManager.instance.uiSoundFXPlayer.PlayTrackImmediate("Ding");
    }
}
