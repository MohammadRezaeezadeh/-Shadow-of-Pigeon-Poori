namespace SuperTiled2Unity.Editor
{
    internal class RecursiveAssetDependencyTracker
    {
        private string path;

        public RecursiveAssetDependencyTracker(string path)
        {
            this.path = path;
        }
    }
}