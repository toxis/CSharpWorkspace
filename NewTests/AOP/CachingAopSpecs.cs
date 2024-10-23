namespace NewTests.AOP
{
    public class CachingAopSpecs
    {
        [Test]
        public void It_returns_real_and_next_cached_value()
        {
            var cachingEntity = new CachingEntity();
            var result = cachingEntity.Calculate(2);
            Assert.That(cachingEntity.Cached, Is.False);

            result = cachingEntity.Calculate(2);
            Assert.That(cachingEntity.Cached, Is.True);
        }
    }
}
