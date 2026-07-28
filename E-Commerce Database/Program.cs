using E_Commerce_Database.Models;
using System.Linq;

namespace E_Commerce_Database
{
    public class Program
    {
        static AppDbContext context = new AppDbContext();

        static int loggedInUserId = 0;

        static void Main(string[] args)
        {

        }

        // 1. Register New User

        static void RegisterUser()
        {
            User user = new User();

            Console.WriteLine("Enter User Name:");
            user.UserName = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            user.Email = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            user.Password = Console.ReadLine();

            context.Users.Add(user);
            context.SaveChanges();

            Console.WriteLine("User Registered Successfully");
        }

        // 2. Login

        static void Login()
        {
            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();

            User user = context.Users
                .FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user == null)
            {
                Console.WriteLine("Invalid Email or Password");
            }
            else
            {
                loggedInUserId = user.UserId;

                Console.WriteLine("Login Successful");
            }
        }

        // 3. Add New Category

        static void AddCategory()
        {
            Category category = new Category();

            Console.WriteLine("Enter Category Name:");
            category.CategoryName = Console.ReadLine();

            context.Categories.Add(category);
            context.SaveChanges();

            Console.WriteLine("Category Added Successfully");
        }

        // 11. Logout

        static void Logout()
        {
            loggedInUserId = 0;

            Console.WriteLine("Logout Successful");
        }
        // 4. Add Product

        static void AddProduct()
        {
            Product product = new Product();

            Console.WriteLine("Enter Product Name:");
            product.ProductName = Console.ReadLine();

            Console.WriteLine("Enter Price:");
            product.Price = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Category Id:");
            product.CategoryId = int.Parse(Console.ReadLine());

            context.Products.Add(product);
            context.SaveChanges();

            Console.WriteLine("Product Added Successfully");
        }

        // 5. View All Products

        static void ViewAllProducts()
        {
            var products = context.Products.ToList();

            foreach (var product in products)
            {
                Console.WriteLine(
                    $"{product.ProductId} - {product.ProductName} - {product.Price}"
                );
            }
        }

        // 6. Place Order

        static void PlaceOrder()
        {
            if (loggedInUserId == 0)
            {
                Console.WriteLine("Please Login First");
                return;
            }

            Order order = new Order();

            order.OrderDate = DateTime.Now;
            order.UserId = loggedInUserId;

            context.Orders.Add(order);
            context.SaveChanges();

            Console.WriteLine("Order Created Successfully");

            Console.WriteLine("Enter Product Id:");
            int productId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Quantity:");
            int quantity = int.Parse(Console.ReadLine());

            OrderProduct op = new OrderProduct();

            op.OrderId = order.OrderId;
            op.ProductId = productId;
            op.Quantity = quantity;

            context.OrderProducts.Add(op);
            context.SaveChanges();

            Console.WriteLine("Product Added To Order");
        }

        // 7. View My Orders

        static void ViewMyOrders()
        {
            if (loggedInUserId == 0)
            {
                Console.WriteLine("Please Login First");
                return;
            }

            var orders = context.Orders
                .Where(o => o.UserId == loggedInUserId)
                .ToList();

            foreach (var order in orders)
            {
                Console.WriteLine(
                    $"Order Id: {order.OrderId} Date: {order.OrderDate}"
                );
            }
        }

        // 8. View Order Details

        static void ViewOrderDetails()
        {
            Console.WriteLine("Enter Order Id:");
            int orderId = int.Parse(Console.ReadLine());

            var details = context.OrderProducts
                .Where(o => o.OrderId == orderId)
                .ToList();

            foreach (var item in details)
            {
                Console.WriteLine(
                    $"Product Id: {item.ProductId} Quantity: {item.Quantity}"
                );
            }
        }

        // 9. Add Review

        static void AddReview()
        {
            if (loggedInUserId == 0)
            {
                Console.WriteLine("Please Login First");
                return;
            }

            Review review = new Review();

            Console.WriteLine("Enter Order Id:");
            review.OrderId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Rating:");
            review.Rating = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Comment:");
            review.Comment = Console.ReadLine();

            context.Reviews.Add(review);
            context.SaveChanges();

            Console.WriteLine("Review Added Successfully");
        }

        // 10. View Reviews For Product

        static void ViewReviewsForProduct()
        {
            Console.WriteLine("Enter Product Id:");
            int productId = int.Parse(Console.ReadLine());

            var reviews = context.OrderProducts
                .Where(op => op.ProductId == productId)
                .Select(op => op.Order.Review)
                .ToList();

            foreach (var review in reviews)
            {
                if (review != null)
                {
                    Console.WriteLine(
                        $"{review.Rating} - {review.Comment}"
                    );
                }
            }
        }

    }
}