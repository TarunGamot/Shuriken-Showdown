using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootingScript : MonoBehaviour
{
    public float speed;
    public GameObject shurikenPrefab;
    private float shootRate = 5.0f;
    private float nextTimeToShoot;
    public int maxShuriken = 5;
    private int currentShuriken = -1;
    public float reloadTime;
    private bool isReloading = false;
    public AudioSource shurikenSound;
    public Text shurikenDisplay;

    // Start is called before the first frame update
    void Start()
    {
        if (currentShuriken == -1)
            currentShuriken = maxShuriken;
        
    }

    // Update is called once per frame
    void Update()
    {
        shurikenDisplay.text = currentShuriken.ToString();
        if (isReloading)
            return;
        if (currentShuriken <= 0)
        {
            StartCoroutine(Reload());
            return;
        }
        if (Input.GetKeyDown(KeyCode.J) && Time.time >= nextTimeToShoot)
        {
            nextTimeToShoot = Time.time + 1f / shootRate;
            Shoot();
        }
       
       
    }
    IEnumerator Reload()
    {
        isReloading = true;
        yield return new WaitForSeconds(reloadTime);
        currentShuriken = maxShuriken;
        isReloading = false;
    }
    public void Shoot()
    {


        currentShuriken--;
        shurikenSound.Play();
           GameObject shoot = Instantiate(shurikenPrefab, transform.position, shurikenPrefab.transform.rotation);
            Rigidbody2D rb2D = shoot.GetComponent<Rigidbody2D>();
            rb2D.AddForce(transform.right * speed, ForceMode2D.Impulse);

        
    }
}
