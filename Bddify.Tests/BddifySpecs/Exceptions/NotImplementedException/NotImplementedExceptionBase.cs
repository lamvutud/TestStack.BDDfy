namespace Bddify.Tests.BddifySpecs.Exceptions.NotImplementedException
{
    public class NotImplementedExceptionBase
    {
        protected readonly ExceptionThrowingTest<System.NotImplementedException> Sut;

        public NotImplementedExceptionBase()
        {
            Sut = new ExceptionThrowingTest<System.NotImplementedException>();
        }
    }
}