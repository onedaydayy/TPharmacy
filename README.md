# TPharmacy - Online Pharmacy Website
TPharmacy Pte Ltd is a traditional pharmacy that provides beauty, personal care, health care and pharmaceutical products in their stores, along with essential services such as medicine dispensing, professional pharmacist assistance, and counseling on medical conditions and prescriptions. However, with the COVID-19 pandemic, the number of walk-in clients and retail sales reduced, leading to increased competition between retail pharmacies, including big-box retailers, mail-order, and online pharmacies.

To keep up with the trend and attract a broader customer base, TPharmacy Pte Ltd decided to build an appealing online pharmacy website that embraces digital technologies to deliver various pharmacy services and online ordering. According to a Visa study, nearly 74% of consumers in Singapore are shopping online more frequently as a result of the Covid-19 pandemic, and revenue in the Online Pharmacy segment is projected to reach $267.10m in 2022.

TPharmacy online pharmacy website is built using Visual Studio 2019 and .Net 5 Blazor Web Assembly. Blazor Web Assembly allows for the development of rich, interactive web applications using C# and .NET. It enables developers to build fully functional client-side web applications using .NET code, which runs directly in the browser. By using Blazor Web Assembly, TPharmacy is able to create a fast and responsive web application that can deliver an excellent user experience to its customers. The use of .NET 5 also ensures that the application is highly performant and scalable, making it a reliable choice for an online pharmacy website that needs to handle a large volume of customer traffic.

For this project, I created entities for Staff, Order, OrderItem, and Payment and implemented Unit of Works (Repository & IRepository) for all entities. I also performed seeding for User, UseRole, Role, Staff, Order, OrderItem, and Payment entities. I completed the Staff Landing Page and Staff NavBar, along with the controller for Staff, Order, OrderItem, and Payment. I tested these controllers using Postman.

### Customer Features
- Purchase supplements to create an Order, OrderId session, and OrderItem
- Update/delete OrderItem and view Order Details
- View summary of OrderItem with Product Details
- Checkout order to update Order Status to Completed
- Make payment for unpaid orders to update Order Status to Paid
- Edit Payment Details and view summary of Payment Details

### Staff Features
- Create/update/delete Staff, sync with Identity User and Identity Role
- Update Order Status and Staff ID to Completed or another staff
- Staff Home page dashboard based on entity count that updates accordingly
- View all customer Orders with Details, OrderItem with Product Details, and Payment with Details
- View entire Order & Payment Summary and details of individual Order, OrderItem, and Payment
- View summary of total orders and sales amount earned, and summary of orders for order processing

### ERD
<img src="Photo/ERD.png" alt="flowchart" width="900" height="500"><br/>

### Customer SignIn Homepage
<img src="Photo/CustomerHome.png" alt="flowchart" width="650" height="3000"><br/>

### Staff SignIn Homepage
<img src="Photo/StaffHome.jpg" alt="flowchart" width="1500" height="500"><br/>

