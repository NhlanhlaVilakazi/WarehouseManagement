using WarehouseManagent.Business.TestBusinessClasses;
using WarehouseManagent.Tests.DummyClasses;

namespace WarehouseManagent.Tests
{
    [TestClass]
    public class TestUserInput
    {   
        [TestMethod]
        public void TestForNullCategoryNameAndErrorMessageVisibility()
        {
            var category = new DummyCategory();
            new CategoriesPresenter(category);
            category.Save();
            Assert.AreEqual(expected: null, category.CategoryName, message: "Category name is required");
            Assert.IsTrue(category.IsErrorMessageVisible, "Null category name should trigger this error");
            Assert.AreEqual(expected: "Category name is required", actual: category.ErrorMessage, "Empty category name should have correct error message");

            category.CategoryName = "Drinks";
            category.Save();
            Assert.AreEqual(expected: "Drinks", actual: category.CategoryName, "Error message should disappear when the category name is provided");
            Assert.IsFalse(condition: category.IsErrorMessageVisible, message: "A filled category name should not trigger an error");
            Assert.AreEqual(expected: "", actual: category.ErrorMessage, message: "A filled category name should hide error nessage");
        }


        [TestMethod]
        public void TestForNullProductNameAndErrorMessageVisibility()
        {
            var product = new DummyProduct();
            new ProductPresenter(product);
            product.Save();
            Assert.AreEqual(expected: null, product.ProductName, message: "Product name is required");
            Assert.IsTrue(product.IsErrorMessageVisible, "Null product name should trigger this error");
            Assert.AreEqual(expected: "Product name is required", actual: product.ErrorMessage, "Empty product name should have correct error message");

            product.ProductName = "Bells";
            product.Save();
            Assert.AreEqual(expected: "Bells", actual: product.ProductName, "Error message should disappear when the product name is provided");
            Assert.IsFalse(condition: product.IsErrorMessageVisible, message: "A filled product name should not trigger an error");
            Assert.AreEqual(expected: "", actual: product.ErrorMessage, message: "A filled product name should hide error nessage");
        }

        [TestMethod]
        public void TestForNullCompanyNameAndErrorMessageVisibility()
        {
            var supplier = new DummySupplier();
            new SupplierPresenter(supplier);
            supplier.Save();
            Assert.AreEqual(expected: null, supplier.CompanyName, message: "Company name is required");
            Assert.IsTrue(supplier.IsErrorMessageVisible, "Null company name should trigger this error");
            Assert.AreEqual(expected: "Company name is required", actual: supplier.ErrorMessage, "Empty company name should have correct error message");

            supplier.CompanyName = "Hulamin";
            supplier.Save();
            Assert.AreEqual(expected: "Hulamin", actual: supplier.CompanyName, "Error message should disappear when the company name is provided");
            Assert.IsFalse(condition: supplier.IsErrorMessageVisible, message: "A filled company name should not trigger an error");
            Assert.AreEqual(expected: "", actual: supplier.ErrorMessage, message: "A filled company name should hide error nessage");
        }

    }
}