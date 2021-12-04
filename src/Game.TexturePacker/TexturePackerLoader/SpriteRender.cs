namespace TexturePackerLoader
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    public class SpriteRender
    {
        private const float ClockwiseNinetyDegreeRotation = (float)(Math.PI / 2.0f);
        private SpriteBatch spriteBatch;
        public SpriteRender (SpriteBatch spriteBatch)
        {
            this.spriteBatch = spriteBatch;
        }
        public void Draw(SpriteFrame sprite, Vector2 position, Color color, float rotation = 0, float scale = 1, SpriteEffects spriteEffects = SpriteEffects.None)
        {
            Vector2 origin = sprite.Origin;
            if (sprite.IsRotated)
            {
                rotation -= ClockwiseNinetyDegreeRotation;
                switch (spriteEffects)
                {
                    case SpriteEffects.FlipHorizontally: spriteEffects = SpriteEffects.FlipVertically; break;
                    case SpriteEffects.FlipVertically: spriteEffects = SpriteEffects.FlipHorizontally; break;
                }
            }
            switch (spriteEffects)
            {
                case SpriteEffects.FlipHorizontally: origin.X = sprite.SourceRectangle.Width - origin.X; break;
                case SpriteEffects.FlipVertically: origin.Y = sprite.SourceRectangle.Height - origin.Y; break;
            }
            spriteBatch.Draw(
                texture: sprite.Texture,
                position: position,
                sourceRectangle: sprite.SourceRectangle,
                color: color,
                rotation: rotation,
                origin: origin,
                scale: new Vector2(scale, scale),
                effects: spriteEffects,
                layerDepth: 0.0f
            );
        }
    }
}