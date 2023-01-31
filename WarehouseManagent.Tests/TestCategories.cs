using WarehouseManagent.Business.TestBusinessClasses;

namespace WarehouseManagent.Tests
{
    [TestClass]
    public class TestCategories
    {
        [TestMethod]
        public void TestMethod1()
        {
            var category = new DummyCategory();
            var presenter = new CategoriesPresenter(category);

            category.Save();
            Assert.AreEqual(expected: null, category.CategoryName, message: "Category name can not be empty");
            Assert.IsTrue(category.IsErrorMessageVisible, "Null category name should trigger this error");
            Assert.AreEqual(expected: "Category name can not be empty", actual: category.ErrorMessage, "Empty category name should have correct error message");
        }
    }
}