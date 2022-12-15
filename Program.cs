// See https://aka.ms/new-console-template for more information

using FightingGame;

//run the method PlayRound from Combat class
Combat combat = new Combat(new Player("Player1"), new Player("Player2"));
combat.PlayRound();