using UnityEngine;

public class Pos : MonoBehaviour
{
   // public GameObject obje;
   // private int objeSayisi = 5;

   public int[] rakamlar = new int[3];
   
    void Start()
    {
      // foreach (int rakam in rakamlar)
      // {
      //     rakamlar[rakam] = Random.Range(-10, 10);
      //     Debug.Log(rakamlar[rakam]);
      // }

        for (int i = 0; i < rakamlar.Length; i++)   
        {
            rakamlar[i] = Random.Range(-10, 10);
            Debug.Log(rakamlar[i]);
        }
  
      // int x = Random.Range(0, 5);
      // int y = Random.Range(0, 3);
      // int z = Random.Range(0, 4);
      // Vector3 newPos= new Vector3(x,y,z);
      // transform.position = newPos;

      //  for (int i = 0; i < objeSayisi; i++)
      //  {
      //      int x = Random.Range(0, 5);
      //      Vector3 newPos= new Vector3(x,x,x);
      //      transform.position = newPos;
      //      Instantiate(obje, newPos, Quaternion.identity);
      //  }
      
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
