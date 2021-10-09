using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private float damage = 20f;
    [SerializeField] private float range = 100f;

    [SerializeField] private Camera fpsCamera;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
    }
    private void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, range))
        {
            Target shootedObj = hit.transform.GetComponent<Target>();
            if(shootedObj != null)
            {
                shootedObj.TakeDamage(damage);
            }
        }
    }
}
