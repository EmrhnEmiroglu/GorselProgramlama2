using UnityEngine;

// Toplanabilir kaps�lleri zemin �st�nde rastgele olu�turacak script

public class PickupManager : MonoBehaviour
{
    public GameObject pickup; // kaps�l prefab�
    public GameObject ground; // zemin nesnesi
    public int amount; // Do�acak Kaps�l adedi

    private void Start()
    {
        //Zemin boyutlar�n� al, Plane nesnesi 10+10 birim oldu�undan m�tevellit zeminin scale de�erini 10 ile �arparak boyutuna ula�t�k
        float groundSizeX = ground.transform.localScale.x * 10f;
        float groundSizeZ = ground.transform.localScale.z * 10f;

        for(int i = 0; i < amount; i++)
        {
            //Zemin boyunca rastgele x ve z konumu belirle
            float randomX = Random.Range(-groundSizeX / 2f, groundSizeX / 2f);
            float randomZ = Random.Range(-groundSizeZ / 2f, groundSizeZ / 2f);

            //Kaps�l�n do�aca�� konumu belirler
            Vector3 location = new Vector3(randomX, 3f, randomZ);
            Instantiate(pickup, location, Quaternion. identity);// Kaps�l� belirlenen rastgele konumda olu�tur
        }
    }

}
