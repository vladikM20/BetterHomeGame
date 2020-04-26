﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAndLoadStreet : SaveAndLoad
{
    [SerializeField] private Player _player;
    [SerializeField] private Gun _gun;

    [SerializeField] private SaveSystem _save;

    private void OnApplicationQuit()
    {
        SaveAll();
    }

    public override void SaveAll()
    {
        _save.SetGameExists(true);
        _save.SetAmmoValue(_gun.AmmoValue);
        _save.SetHaveGun(_player.GetHaveGun());
        _save.SetScene(2);

        _save.SaveGame();
    }
}
