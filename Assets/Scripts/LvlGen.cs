using UnityEngine;

public class LvlGen : MonoBehaviour
{
    public GameObject[] PlatformPrefabs;
    public GameObject FirstPlatformPrefab;
    public int MinPlatform;
    public int MaxPlatform;
    public float DistanceBetweenPlatform;
    public Transform FinishPlatform;
    public Transform CylinderRoot;
    public float ExtraCylinderScale = 1f;

    private void Awake()
    {
        int platformCount = Random.Range(MinPlatform, MaxPlatform + 1);

        for(int i = 0; i < platformCount; i++)
        {
            int prefabIndex = Random.Range(0, PlatformPrefabs.Length);
            GameObject platformPrefab= i == 0 ? FirstPlatformPrefab : PlatformPrefabs[prefabIndex];
            GameObject platform = Instantiate(platformPrefab, transform);
            platform.transform.localPosition = CalculatePlatformPosition(i);
            if(i > 0)
            platform.transform.localRotation = Quaternion.Euler(0, Random.Range(0, 360f), 0);
        }

        FinishPlatform.localPosition = CalculatePlatformPosition(platformCount);

        CylinderRoot.localScale = new Vector3(1, platformCount * DistanceBetweenPlatform + ExtraCylinderScale, 1);
    }

    private Vector3 CalculatePlatformPosition(int platformIndex)
    {
        return new Vector3(0, -DistanceBetweenPlatform * platformIndex, 0);
    }
}
