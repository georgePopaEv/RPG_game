using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RPG_Game
{
    class Projectile
    {
        private Vector2 position;
        private int speed = 400;
        private int radius = 15;
        private Dir direction;

        public static List<Projectile> projectiles = new List<Projectile>();
        public Projectile(Vector2 newPos, Dir newDir)
        {
            position = newPos;
            direction = newDir;
        }

        public Vector2 Position
        {
            get
            {
                return position;
            }
        }
        public int Radius
        {
            get
            {
                return radius;
            }
        }

        public void Update(GameTime gt)
        {
            float dt = (float)gt.ElapsedGameTime.TotalSeconds;

            switch (direction)
            {
                case Dir.Right:
                    position.X += speed * dt;
                    break;
                case Dir.Left:
                    position.X -= speed * dt;
                    break;
                case Dir.Up:
                    position.Y -= speed * dt;
                    break;
                case Dir.Down:
                    position.Y += speed * dt;
                    break;
                default:
                    break;

            }
        }
    }
}
