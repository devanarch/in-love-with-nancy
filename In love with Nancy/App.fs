namespace In_love_with_Nancy

open Nancy

type App() as this =
  inherit NancyModule()
  do
    this.Get.["/"] <-  fun _ -> 
      this.View.["Index.html"] :> obj