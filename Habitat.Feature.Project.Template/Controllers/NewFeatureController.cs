namespace $safeprojectname$.Controllers
{
  using System;
  using System.Web.Mvc;
  using $safeprojectname$.Repositories;
  using Sitecore.Mvc.Presentation;

  public class $featureName$Controller : Controller
  {
    private readonly I$featureName$Repository _$featureName$Repository;

    public $featureName$Controller() : this(new $featureName$Repository(RenderingContext.Current.Rendering.Item))
    {
    }

    public $featureName$Controller(I$featureName$Repository $featureName$Repository)
    {
      this._$featureName$Repository = $featureName$Repository;
    }


    public ActionResult $featureName$()
    {
      if (String.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource))
      {
        return null;
      }
      var item = RenderingContext.Current.Rendering.Item;
      return this.View("$featureName$", item);
    }
  }
}