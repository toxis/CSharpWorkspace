using Ninject.Modules;

namespace BaseTests.Ninject
{
    public class LowerModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IStringFormatter>().To<LowerFormatter>();
        }
    }
}
