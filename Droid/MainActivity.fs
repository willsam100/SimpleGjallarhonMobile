namespace Gjallarhorn101.Droid
open System

open Android.App
open Android.Content
open Android.Content.PM
open Android.Runtime
open Android.Views
open Android.Widget
open Android.OS
open Gjallarhorn.XamarinForms

[<Activity (Label = "Gjallarhorn101.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = (ConfigChanges.ScreenSize ||| ConfigChanges.Orientation))>]
type MainActivity() =
    inherit Xamarin.Forms.Platform.Android.FormsApplicationActivity()
    override this.OnCreate (bundle: Bundle) =
        base.OnCreate (bundle)

        Xamarin.Forms.Forms.Init (this, bundle)

        let program = Gjallarhorn.Core.Program.applicationCore
        let view = Gjallarhorn.Core.MainPage()

        let info = Framework.createApplicationInfo program view
        base.LoadApplication(info.CreateApp())

