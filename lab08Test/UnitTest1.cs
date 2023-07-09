using Lab08Program.Classes;

namespace lab08Test
{
    public class UnitTest1
    {
        [Fact]
        public void AddBook_ToLibrary_CountIncreases()
        {
            // Arrange
            Library library = new Library();

            // Act
            library.Add("Book 1", "John", "Doe", 200);

            // Assert
            Assert.Equal(1, library.Count);
        }

        [Fact]
        public void Borrow_ExistingTitle_ReturnsBookAndRemovesIt()
        {
            // Arrange
            Library library = new Library();
            library.Add("Book 1", "John", "Doe", 200);

            // Act
            Book borrowedBook = library.Borrow("Book 1");

            // Assert
            Assert.NotNull(borrowedBook);
            Assert.DoesNotContain(borrowedBook, library);
            Assert.Equal(0, library.Count);
        }

        [Fact]
        public void Borrow_MissingTitle_ReturnsNull()
        {
            // Arrange
            Library library = new Library();
            library.Add("Book 1", "John", "Doe", 200);

            // Act
            Book borrowedBook = library.Borrow("Book 2");

            // Assert
            Assert.Null(borrowedBook);
            Assert.Equal(1, library.Count);
        }

        [Fact]
        public void Return_Book_AddsItBackToLibrary()
        {
            // Arrange
            Library library = new Library();
            library.Add("Book 1", "John", "Doe", 200);
            Book borrowedBook = library.Borrow("Book 1");

            // Act
            library.Return(borrowedBook);

            // Assert
            Assert.Contains(borrowedBook, library);
            Assert.Equal(1, library.Count);
        }
    }

    public class BackpackTests
    {
        [Fact]
        public void Pack_Item_AddsItToBackpack()
        {
            // Arrange
            Backpack<string> backpack = new Backpack<string>();

            // Act
            backpack.Pack("Item 1");

            // Assert
            Assert.Contains("Item 1", backpack);
        }

        [Fact]
        public void Unpack_Item_RemovesItFromBackpack()
        {
            // Arrange
            Backpack<string> backpack = new Backpack<string>();
            backpack.Pack("Item 1");
            backpack.Pack("Item 2");

            // Act
            string unpackedItem = backpack.Unpack(0);

            // Assert
            Assert.Equal("Item 1", unpackedItem);
            Assert.DoesNotContain("Item 1", backpack);
            Assert.Equal(1, backpack.Count);
        }
    }
}