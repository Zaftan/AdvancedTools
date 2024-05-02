using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    private enum SpawnType
    {
        HalfHalf,
        EveryOther,
        HigherPolyHalfHalf,
        HigherPolyEveryOther,
        StaticSpinNormalAndHighPoly,
        Static,
        Rotating,
        HighPoly,
        HighPolyRotating
    };
    
    [SerializeField] private GameObject lowPolyObj;
    [SerializeField] private GameObject rotatingLowPolyObj;
    [SerializeField] private GameObject highPolyObj;
    [SerializeField] private GameObject rotatingHighPolyObj;
    [SerializeField] private int objAmount = 1;
    [SerializeField] SpawnType spawnType = SpawnType.HalfHalf;

    private void Start()
    {
        switch (spawnType)
        {
            case SpawnType.HalfHalf:
                SpawnHalfHalf(objAmount);
                break;
            case SpawnType.EveryOther:
                SpawnEveryOther(objAmount);
                break;
            case SpawnType.HigherPolyHalfHalf:
                SpawnHigherPolyHalfHalf(objAmount);
                break;
            case SpawnType.HigherPolyEveryOther:
                SpawnHigherPolyEveryOther(objAmount);
                break;
            case SpawnType.StaticSpinNormalAndHighPoly:
                SpawnStaticSpinNormalAndHighPoly(objAmount);
                break;
            case SpawnType.Static:
                SpawnStatic(objAmount);
                break;
            case SpawnType.Rotating:
                SpawnRotating(objAmount);
                break;
            case SpawnType.HighPoly:
                SpawnHighPoly(objAmount);
                break;
            case SpawnType.HighPolyRotating:
                SpawnHighPolyRotating(objAmount);
                break;
        }

    }

    void SpawnHalfHalf(int amount = 1)
    {
        int i = 1;
        Vector2 spawnPos = new Vector2(0, 0);
        
        while (i <= amount)
        {
            //If i is half of amount then spawn a rotating cube
            if (i != 0 && i == amount / 2 || i <= amount / 2)
            {
                Instantiate(lowPolyObj, new Vector3(spawnPos.x, 100, spawnPos.y), Quaternion.identity);
            }
            else
            {
                Instantiate(rotatingLowPolyObj, new Vector3(spawnPos.x, 100, spawnPos.y), Quaternion.identity);
            }
            
            //if i can be divided by 10 then create a new row
            if (i != 0 && i % 10 == 0)
            {
                spawnPos.y += 10;
                spawnPos.x = 0;
            }
            else
            {
                spawnPos.x += 10;
            }
            
            i++;
        }
    }

    void SpawnEveryOther(int amount = 1)
    {
        int i = 1;
        Vector2 spawnPos = new Vector2(0, 0);

        while (i <= amount)
        {
            if (i % 2 == 0)
            {
                Instantiate(lowPolyObj, new Vector3(spawnPos.x, 100, spawnPos.y), Quaternion.identity);
            }
            else
            {
                Instantiate(rotatingLowPolyObj, new Vector3(spawnPos.x, 100, spawnPos.y), Quaternion.identity);
            }
            
            if (i != 0 && i % 10 == 0)
            {
                spawnPos.y += 10;
                spawnPos.x = 0;
            }
            else
            {
                spawnPos.x += 10;
            }

            i++;
        }
    }

    void SpawnHigherPolyHalfHalf(int amount = 1)
    {
        int i = 1;
        Vector2 spawnPos = new Vector2(0, 0);
        
        while (i <= amount)
        {
            //If i is half of amount then spawn a rotating cube
            if (i != 0 && i == amount / 2 || i <= amount / 2)
            {
                Instantiate(highPolyObj, new Vector3(spawnPos.x, 100, spawnPos.y), Quaternion.identity);
            }
            else
            {
                Instantiate(rotatingHighPolyObj, new Vector3(spawnPos.x, 100, spawnPos.y), Quaternion.identity);
            }
            
            //if i can be divided by 10 then create a new row
            if (i != 0 && i % 10 == 0)
            {
                spawnPos.y += 10;
                spawnPos.x = 0;
            }
            else
            {
                spawnPos.x += 10;
            }
            
            i++;
        }
    }
    
    void SpawnHigherPolyEveryOther(int amount = 1)
    {
        int i = 1;
        Vector2 spawnPos = new Vector2(0, 0);

        while (i <= amount)
        {
            if (i % 2 == 0)
            {
                Instantiate(highPolyObj, new Vector3(spawnPos.x, 100, spawnPos.y), Quaternion.identity);
            }
            else
            {
                Instantiate(rotatingHighPolyObj, new Vector3(spawnPos.x, 100, spawnPos.y), Quaternion.identity);
            }
            
            if (i != 0 && i % 10 == 0)
            {
                spawnPos.y += 10;
                spawnPos.x = 0;
            }
            else
            {
                spawnPos.x += 10;
            }

            i++;
        }
    }
    
    void SpawnStaticSpinNormalAndHighPoly(int amount = 1)
    {
        int i = 1;
        Vector2 spawnPos = new Vector2(0, 0);

        int j = 1;
        while (i <= amount)
        {
            if (j == 1)
            {
                Instantiate(lowPolyObj, new Vector3(spawnPos.x, 100, spawnPos.y), Quaternion.identity);
            }
            else if (j == 2)
            {
                Instantiate(rotatingLowPolyObj, new Vector3(spawnPos.x, 100, spawnPos.y), Quaternion.identity);
            }
            else if (j == 3)
            {
                Instantiate(highPolyObj, new Vector3(spawnPos.x, 100, spawnPos.y), Quaternion.identity);
            }
            else if (j == 4)
            {
                Instantiate(rotatingHighPolyObj, new Vector3(spawnPos.x, 100, spawnPos.y), Quaternion.identity);
            }

            if (j >= 4)
            {
                j = 1;
            }
            else
            {
                j++;
            }
            
            if (i != 0 && i % 10 == 0)
            {
                spawnPos.y += 10;
                spawnPos.x = 0;
            }
            else
            {
                spawnPos.x += 10;
            }

            i++;
        }
    }
    
    void SpawnStatic(int amount = 1)
    {
        int i = 1;
        Vector2 spawnPos = new Vector2(0, 0);

        while (i <= amount)
        {
            Instantiate(lowPolyObj, new Vector3(spawnPos.x, 100, spawnPos.y), Quaternion.identity);
            
            if (i != 0 && i % 10 == 0)
            {
                spawnPos.y += 10;
                spawnPos.x = 0;
            }
            else
            {
                spawnPos.x += 10;
            }

            i++;
        }
    }
    
    void SpawnRotating(int amount = 1)
    {
        int i = 1;
        Vector2 spawnPos = new Vector2(0, 0);

        while (i <= amount)
        {
            Instantiate(rotatingLowPolyObj, new Vector3(spawnPos.x, 100, spawnPos.y), Quaternion.identity);
            
            if (i != 0 && i % 10 == 0)
            {
                spawnPos.y += 10;
                spawnPos.x = 0;
            }
            else
            {
                spawnPos.x += 10;
            }

            i++;
        }
    }
    
    void SpawnHighPoly(int amount = 1)
    {
        int i = 1;
        Vector2 spawnPos = new Vector2(0, 0);

        while (i <= amount)
        {
            Instantiate(highPolyObj, new Vector3(spawnPos.x, 100, spawnPos.y), Quaternion.identity);
            
            if (i != 0 && i % 10 == 0)
            {
                spawnPos.y += 10;
                spawnPos.x = 0;
            }
            else
            {
                spawnPos.x += 10;
            }

            i++;
        }
    }
    
    void SpawnHighPolyRotating(int amount = 1)
    {
        int i = 1;
        Vector2 spawnPos = new Vector2(0, 0);

        while (i <= amount)
        {
            Instantiate(rotatingHighPolyObj, new Vector3(spawnPos.x, 100, spawnPos.y), Quaternion.identity);
            
            if (i != 0 && i % 10 == 0)
            {
                spawnPos.y += 10;
                spawnPos.x = 0;
            }
            else
            {
                spawnPos.x += 10;
            }

            i++;
        }
    }
}
