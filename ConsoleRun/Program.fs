open System
open In_love_with_Nancy

[<EntryPoint>]
let main _ = 
  let nancy = new Nancy.Hosting.Self.NancyHost(new Bootstrapper(), new Uri("http://localhost:8100"))
  nancy.Start()

  while Console.ReadLine() <> "x" do ()
  0 
