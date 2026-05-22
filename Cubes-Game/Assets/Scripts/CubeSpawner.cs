using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {
   // Singleton class
   public static CubeSpawner Instance ;

   Queue<Cube> cubesQueue = new Queue<Cube> () ;
   [SerializeField] private int cubesQueueCapacity = 20 ;
   [SerializeField] private bool autoQueueGrow = true ;

   [SerializeField] private GameObject cubePrefab ;
    [SerializeField] private GameObject starPrefab;
    [SerializeField] private Color[] cubeColors ;

   [SerializeField] AudioSource audio1;

   [HideInInspector] public int maxCubeNumber ;
   // in our case it's 4096 (2^12)

   private int maxPower = 12 ;

   private Vector3 defaultSpawnPosition ;

    private void Awake () {
      Instance = this ;

      defaultSpawnPosition = transform.position ;
      maxCubeNumber = (int)Mathf.Pow (2, maxPower) ;

      InitializeCubesQueue () ;
   }

    private void InitializeCubesQueue () {
      for (int i = 0; i < cubesQueueCapacity; i++)
         AddCubeToQueue () ;
   }

   private void AddCubeToQueue () {
      Cube cube = Instantiate (cubePrefab, defaultSpawnPosition, Quaternion.identity, transform)
                              .GetComponent <Cube> () ;

      cube.gameObject.SetActive (false) ;
      cube.IsMainCube = false ;
      cubesQueue.Enqueue (cube) ;
   }

   public Cube Spawn (int number, Vector3 position) {
      if (cubesQueue.Count == 0) {
         if (autoQueueGrow) {
            cubesQueueCapacity++ ;
            AddCubeToQueue () ;

         } else {
            Debug.LogError ("[Cubes Queue] : no more cubes available in the pool") ;
            return null ;
         }
      }

      Cube cube = cubesQueue.Dequeue () ;
      cube.transform.position = position ;
      cube.SetNumber (number) ;
      cube.SetColor (GetColor (number)) ;
      cube.gameObject.SetActive (true) ;

      return cube ;
   }

   public Cube SpawnRandom () {
      return Spawn (GenerateRandomNumber (), defaultSpawnPosition) ;
   }

   public void DestroyCube (Cube cube) {
      cube.CubeRigidbody.linearVelocity = Vector3.zero ;
      cube.CubeRigidbody.angularVelocity = Vector3.zero ;
      cube.transform.rotation = Quaternion.identity ;
      cube.IsMainCube = false ;
      cube.gameObject.SetActive (false) ;
      cubesQueue.Enqueue (cube) ;
        audio1.Play();
        StartCoroutine(StarSpawn());
    }


   public int GenerateRandomNumber () {
      return (int)Mathf.Pow (2, Random.Range (1, 6)) ;
   }

   private Color GetColor (int number) {
      return cubeColors [ (int)(Mathf.Log (number) / Mathf.Log (2)) - 1 ] ;
   }

    private IEnumerator StarSpawn()
    {
        starPrefab.SetActive(true);
        yield return new WaitForSeconds(1);
        starPrefab.SetActive(false);
    }
}
