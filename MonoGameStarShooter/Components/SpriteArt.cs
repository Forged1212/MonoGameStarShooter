﻿namespace MonoGameStarShooter
{
    static class SpriteArt
    {
        //Create the texture references here
        public static Texture2D Player { get; private set; }
        public static Texture2D EnemyTypeOne { get; private set; }


        //Load the textures into the references from the Content mgcb editor
        public static void Load(ContentManager content)
        {
<<<<<<< HEAD
            Player = content.Load<Texture2D>("Sprites/PlayerShip");
            EnemyTypeOne = content.Load<Texture2D>("Sprites/EnemyStarship1Fix");
=======
            Player = content.Load<Texture2D>("Sprites/ball");

            EnemyTypeOne = content.Load<Texture2D>("Sprites/EnemyStarship1Fix");

            Console.WriteLine(Player);

>>>>>>> 663546245307f0520b12f939912325589c9612cb
        }

        //Call the texture by using "SpriteArt.Name" ex "image = SpriteArt.Player" 
    }
}
