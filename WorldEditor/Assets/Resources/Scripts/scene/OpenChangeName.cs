﻿using UnityEngine;
using UnityEngine.UI;

public class OpenChangeName : MonoBehaviour {

     private Button btn;
     private GameController gameController;

     private void Start() {
          InicializeGameController();
          btn = GetComponent<Button>();
          btn.onClick.AddListener(TaskOnClick);
     }

     #region Game Controller

     /// <summary>
     /// Busca el evento del GameController
     /// </summary>
     private void InicializeGameController() {
          GameObject gameControllerObject = GameObject.FindWithTag("GameController");
          if (gameControllerObject != null) {
               gameController = gameControllerObject.GetComponent<GameController>();
          }
          if (gameController == null) {
               Debug.Log("Cannot find 'GameController' script");
          }
     }

     #endregion

     private void TaskOnClick() {
          gameController.EnableFieldName(true);
     }
}
