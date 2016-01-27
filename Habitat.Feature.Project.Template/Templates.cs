namespace $safeprojectname$
{
  using Sitecore.Data;

  public struct Templates
  {
    public struct $featureName$Root
    {
      public static readonly ID ID = new ID("{F9F4FC05-98D0-4C62-860F-F08AE7F0EE25}");
    }

    public struct $featureName$Item
    {
      public static readonly ID ID = new ID("{18BAF6B0-E0D6-4CCE-9184-A4849343E7E4}");

      public struct Fields
      {
        public static readonly ID Icon = new ID("{2C24649E-4460-4114-B026-886CFBE1A96D}");
        public static readonly ID DividerBefore = new ID("{4231CD60-47C1-42AD-B838-0A6F8F1C4CFB}");
      }
    }
  }
}