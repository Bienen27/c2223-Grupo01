using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImputComponent : MonoBehaviour
{
    #region References
    private CharacterController _myCharacterController;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        _myCharacterController = GetComponent<CharacterController>();
    }

    //1� llamo al salto (no va)
    //2� llamo al movimiento (para mover a Mighty)
    private void Update()
    {
        if ((_myCharacterController._isgrounded && Input.GetKeyDown(KeyCode.Space)) || (_myCharacterController._doublejump && Input.GetKeyDown(KeyCode.Space)))
        {
            _myCharacterController.Jump();
        }

        _myCharacterController.Move(Input.GetAxis("Horizontal"));

    }
}
