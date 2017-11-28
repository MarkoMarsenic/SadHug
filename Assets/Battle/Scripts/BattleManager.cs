﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BattleManager {

	private Player player;
	private Enemy enemy;
	private bool playerFirst;
	public string forceCriticalHits; //Used for testing

	public BattleManager (Player player, Enemy enemy)
	{
		this.player = player;
		this.enemy = enemy;
		applyItem ();
		calculatePlayerFirst ();
		forceCriticalHits = "None";
	}

	public Player Player {
		get {
			return this.player;
		}
		set {
			player = value;
		}
	}

	public Enemy Enemy {
		get {
			return this.enemy;
		}
		set {
			enemy = value;
		}
	}

	public bool PlayerFirst {
		get {
			return this.playerFirst;
		}
	}

	public void calculatePlayerFirst() {
		if (player.Speed >= enemy.Speed) {
			playerFirst = true;
		} else {
			playerFirst = false;
		}
	}

	public void applyItem() {
		if (Player.Item != null) {
			Player.Item.applyBuffs();
		}
	}

	public void switchPlayers(Player newPlayer) {
		Player = newPlayer;
		calculatePlayerFirst ();
	}

	public bool isCriticalHit(int luck) {
		//Conditions for testing
		switch (forceCriticalHits)
		{
		case "All":
			return true;
		case "None":
			return false;
		default:
			//Usual code block
			float chance = 0.05f + (float) luck / 1000;
			float random = Random.value;
			if (random < chance) {
				return true;
			} else {
				return false;
			}
		}
	}

	public int damageCalculation(Character user, Character target, int power) {
		float fDamage = (float) user.Attack * power / target.Defence;
		if (isCriticalHit (user.Luck)) {
			fDamage *= 1.75f; //If critical hit increase damage by 75%
		}
		int damage = Mathf.RoundToInt (fDamage);
		if (damage < target.Health) { //If not going to kill target
			return damage;
		} else {
			return target.Health; //If going to kill, return health left so it doesn't go below zero
		}
	}


}