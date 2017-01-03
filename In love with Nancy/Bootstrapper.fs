namespace In_love_with_Nancy

open Nancy
open Nancy.Conventions

type Bootstrapper() as __ =
  inherit DefaultNancyBootstrapper()
  do 
    #if DEBUG
    Nancy.StaticConfiguration.DisableErrorTraces <- false
    #endif
  
  override __.ConfigureConventions nancyConventions =
    base.ConfigureConventions(nancyConventions);
    
      nancyConventions.StaticContentsConventions.Add(
          StaticContentConventionBuilder.AddDirectory("/Scripts",null)
      );
      nancyConventions.StaticContentsConventions.Add(
          StaticContentConventionBuilder.AddDirectory("/Content",null)
      );
      nancyConventions.StaticContentsConventions.Add(
          StaticContentConventionBuilder.AddDirectory("/App",null)
      );