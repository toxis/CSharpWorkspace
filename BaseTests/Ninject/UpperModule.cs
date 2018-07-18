using Ninject.Modules;

namespace BaseTests.Ninject
{
    public class UpperModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IStringFormatter>().To<UpperFormatter>();
        }
    }
}
