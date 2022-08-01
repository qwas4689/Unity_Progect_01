using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public GameObject _player;
    public GameObject _ragdollPlayer;
    public RagdollChanger _ragdollChanger;
    public Transform[] _savePoint;
    public GameObject[] _save;

    private Renderer _colorChange;

    public int ActiveSavePoint = -1;

    // Start is called before the first frame update
    void Start()
    {
        _colorChange = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_ragdollChanger.GetComponentInChildren<RagdollChanger>()._isRagdoll)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                for (int i = 0; i < _save.Length; ++i)
                {
                    if (_save[i].GetComponentInChildren<Renderer>().material.color == Color.red)
                    {
                        ++ActiveSavePoint;
                    }
                }

                if (_save[ActiveSavePoint].GetComponentInChildren<Renderer>().material.color == Color.red)
                {
                    changePlayerPositionToSavePosition();
                    ActiveSavePoint = -1;
                }

                _player.SetActive(true);
                _ragdollPlayer.SetActive(false);

                _ragdollChanger.GetComponentInChildren<RagdollChanger>()._isRagdoll = false;
            }
        }
    }

    private void changePlayerPositionToSavePosition()
    {
        _player.transform.position = _savePoint[ActiveSavePoint].transform.position;
    }
}
