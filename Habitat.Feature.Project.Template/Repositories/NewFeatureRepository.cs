namespace $safeprojectname$.Repositories
{
    using Sitecore.Data.Items;

    public class $featureName$Repository : I$featureName$Repository
    {
        private Item item;

        public $featureName$Repository(Item item)
        {
            this.item = item;
        }
        #region Interface Implementations

        public Item Get$featureName$Root(Item contextItem)
        {
            return contextItem;
        }

        #endregion
    }
}