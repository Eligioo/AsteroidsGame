﻿open Game

// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
[<EntryPoint>]
let main argv = 
    use g = new AsteroidsGame()
    g.Run()
    0