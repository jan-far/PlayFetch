using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float coolTime = 3.0f;

    // Update is called once per frame
    void Update()
    {
        if (coolTime > Random.Range(0.5f, 3.0f))
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                coolTime = 0;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }

        coolTime += Time.deltaTime;
    }
}
