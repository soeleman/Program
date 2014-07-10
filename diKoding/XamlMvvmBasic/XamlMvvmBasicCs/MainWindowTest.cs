namespace XamlMvvmBasic
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MainWindowTest
    {
        [TestMethod]
        public void TestModelPropertyChanged()
        {
            var vm           = new MainWindowViewModel();
            var model        = vm.Model;
            var modelChanged = false;

            vm.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName.Equals(@"Model"))
                {
                    modelChanged = true;
                }
            };

            model.FirstName = @"Mooo";
            vm.Model = model;

            Assert.IsTrue(modelChanged);
        }

        [TestMethod]
        public void TestFirsNamePropertyChanged()
        {
            var vm = new MainWindowViewModel();

            var firstNameChanged = false;

            vm.Model.PropertyChanged += (s, e) =>
                {
                    if (e.PropertyName.Equals(@"FirstName"))
                    {
                        firstNameChanged = true;
                    }
                };

            vm.Model.FirstName = @"Mooo";

            Assert.IsTrue(firstNameChanged);
        }
    }
}