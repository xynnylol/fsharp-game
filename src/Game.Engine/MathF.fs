[<AutoOpen>]
[<RequireQualifiedAccess>]
module Game.Engine.MathF
open System
open Transform
let PI = float32 (Math.PI)
let angleToRadian (a : float32) =
    a * PI / 180.0f
let radianToAngle (r : float32) =
    r * 180.0f / PI
type MathF = MathF with
    static member Sin (r : float32) =
        float32 (Math.Sin (float (r)))
    static member Cos (r : float32) =
        float32 (Math.Cos (float (r)))
    static member Tan (r : float32) =
        float32 (Math.Tan (float (r)))