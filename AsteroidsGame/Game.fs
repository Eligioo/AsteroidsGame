module Game

open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics

type AsteroidsGame () as x =
    inherit Game()

    do x.Content.RootDirectory <- "Content"
    let graphics = new GraphicsDeviceManager(x)
    let mutable spriteBatch : SpriteBatch = null

    override x.Initialize() =
        do spriteBatch
        do base.Initialize()
        ()

    override x.LoadContent() =
        ()

    override x.Update(gameTime) =
        ()

    override x.Draw (gameTime) =
        do x.GraphicsDevice.Clear Color.CornflowerBlue
        ()