using System;
using Xunit;

namespace Design_Patterns.TemplateMethod
{
    public class ClassScheduleServiceTests
    {
        [Fact]
        public void TestMethodTemplate_AshtangaClass()
        {
            var result = Client.GetClassInfo(new AshtangaClass());

            Console.WriteLine(result);

            Assert.Contains("Ashtanga", result);
            Assert.Contains("ashtangaImages", result);
        }

        [Fact]
        public void TestMethodTemplate_YinClass()
        {
            var result = Client.GetClassInfo(new YinClass());

            Console.WriteLine(result);

            Assert.Contains("Yin", result);
            Assert.Contains("yinimages", result);
        }
    }
}