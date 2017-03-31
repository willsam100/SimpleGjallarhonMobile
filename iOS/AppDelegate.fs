namespace Gjallarhorn101.iOS

open System
open UIKit
open Foundation
open Xamarin.Forms
open Xamarin.Forms.Platform.iOS
open Gjallarhorn.XamarinForms

[<Register ("AppDelegate")>] 
type AppDelegate () =
    inherit FormsApplicationDelegate ()

    override this.FinishedLaunching (app, options) =
        Forms.Init()
        let program = Gjallarhorn.Core.Program.applicationCore
        let view = Gjallarhorn.Core.MainPage()
        let info = Framework.createApplicationInfo program view
        base.LoadApplication(info.CreateApp())
        base.FinishedLaunching(app, options)

module Main =
    [<EntryPointAttribute>]
    let main args =
        UIApplication.Main(args, null, "AppDelegate")
        0

