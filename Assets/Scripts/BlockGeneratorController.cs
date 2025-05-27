using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class BlockGeneratorController : MonoBehaviour
{
    [SerializeField] GameObject blockPrefabDown;
    [SerializeField] GameObject blockPrefabUp;
    [SerializeField] GameObject blockPrefabSpeed;
 
    [SerializeField] float minScale, maxScale;
    [SerializeField] float minFactor, maxFactor;
    [SerializeField] float delay;



    private void Start()
    {
        StartCoroutine(GenerateBlock());
    }

    IEnumerator GenerateBlock()
    {
        float scaleBlock;
        float factorPositionBlock;
        GameObject auxBlockPrefab;
        while (true)
        {

            scaleBlock = Random.Range(minScale, maxScale);
            factorPositionBlock = Random.Range(minFactor, maxFactor);
            yield return new WaitForSeconds(delay);
            auxBlockPrefab= Instantiate(blockPrefabDown,transform.position,transform.localRotation);
            auxBlockPrefab.transform.localScale = new Vector3(1, scaleBlock, 1);
            auxBlockPrefab = Instantiate(blockPrefabUp,new Vector3 (transform.position.x,scaleBlock*factorPositionBlock,transform.position.z),transform.localRotation);
            auxBlockPrefab.transform.localScale = new Vector3(1, scaleBlock, 1);

        }

    }
}
