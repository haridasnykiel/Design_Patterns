using System;
using System.Text;

namespace Design_Patterns.TemplateMethod
{
    public enum ClassType
    {
        Ashtanga,
        Yin,
        VinyasaFlow
    }

    // The Abstract Class defines a template method that contains a skeleton of
    // some algorithm, composed of calls to (usually) abstract primitive
    // operations.
    //
    // Concrete subclasses should implement these operations, but leave the
    // template method itself intact.

    abstract class ClassScheduleTemplateMethod
    {
        public string GetClassInfo() // template method. Includes skeleton algorythm
        {
            var sb = new StringBuilder();
            sb.AppendLine(ClassTitle());
            sb.AppendLine(Location());
            sb.AppendLine(GetClassType().ToString());
            sb.AppendLine(ImageLocation());
            sb.AppendLine(Hook());
            return sb.ToString();
        }

        protected string ClassTitle()
        {
            return "title";
        }

        protected string Location()
        {
            return "location";
        }

        protected abstract ClassType GetClassType();

        protected abstract string ImageLocation();

        protected virtual string Hook()
        {
            return "In base";
        }
    }

    class Client
    {
        // The client code calls the template method to execute the algorithm.
        // Client code does not have to know the concrete class of an object it
        // works with, as long as it works with objects through the interface of
        // their base class.
        public static string GetClassInfo(ClassScheduleTemplateMethod classScheduleTemplate)
        {
            return classScheduleTemplate.GetClassInfo();
        }
    }

    class AshtangaClass : ClassScheduleTemplateMethod
    {
        protected override ClassType GetClassType()
        {
            return ClassType.Ashtanga;
        }

        protected override string ImageLocation()
        {
            return "/ashtangaImages/img1";
        }
    }

    class YinClass : ClassScheduleTemplateMethod
    {
        protected override ClassType GetClassType()
        {
            return ClassType.Yin;
        }

        protected override string ImageLocation()
        {
            return "/yinimages/img2";
        }

        protected override string Hook()
        {
            return "In Yin class";
        }
    }
}